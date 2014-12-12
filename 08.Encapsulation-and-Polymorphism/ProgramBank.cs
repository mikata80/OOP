using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKurtovoKonare
{
    class ProgramBank
    {
        static void Main()
        {

            Deposit mikata = new Deposit();
            mikata.FirstName = "Milen";
            mikata.LastName = "Petrov";
            mikata.CustomerType = CusotmerType.Individuals;
            mikata.Balance = 2200.56;
            mikata.InterestRate = 8.5;
            mikata.addMoneyToBalance(100);
            mikata.removeMoneyFromBalance(20);


            Loan itsoft = new Loan();
            itsoft.FirstName = "ItSoft";
            itsoft.LastName = "EOOD";
            itsoft.CustomerType = CusotmerType.Companies;
            itsoft.Balance = 50000;
            itsoft.InterestRate = 6.6;

            Mortage tosho = new Mortage();
            tosho.FirstName = "Todor";
            tosho.LastName = "Nakev";
            tosho.CustomerType = CusotmerType.Individuals;
            tosho.Balance = 150000;
            tosho.InterestRate = 5.59;

            int months = 36;
            IList<Accounts> bankacc = new List<Accounts>()
            {
                mikata,
                itsoft,
                tosho

            };

            foreach (var ba in bankacc)
            {
                Console.WriteLine(ba.ToString() + "Calculated interest: " + ba.calculateInterest(ba.Balance, ba.InterestRate, months) + "\n");
            }

            
        }
    }
}
