using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models
{
    public abstract class GameObject : Control
    {
        public GameObject(Color backColor , Point location, Size size)
            : base("", location.X, location.Y, size.Width, size.Height)
        {
            base.BackColor = backColor;
        }
    }
}
