using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLevShop
{
    public abstract class  ElectonicsProduct :Product
    {
        private int guarantee;

        public ElectonicsProduct(string name, double price, double qty, AgeRestriction ageRestriction, int guarantee)
            :base(name,price,qty,ageRestriction)
        {
            this.Guarantee = guarantee;
        }
        public int Guarantee  { get; set; }
    }
}
