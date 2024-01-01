using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models
{
    public class GameOverEventArgs : EventArgs
    {
        public Player? Player { get; set; }
    }
}
