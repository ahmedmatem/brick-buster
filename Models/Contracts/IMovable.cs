﻿using BrickGameGuiApp.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGameGuiApp.Models.Contracts
{
    public interface IMovable
    {
        Point Direction { get; }
        Point Speed { get; }
        void DoMove();
        Point NextLocation();
        DirectionName GetDirectionName();
        void ChangeDirection(Point newDirection);
    }
}
