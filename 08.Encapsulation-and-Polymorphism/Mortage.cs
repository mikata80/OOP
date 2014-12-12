using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKurtovoKonare
{
    class Mortage :Accounts,IDepositMoney
    {
        public Mortage()
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

            if (this.CustomerType == CusotmerType.Individuals && months > 6)
            {
                caclInter = Balance * (1 + (InterestRate / 100) * (months - 6));
            }
            else if (this.CustomerType == CusotmerType.Companies && months >= 12)
            {
                caclInter = Balance * (1 + (InterestRate / 100/2) * (12));
                caclInter += Balance * (1 + (InterestRate / 100 ) * (months - 12));
            }
            else if (this.CustomerType == CusotmerType.Companies && months < 12)
            {
                caclInter = Balance * (1 + (InterestRate / 100 / 2) * (12-months));
            }

            return String.Format("{0:0.00}", caclInter);
        }
    }
}
