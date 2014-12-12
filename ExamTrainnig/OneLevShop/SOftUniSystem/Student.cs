using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOftUniSystem
{
    public abstract class Student :Person
    {
        public string StudentNumber { get; set; }
        public double AverageGrade { get; set; }

        public Student()
        {

        }
        public Student(string studentNumber, int averageGrade)
            :base()
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }
    }
}
