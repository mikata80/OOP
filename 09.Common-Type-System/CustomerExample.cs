using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class CustomerExample
    {
        static void Main()
        {
            Customer milen = new Customer();
            milen.FirstName = "Milen";
            milen.MiddleName = "Angelov";
            milen.LastName = "Petrov";
            milen.EGN = 800417598789;
            milen.PermanentAddress = "Dunpca, Krali marko 44";
            milen.Email = "mikata80#gmail.com";
            milen.MobilePhone = "0888989989";
            milen.customerType = CustomerType.Golden;
            milen.payments = new List<Payment>() {
                new Payment("CPU",100),
                new Payment("MB",250),
                new Payment("RAM",170)
            };


            Customer petq = new Customer();
            petq.FirstName = "Petq";
            petq.MiddleName = "Angelova";
            petq.LastName = "Ilieva";
            petq.EGN = 790417598789;
            petq.PermanentAddress = "Dunpca, Krali marko 44";
            petq.Email = "mikata80#gmail.com";
            petq.MobilePhone = "0888989989";
            petq.customerType = CustomerType.Golden;
            petq.payments = new List<Payment>() {
                new Payment("CPU",100),
                new Payment("MB",250),
                new Payment("RAM",170)
            };

            Console.WriteLine(milen.ToString());
            Console.WriteLine(petq.ToString());
            Console.WriteLine();
            Console.WriteLine("Equal: {0}\n", milen.Equals(petq));
            Console.WriteLine("==: {0}\n", milen == petq);
            Console.WriteLine("!=: {0}\n", milen != petq);
            Console.WriteLine("GetHashCode: {0}", milen.GetHashCode());
            Console.WriteLine("GetHashCode: {0}", petq.GetHashCode());
            Console.WriteLine();
            Customer mikata2 = (Customer)milen.Clone();
            Console.WriteLine(mikata2.ToString());

            Customer[] customers = {milen, mikata2, petq};
            Console.WriteLine("=====================================");
            Array.Sort(customers,
                (a,b)=>
                    a.getFullName().CompareTo(b.getFullName())
                    );

            foreach (var c in customers)
            {
                Console.WriteLine(c.ToString());
            }
        }

    }
}
