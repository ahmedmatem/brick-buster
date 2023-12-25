using BrickGameGuiApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models
{
    public class GuiEngine : IEngine
    {
        private Brick[,] wall;

        public GuiEngine(Brick[,] wall) 
        {
            this.wall = wall;
        }

        public Brick[,] Wall => wall;

        public void Run()
        {
            //throw new NotImplementedException();
        }
    }
}
