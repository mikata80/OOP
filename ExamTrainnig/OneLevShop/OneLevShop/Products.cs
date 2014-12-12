using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLevShop
{
    public class Product : IBuyable
    {
        public Product(string name, double price, double qty, AgeRestriction ageRestriction)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = qty;
            this.AgeRestriction = ageRestriction;
        }
        public string Name { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }

        public AgeRestriction AgeRestriction { get; set; }


        public virtual double getPrice()
        {
            return this.Price;
        }
    }
}
