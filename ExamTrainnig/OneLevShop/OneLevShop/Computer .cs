using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLevShop
{
    class Computer : ElectonicsProduct
    {
        public Computer(string name, double price, double qty, AgeRestriction ageRestriction, int guarantee = 24)
            : base(name, price, qty, ageRestriction,guarantee)
        {

        }

        public override double getPrice()
        {
            double resPrice = this.Price;
            if (this.Quantity > 1000)
            {
                resPrice = resPrice * 95 / 100;
            }
            return resPrice;
        }
    }
}
