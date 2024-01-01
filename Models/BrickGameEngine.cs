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
        private FormTimer timer;

        private Player player;
        private GameObject[,] wall;
        private MovableGameObject paddle;
        private MovableGameObject ball;

        public BrickGameEngine(
            Player player,
            GameObject[,] wall,
            MovableGameObject paddle,
            MovableGameObject ball)
            : base(Config.BoardWidth, Config.BoardHeight)
        {
            this.player = player;
            this.wall = wall;
            this.paddle = paddle;
            this.ball = ball;
        }

        public override void Run()
        {
            timer = new FormTimer();
            timer.Interval = Config.FrameRate;
            timer.Tick += MovePaddle;   // atach paddle move handler
            timer.Tick += MoveBall;     // atach ball move event handler
            timer.Enabled = true;
        }

        // Handle Keyboard keys pressing
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

            if(keyData == Keys.Down)
            {
                paddle.ChangeDirection(new Point(0, 0));
            }
        }

        private void MovePaddle(object? sender, EventArgs e)
        {
            Move(paddle);
        }

        private void MoveBall(object? sender, EventArgs e)
        {
            // Ball next location
            Point ballNextLocation = ball.NextLocation();

            // Detect ball collision before move
            if (ballNextLocation.X <= 0 || ballNextLocation.X + ball.Width >= BoardWidth - ball.Width)
            {
                ball.ChangeDirection(new Point(-ball.Direction.X, ball.Direction.Y));
            }
            else if (ballNextLocation.Y <= 0)
            {
                ball.ChangeDirection(new Point(ball.Direction.X, -ball.Direction.Y));
            }
            else if (ballNextLocation.Y + ball.Height >= paddle.Location.Y)
            {
                if (ballNextLocation.X > paddle.Location.X && ballNextLocation.X <= paddle.Location.X + paddle.Width - 1)
                {
                    ball.ChangeDirection(new Point(ball.Direction.X, -ball.Direction.Y));
                }
                else
                {
                    // Game is over
                    timer.Enabled = false; // stop timer
                    // show game over info panel with player score
                    GameOverEventArgs eventArgs = new GameOverEventArgs();
                    eventArgs.Player = player;
                    OnGameOver(eventArgs);
                }
            }

            // if (the ball is in the wall)
            if (ballNextLocation.Y <= wall.GetLength(0) * Config.BrickHeight) 
            {
                // Get the hitted brick
                GameObject? hittedBrick = GetHittedBrickBy(ballNextLocation);
                if (hittedBrick != null)
                {
                    // Remove hitted brick
                    hittedBrick.Hide();
                    // Add brick points to player active
                    player.Score += hittedBrick.Points;

                    // Change ball direction
                    var ballDirection = ball.GetDirectionName();
                    if (ballDirection == DirectionName.UpLeft)
                    {
                        ball.ChangeDirection(new Point(-1, 1));
                    }
                    else if (ballDirection == DirectionName.UpRight)
                    {
                        ball.ChangeDirection(new Point(1, 1));
                    }
                    ball.Invalidate();
                }
            }

            Move(ball);
        }

        private GameObject? GetHittedBrickBy(Point ballNextLocation)
        {
            for (int row = 0; row < wall.GetLength(0); row++)
            {
                for (int col = 0; col < wall.GetLength(1); col++)
                {
                    if (!wall[row, col].Visible) continue;

                    if (wall[row, col].Contains(ballNextLocation))
                    {
                        return wall[row, col];
                    }
                }
            }
            return null;
        }
    }
}
