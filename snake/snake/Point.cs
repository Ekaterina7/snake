﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char syn;
        public Point(int _x, int _y, char _syn)
        {
            x = _x;
            y = _y;
            syn = _syn;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(syn);
        }             
    }
}
