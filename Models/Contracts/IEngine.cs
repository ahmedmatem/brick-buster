using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models.Contracts
{
    public interface IEngine
    {
        void Run();
        Brick[,] Wall { get; }
    }
}
