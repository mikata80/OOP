using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLevShop
{
    class Appliance :ElectonicsProduct
    {
        public Appliance(string name, double price, double qty, AgeRestriction ageRestriction, int guarantee = 6)
            : base(name, price, qty, ageRestriction,guarantee)
        {

        }

        public override double getPrice()
        {
            double resPrice = this.Price;
            if (this.Quantity < 50)
            {
                resPrice = resPrice * 105 / 100;
            }
            return resPrice;
        }
    }
}
