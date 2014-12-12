using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapeExample
    {
        static void Main()
        {
            dynamic[] shapes = {
               new Triangle(12, 23.5),
               new Rectangle(6.5, 8.3),
               new Circle(43.5)
            };

            foreach (var item in shapes)
            {
                item.CalculateArea();
                item.CalculatePerimeter();
            }
        }
    }
}
