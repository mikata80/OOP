using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKurtovoKonare
{
    public abstract class Accounts : ICustomer
    {
        private string firstName;
        private string lastName;
        private double rate;

        public CusotmerType CustomerType { get; set; }

        public double Balance { get; set; }

        public double InterestRate
        {
            get
            {
                return this.rate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate must be >0!");
                }

                this.rate = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("First name cannot be empty! ");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("Last name cannot be empty! ");
                }

                this.lastName = value;
            }
        }

        public Accounts()
        {

        }

        public Accounts(CusotmerType customerType, double balance, double interestRate, string firstName, string lastName)
        {
            this.CustomerType = customerType;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return String.Format("Account type: " + this.GetType().Name + "\n" + "Customer: {0} {1}\nCustomer type: {2}\nBalance: {3}\nInterest rate: {4}\n",
                FirstName,
                LastName,
                CustomerType,
                Balance,
                InterestRate);
        }

        public virtual string calculateInterest(double balance, double interestRate, int months)
        {
            return String.Format("{0:00}" + 0.00);
        }
    }
}
