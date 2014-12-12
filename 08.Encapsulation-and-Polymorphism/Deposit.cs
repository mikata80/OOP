using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKurtovoKonare
{
    class Deposit : Accounts, IDepositMoney, IWithDraw
    {
        public Deposit()
            : base()
        {

        }

        public void addMoneyToBalance(double money)
        {
            this.Balance += money;
        }

        public void removeMoneyFromBalance(double money)
        {
            this.Balance -= money;
        }

        public override string calculateInterest(double balance, double interestRate, int months)
        {
            double caclInter = 0;

            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("Months must be >0!");
            }


            if (this.Balance > 100)
            {
                caclInter = Balance * (1 + (InterestRate / 100) * months);
            }

            return String.Format("{0:0.##}", caclInter);
        }
    }
}
