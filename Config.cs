using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp
{
    public static class Config
    {
        private static int bottomOffset = 60;

        public static int FrameRate = 40; // in milliseconds

        /*
         * Board configurations
         */
        public static int BoardWidth = 1000;
        public static int BoardHeight = 600;

        /*
         * Wall configurations
         */
        public static int WallCols = 20;
        public static int WallRows = 6;


        /*
         * Brick object configurations
         */
        public static int BrickWidth = BoardWidth / (WallCols - 1);
        public static int BrickHeight = BrickWidth / 3;
        public static Color BrickColor = Color.Brown;

        /*
         * Ball object configurations
         */
        public static Color BallBackColor = Color.White;
        public static int BallRadius = BrickHeight / 2;
        public static int BallStartX = (BoardWidth - BallRadius) / 2;
        public static Point BallSpeed = new Point(5, 5);
        public static Point BallDirection = new Point(1, -1); // top-right direction
        // Todo: Fix ball Y coordinate
        public static int BallStartY = BoardHeight - bottomOffset - 2 * BallRadius;

        /*
         * Paddle object configurations
         */
        public static Color PaddleColor = Color.Brown;
        public static int PaddleWidth = 100;
        public static int PaddleHeight = 10;
        public static int PaddleStartX = (BoardWidth - PaddleWidth) / 2;
        public static int PaddleStartY = BoardHeight - bottomOffset;
        public static Point PaddleSpeed = new Point(10, 0);
        public static Point PaddleDirection = new Point(0, 0);
    }
}
