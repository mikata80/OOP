using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLevShop
{
    public static class PurchaseManager
    {
        public static void ProcessPurchase(Customer customer, Product product)
        {
            if (product.Quantity <= 0)
            {
                Console.WriteLine("Product is out of stock!!!");
            }

            if (customer.Balance < product.Price)
            {
                Console.WriteLine("You do not have enough money to buy this product!");
            }

            if ((customer.Age < 18) ||
                (product.AgeRestriction == AgeRestriction.Adult) ||
                (product.AgeRestriction == AgeRestriction.Teenager))
            {
                Console.WriteLine("You are too young to buy this product!");
            }

            customer.Balance -= product.Price;
            product.Quantity -= 1;
        }
    }
}
