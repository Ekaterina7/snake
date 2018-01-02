using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,1,'*');
            p1.Draw();
            Point p2 = new Point(2,3,'#');
            p2.Draw();
            HorizontalLine line = new HorizontalLine(5,10,3,'*');
            line.Drow();
            VerticalLine line2 = new VerticalLine(0, 5, 9, '#');
            line2.Drow();
            Console.ReadLine();
            

        }

     
    }
}
