﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    enum Direction
    {
        Left,Right,Up,Down
    }
    internal interface iSnake
    {
            public void EatMeal()
            { }
            public void Move()
             { }
    }
}
