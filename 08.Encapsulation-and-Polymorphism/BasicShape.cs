using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class BasicShape :IShape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public BasicShape(double w, double h)
        {
            this.Width = w;
            this.Height = h;
        }

        public abstract void CalculateArea();

        public abstract void CalculatePerimeter();
    }
}
