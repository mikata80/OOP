using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Payment
    {
        public string ProductName { get; set; }

        public double Price { get; set; }

        public Payment()
        {

        }

        public Payment( string pName, double pPrice)
        {
            this.ProductName = pName;
            this.Price = pPrice;
        }
    }
}
