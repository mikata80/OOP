using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle :IShape
    {
        private double radius;

        public double Radius { get; set; }

        public Circle( double r)
        {
            this.Radius = r;
        }

        public void CalculateArea()
        {
            double area = Math.PI * this.Radius*this.Radius;
            Console.WriteLine(this.GetType().Name + " area = " + area);
        }

        public void CalculatePerimeter()
        {
            double p = 2 * Math.PI * this.Radius;
            Console.WriteLine(this.GetType().Name + " perimeter = " + p);
        }
    }
}
