using BrickGameGuiApp.Models.Contracts;
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
            MovableGameObject ball,
            EventHandler ballMoveEventHandler)
            : base(Config.BoardWidth, Config.BoardHeight)
        {
            this.wall = wall;
            this.paddle = paddle;
            this.ball = ball;
            BallMove = ballMoveEventHandler;
        }

        public override void Run()
        {
            FormTimer timer = new FormTimer();
            timer.Interval = Config.FrameRate;
            timer.Tick += BallMove; // atach BallMove event handler
            timer.Enabled = true;
        }
    }
}
