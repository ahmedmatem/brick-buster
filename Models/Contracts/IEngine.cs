using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models.Contracts
{
    public interface IEngine
    {
        void Run();
        void Move(MovableGameObject mgo);
        void ProcessCmdKey(Keys keyData);
    }
}
