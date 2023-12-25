using BrickGameGuiApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models
{
    public class Ball : MovableGameObject
    {
        private static Color backColor = Config.BallBackColor;
        private static Size size = new Size(Config.BallRadius * 2, Config.BallRadius * 2);
        private static Point location = new Point(Config.BallStartX, Config.BallStartY);
        private static Point direction = Config.BallDirection;
        private static Point speed = Config.BallSpeed;

        public Ball() : base(backColor, location, size, direction, speed) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(e.ClipRectangle);
            //e.Graphics.FillRegion(Brushes.Green, new Region(graphicsPath));
            e.Graphics.FillEllipse(Brushes.OrangeRed, e.ClipRectangle);

        }
    }
}
