﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
       protected List<Point> plist;

        public void Drow()

        {
            foreach (var i in plist)
            {
                i.Draw();
            }
        }
    }
}
