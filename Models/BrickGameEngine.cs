using BrickGameGuiApp.Models.Contracts;
using BrickGameGuiApp.Models.Types;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormTimer = System.Windows.Forms.Timer;

namespace BrickGameGuiApp.Models
{
    public class BrickGameEngine : BoardGameEngine
    {
        private Brick[,] wall;
        private MovableGameObject paddle;
        private MovableGameObject ball;
        private EventHandler BallMove;

        public BrickGameEngine(
            Brick[,] wall, 
            MovableGameObject paddle,
            MovableGameObject ball)
            : base(Config.BoardWidth, Config.BoardHeight)
        {
            this.wall = wall;
            this.paddle = paddle;
            this.ball = ball;
        }

        public override void Run()
        {
            FormTimer timer = new FormTimer();
            timer.Interval = Config.FrameRate;
            timer.Tick += MovePaddle;   // atach paddle move handler
            timer.Tick += MoveBall;     // atach ball move event handler
            timer.Enabled = true;
        }

        public override void ProcessCmdKey(Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                paddle.ChangeDirection(new Point(-1, 0));
            }

            if (keyData == Keys.Right)
            {
                paddle.ChangeDirection(new Point(1, 0));
            }
        }

        private void MovePaddle(object? sender, EventArgs e)
        {
            Move(paddle);
        }

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

            Move(ball);
        }
    }
}
