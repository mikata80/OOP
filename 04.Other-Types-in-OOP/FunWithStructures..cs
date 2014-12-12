using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other_Types_in_OOP
{
    class FunWithStructures
    {
        struct Point {

            public int X;
            public int Y;

            public Point(int Xpos, int Ypos) {
                X = Xpos;
                Y = Ypos;
            }

            public void Increment() {
                X++; Y++;
            }

            public void Decrement()
            {
                X--; Y--;
            }

            public void Display() {
                Console.WriteLine("X = {0}, Y = {1}",X,Y);
            }
        }

        static void Main()
        {
            Point point = new Point(10,20);
            point.Display();
        }
    }
}
