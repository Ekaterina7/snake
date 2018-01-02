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
            Point p1 = new Point();
            p1.x = 3;
            p1.y = 4;
            p1.syn = '*';
            p1.Draw();
            Point p2 = new Point();
            p2.x = 2;
            p2.y = 4;
            p2.syn = '/';
            p2.Draw();
            Console.ReadLine();
        }

     
    }
}
