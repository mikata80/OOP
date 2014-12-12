using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLevShop
{
    public class Customer
    {
        private string name;
        private int age;
        private double balance;

        public Customer(string name, int age, double balance)
        {
            this.Name = name;
            this.Age = age;
            this.Balance = balance;
        }

        public string Name {

            get 
            {
                return this.name;
            }

            set 
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("The customer name can be empty!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 8)
                {
                    throw new ArgumentOutOfRangeException("The customer age i less than 8 years!");
                }

                this.age = value;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
               
                this.balance = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Customer:\n\tName: {0}\n\tAge: {1}\n\tBalance: {2}", this.name, this.age, String.Format("{0:0.00##}",this.balance));
        }
    }
}
