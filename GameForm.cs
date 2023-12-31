using BrickGameGuiApp.Models;
using BrickGameGuiApp.Models.Types;
using FormTimer = System.Windows.Forms;

namespace BrickGameGuiApp
{
    public partial class GameForm : Form
    {
        private GameObject[,] wall = new Brick[Config.WallRows, Config.WallCols];
        private MovableGameObject ball = new Ball();
        private MovableGameObject paddle = new Paddle();

        private BoardGameEngine engine;

        public GameForm()
        {
            InitializeComponent();

            InitializeWindow();
            InitializeWall();
            InitializeBall();
            InitializePaddle();

            engine = new BrickGameEngine(wall, paddle, ball);
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

        private void InitializeBall()
        {
            Controls.Add(ball);
        }

        private void InitializePaddle()
        {
            Controls.Add(paddle);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            engine.ProcessCmdKey(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}