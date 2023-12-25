﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models.Types
{
    public enum DirectionName
    {
        None = 0b00000000,      // 0
        Up = 0b00000001,        // 1
        Down = 0b00000010,      // 2
        Left = 0b00000100,      // 4
        Right = 0b00001000,     // 16
    }
}
