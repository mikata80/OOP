using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOftUniSystem
{
    class Program
    {
        public static void Main()
        {
            SeniorTrainer sin = new SeniorTrainer();
            sin.FirstName = "Milen";
            sin.LastName = "Petrov";
            sin.Age = 34;
            sin.CourseName = new List<string> { "Java", "C#" ,"Piton","HTML"};
            sin.CreateCourse();
            Console.WriteLine();
            sin.DeleteCourse("Java");
            Console.WriteLine(sin.ToString());
            Console.WriteLine("====================");
            JuniorTrainer jun = new JuniorTrainer();
            jun.FirstName = "Bobi";
            jun.LastName = "Petrov";
            jun.Age = 32;
            jun.CourseName = new List<string> { "PHP" };
            jun.CreateCourse();
            Console.WriteLine();
            Console.WriteLine(jun.ToString());
            Console.WriteLine("====================");
            List<Student> students = new List<Student>();
            OnsiteStudent mikata = new OnsiteStudent();
            mikata.FirstName = "Milen";
            mikata.LastName = "Petrov";
            mikata.Age = 34;
            mikata.StudentNumber = "9846546546";
            mikata.CurrentCourse = new List<string>() { "Java", "C#" };
            mikata.AverageGrade = 4.20;
            mikata.NumberOfvisits = 150;
            students.Add(mikata);
        }
    }
}
