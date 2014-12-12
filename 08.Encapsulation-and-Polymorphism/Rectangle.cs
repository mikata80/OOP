using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double w, double h)
            : base(w, h)
        {

        }

        public override void CalculateArea()
        {
            double area = (this.Height * this.Width);
            Console.WriteLine(this.GetType().Name + " area = " + area);
        }

        public override void CalculatePerimeter()
        {
            double p = 2*this.Height + 2*this.Width;
            Console.WriteLine(this.GetType().Name + " perimeter = " + p);
        }
    }
}
