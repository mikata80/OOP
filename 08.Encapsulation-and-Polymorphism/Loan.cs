using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKurtovoKonare
{
    class Loan :Accounts,IDepositMoney
    {
        public Loan()
            :base()
        {

        }

        public void addMoneyToBalance(double money)
        {
            this.Balance += money;
        }

        public override string calculateInterest(double balance, double interestRate, int months)
        {
            double caclInter = 0;
            if (months <= 0)
            {
                throw new ArgumentOutOfRangeException("Months must be >0!");
            }


            if (this.CustomerType == CusotmerType.Individuals && months > 3)
            {
                caclInter = Balance * (1 + (InterestRate / 100) * (months - 3));
            }
            else if (this.CustomerType == CusotmerType.Companies && months > 2)
            {
                caclInter = Balance * (1 + (InterestRate / 100) * (months - 2));
            }

            return String.Format("{0:0.00}", caclInter);
        }
    }
}
