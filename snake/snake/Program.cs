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
            int x1 = 5;
            int y1 = 3;
            char syn1 = '*';
            Draw(x1, y1, syn1);
            Console.ReadLine();
        }

        static void Draw (int x, int y, char syn)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(syn);
        }
    }
}
