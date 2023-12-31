using BrickGameGuiApp.Models.Contracts;
using BrickGameGuiApp.Models.Types;

namespace BrickGameGuiApp.Models
{
    public abstract class MovableGameObject : GameObject, IMovable
    {
        private Point direction;

        public Point Direction { get => direction; private set { direction = value; } }

        public Point Speed { get; }

        protected MovableGameObject(
            Color backColor,
            Point location,
            Size size,
            Point direction,
            Point speed) : base(backColor, location, size)
        {
            Direction = direction;
            Speed = speed;
        }

        public void ChangeDirection(Point newDirection)
        {
            Direction = newDirection;
        }

        public void DoMove() => Location = NextLocation();

        public Point NextLocation()
        {
            return new Point(Location.X + Direction.X * Speed.X, Location.Y + Direction.Y * Speed.Y);
        }

        public DirectionName GetDirectionName()
        {
            if (Direction.X == 0 && Direction.Y == -1)
            {
                return DirectionName.Up;
            }
            else if (Direction.X == 0 && Direction.Y == 1)
            {
                return DirectionName.Down;
            }
            else if (Direction.X == -1 && Direction.Y == 0)
            {
                return DirectionName.Left;
            }
            else if (Direction.X == 1 && Direction.Y == 0)
            {
                return DirectionName.Right;
            }
            else if (Direction.X == -1 && Direction.Y == -1)
            {
                return DirectionName.UpLeft;
            }
            else if (Direction.X == 1 && Direction.Y == -1)
            {
                return DirectionName.UpRight;
            }
            else if (Direction.X == -1 && Direction.Y == 1)
            {
                return DirectionName.DownLeft;
            }
            else if (Direction.X == 1 && Direction.Y == 1)
            {
                return DirectionName.DownRight;
            }

            return DirectionName.None;
        }
    }
}
