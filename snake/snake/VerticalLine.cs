using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine :Figure
    {
       
        public VerticalLine(int yStart, int yFinish, int x, char syn)
        {
            plist = new List<Point>();
            for (int y  = yStart; y <= yFinish; y++)
            {
                Point p = new Point(x, y, syn);
                plist.Add(p);
            }
        }
      
    }
}
