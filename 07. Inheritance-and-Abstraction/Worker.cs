using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorkerStudents
{
    class Worker : Human
    {
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }
        public Worker(double weekSalary, double workHoursPerDay, string firstname, string lastname)
            : base(firstname, lastname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour(double weekSalary, double workHoursPerDay)
        {
            double result = weekSalary/5/workHoursPerDay;
            return result;
        }
    }
}
