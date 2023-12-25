using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace BrickGameGuiApp.Models
{
    public class Brick : GameObject
    {
        private static Color backColor = Config.BrickColor;
        private static Size size = new Size(Config.BrickWidth, Config.BrickHeight);

        public Brick(Point location) 
            : base(backColor, location, size)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid);
        }
    }
}
