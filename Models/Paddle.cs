using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models
{
    public class Paddle : MovableGameObject
    {
        private static Color backColor = Config.PaddleColor;
        private static Point location = new Point(Config.PaddleStartX, Config.PaddleStartY);
        private static Size size = new Size(Config.PaddleWidth, Config.PaddleHeight);
        private static Point direction = Config.PaddleDirection;
        private static Point speed = Config.PaddleSpeed;

        public Paddle() : base(backColor, location, size, direction, speed) { }
    }
}
