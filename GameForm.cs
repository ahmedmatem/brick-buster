using BrickGameGuiApp.Models;
using BrickGameGuiApp.Models.Types;
using FormTimer = System.Windows.Forms;

namespace BrickGameGuiApp
{
    public partial class GameForm : Form
    {
        private Brick[,] wall = new Brick[Config.WallRows, Config.WallCols];
        private MovableGameObject ball = new Ball();
        private MovableGameObject paddle = new Paddle();

        private BoardGameEngine engine;

        public GameForm()
        {
            InitializeComponent();

            InitializeWindow();
            InitializeWall();
            Controls.Add(ball);
            Controls.Add(paddle);

            engine = new BrickGameEngine(wall, paddle, ball, MoveBall);
            engine.Run();
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
            if (directionName == (DirectionName.Up | DirectionName.Left)) // UP-LEFT
            {

            }
            else if (directionName == (DirectionName.Up | DirectionName.Right)) // UP-RIGHT
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

            engine.Move(ball);
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

            engine.Move(paddle);

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}