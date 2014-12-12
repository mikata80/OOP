using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLevShop
{
    class Program
    {
      public static void Main()
        {
            //FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400, AgeRestriction.Adult);
            //Customer pecata = new Customer("Pecata", 17, 30.00);
            //PurchaseManager.ProcessPurchase(pecata, cigars);
            //Customer gopeto = new Customer("Gopeto", 18, 0.44);
            //PurchaseManager.ProcessPurchase(gopeto, cigars);
            FoodProduct cheese = new FoodProduct("Vitosha", 16.40, 1.50, AgeRestriction.None);
            Customer mikata = new Customer("Mikata", 34, 100.00);
            PurchaseManager.ProcessPurchase(mikata, cheese);
            Console.WriteLine(mikata.ToString());
            //Customer vankata = new Customer("Ivan", 14, 40.00);
            //PurchaseManager.ProcessPurchase(vankata, cheese);
            FoodProduct meat = new FoodProduct("meat", 10, 10.50, AgeRestriction.None, "19-10-2014");
            PurchaseManager.ProcessPurchase(mikata, meat);
            Console.WriteLine(mikata.ToString());
    
        }
    }
}
