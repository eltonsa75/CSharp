﻿using System;


namespace Structs
{
    struct Point
    {
        public double X; 
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
   
}
