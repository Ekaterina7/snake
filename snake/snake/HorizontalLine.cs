using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine
    {
        List<Point> plist;
        public HorizontalLine(int xLeft, int xRight, int y, char syn)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,syn);
                plist.Add(p);
            }
            


        }
        public void Drow()

        {
            foreach (var i in plist)
            {
                i.Draw();
            }
        }
    }
}
