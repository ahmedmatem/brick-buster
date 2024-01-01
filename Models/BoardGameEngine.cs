using BrickGameGuiApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models
{
    public abstract class BoardGameEngine : IEngine
    {
        public event EventHandler<GameOverEventArgs> GameOver;

        public int BoardWidth { get;}
        public int BoardHeight { get; }

        public BoardGameEngine(int boardWidth, int boardHeight)
        {
            BoardWidth = boardWidth;
            BoardHeight = boardHeight;
        }

        public abstract void Run();

        protected virtual void OnGameOver(GameOverEventArgs e)
        {
            EventHandler<GameOverEventArgs> handler = GameOver;
            if (handler != null)
            {
                GameOver?.Invoke(this, e);
            }
        }

        public virtual void Move(MovableGameObject mgo)
        {
            Point destination = mgo.NextLocation();
            if (IsPossibleObjectLocation(mgo, destination))
            {
                mgo.DoMove();
            }
        }

        private bool IsPossibleObjectLocation(MovableGameObject obj, Point destination)
        {
            return destination.X >= 0 && destination.X < BoardWidth - obj.Width
                && destination.Y >= 0 && destination.Y < BoardHeight - obj.Height;
        }

        public abstract void ProcessCmdKey(Keys keyData);
    }
}
