using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models
{
    public abstract class GameObject : Control
    {
        protected GameObject(Color backColor , Point location, Size size)
            : base("", location.X, location.Y, size.Width, size.Height)
        {
            base.BackColor = backColor;
        }

        public virtual bool Contains(Point point)
        {
            return point.X >= Location.X && point.X < Location.X + Width && point.Y >= Location.Y && point.Y < Location.Y + Height;
        }
    }
}
