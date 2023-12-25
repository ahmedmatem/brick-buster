using BrickGameGuiApp.Models;
using BrickGameGuiApp.Models.Contracts;
using BrickGameGuiApp.Models.Types;
using FormTimer = System.Windows.Forms;

namespace BrickGameGuiApp
{
    public partial class GameForm : Form
    {
        private IEngine engine;

        private FormTimer.Timer timer;
        private Brick[,] wall = new Brick[Config.WallRows, Config.WallCols];
        private Ball ball;
        private Paddle paddle;

        public GameForm()
        {
            InitializeComponent();

            InitializeWindow();
            InitializeWall();
            InitializeBall();
            InitializePaddle();

            engine = new GuiEngine(wall);
            engine.Run();

            StartGame();
        }

        private void StartGame()
        {
            timer = new FormTimer.Timer();
            timer.Interval = Config.FrameRate;
            timer.Tick += MoveBall; // atach MoveBall handler
            timer.Enabled = true;
        }

        private void InitializePaddle()
        {
            paddle = new Paddle();
            Controls.Add(paddle);
        }

        private void InitializeBall()
        {
            ball = new Ball();
            Controls.Add(ball);
        }

        private void InitializeWindow()
        {
            ClientSize = new Size(Config.BoardWidth, Config.BoardHeight);
            MaximumSize = ClientSize;
            MinimumSize = ClientSize;
        }

        private void InitializeWall()
        {
            int brickLeft, brickTop;
            for (int row = 0; row < wall.GetLength(0); row++)
            {
                brickTop = row * Config.BrickHeight;
                for (int col = 0; col < wall.GetLength(1); col++)
                {
                    brickLeft = col * Config.BrickWidth;
                    wall[row, col] = new Brick(new Point(brickLeft, brickTop));
                    Controls.Add(wall[row, col]);
                }
            }
        }

        // Ball moving
        private void MoveBall(object? sender, EventArgs e)
        {
            // TODO: Detect ball collision before move
            Point nextLocation = ball.NextLocation();
            DirectionName directionName = ball.GetDirectionName();

            // Detect ball direction
            if(directionName == (DirectionName.Up | DirectionName.Left)) // UP-LEFT
            {
                
            }
            else if(directionName == (DirectionName.Up | DirectionName.Right)) // UP-RIGHT
            {

            }
            else if (directionName == (DirectionName.Down | DirectionName.Left)) // DOWN-LEFT
            {

            }
            else if (directionName == (DirectionName.Down | DirectionName.Right)) // DOWN-RIGHT
            {

            }
            else if (directionName == DirectionName.Up) // UP
            {

            }
            else if (directionName == DirectionName.Down) // DOWN
            {

            }

            MoveObject(ball);
        }

        // Paddle moving
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Set paddle direction
            if (keyData == Keys.Left)
            {
                paddle.ChangeDirection(new Point(-1, 0));
            }

            if (keyData == Keys.Right)
            {
                paddle.ChangeDirection(new Point(1, 0));
            }

            MoveObject(paddle);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private bool IsPossibleObjectLocation(MovableGameObject obj, Point destination)
        {
            return destination.X >= 0 && destination.X < Config.BoardWidth - obj.Width
                && destination.Y >= 0 && destination.Y < Config.BoardHeight - obj.Height;
        }

        private void MoveObject(MovableGameObject mgo)
        {
            Point destination = mgo.NextLocation();
            if(IsPossibleObjectLocation(mgo, destination))
            {
                mgo.DoMove();
            }
        }
    }
}