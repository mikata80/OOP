using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : BasicShape
    {
        public Triangle(double w, double h)
            : base(w, h)
        {

        }

        public override void CalculateArea()
        {
            double area = (this.Height * this.Width) / 2; 
            Console.WriteLine(this.GetType().Name + " area = " + area);
        }

        public override void CalculatePerimeter()
        {
            double p = this.Height + this.Width;
            Console.WriteLine(this.GetType().Name + " perimeter = " + p);
        }
    }
}
