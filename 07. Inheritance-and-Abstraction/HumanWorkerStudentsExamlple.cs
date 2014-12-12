using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorkerStudents
{
    class HumanWorkerStudentsExamlple
    {
        static void Main()
        {
            //Students
            Console.WriteLine("Students:");
            Console.WriteLine("---------------");
            List<Student> students = new List<Student>();
            Random rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
                students.Add(new Student(GenerateHumanFistName(rand), GenerateHumanLastName(rand), GenerateFacultyNumber(rand)));
            }

            var sortedStudents = from student in students
                                 orderby student.Faultynumber
                                 ascending
                                 select student;
            foreach (var s in sortedStudents)
            {
                Console.WriteLine(s.GetStudentNameFacultyNumber());
            }
            //workers
            Console.WriteLine("\nWorkers:");
            Console.WriteLine("---------------");
            List<Worker> workers = new List<Worker>();
            Random sallary = new Random();
            for (int i = 1; i <= 10; i++)
            {
                workers.Add(new Worker(rand.Next(100, 499), 8, GenerateHumanFistName(rand), GenerateHumanLastName(rand)));
            }

            var sortedWorkers = from worker in workers
                                orderby worker.MoneyPerHour(worker.WeekSalary, worker.WorkHoursPerDay)
                                descending
                                select worker;
            foreach (var w in sortedWorkers)
            {
                Console.WriteLine(w.ToString() + " => money per hour: " + w.MoneyPerHour(w.WeekSalary, w.WorkHoursPerDay));
            }
            //humans
            Console.WriteLine("\nMerged humans:");
            Console.WriteLine("---------------");
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            var sortHumans = humans.OrderBy(h => h.FirtsName).ThenBy(h => h.LastName);
            foreach (var h in sortHumans)
            {
                Console.WriteLine(h.ToString());
            }
        }
          
        public static string GenerateHumanFistName(Random rand)
        {
            string[] values = new string[] { "Milen", "Peter", "Georgi", "Vasil", "Dimitar", "Todor", "Valdimir", "Mario", "Boiko", "Ivo" };
            string firstname = values[rand.Next(1, 10)];
            return firstname;
        }

        public static string GenerateHumanLastName(Random rand)
        {
            string[] values = new string[] { "Petrov", "Georgiev", "Dimitrov", "Peshev", "Vasilev", "Borisov", "Popov", "Todorov", "Berbatov", "Tanev" };
            string lastname = values[rand.Next(1, 10)];
            return lastname;
        }

        public static string GenerateFacultyNumber(Random randIdx)
        {
            string fn = "";
            List<dynamic> all = new List<dynamic>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Random rand = new Random();
            int n = rand.Next(5, 10);
            for (int i = 1; i <= n; i++)
            {
                int idx = randIdx.Next(0, all.Count);
                fn += all[idx];
            }

            return fn;
        }
    }
}
