using BrickGameGuiApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models
{
    public abstract class GameObject : Control, IValuable
    {
        private int points = 0;

        protected GameObject(Color backColor , Point location, Size size, int points = 0)
            : base("", location.X, location.Y, size.Width, size.Height)
        {
            base.BackColor = backColor;
            Points = points;
        }

        public int Points { get => points; private set => points = value; }

        public virtual bool Contains(Point point)
        {
            return point.X >= Location.X && point.X < Location.X + Width && point.Y >= Location.Y && point.Y < Location.Y + Height;
        }
    }
}
