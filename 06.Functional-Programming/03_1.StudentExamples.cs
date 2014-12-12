using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    class StudentExamples
    {
        public static void Main()
        {

            Student asen = new Student("Asen", "Mitov", 30, 56811140, "02/9987456", "a.mit@gmail.bg", new List<int> { 4, 3, 4, 5, 4, 2 }, 2, "Beta");
            Student milen = new Student("Milen", "Petrov", 18, 98989400, "+359288898998", "m.perov@gmail.bg", new List<int> { 4, 3, 4, 5, 3, 2 }, 2, "Beta");
            Student pesho = new Student("Peter", "Georgiev", 23, 78781141, "089554541", "pesho@abv.bg", new List<int> { 3, 3, 3, 6, 2, 2 }, 2, "Beta");
            Student gosho = new Student("Georgi", "Dimtrov", 104,11114114, "08888888", "gd@bkp.sssr", new List<int> { 6, 6, 6, 6, 6, 6 }, 1, "Alfa");
            Student tosho = new Student("Todor", "Vasilev", 21,157814132, "+359 2891289", "tosho@abv.bg", new List<int> { 4, 3, 5, 6, 2, 4 }, 1, "Alfa");

            StudentSpecialty asenSpec= new StudentSpecialty("Web Developer",asen.FacultyNumber);
            StudentSpecialty milenSpec = new StudentSpecialty("Web Developer", milen.FacultyNumber);
            StudentSpecialty peshoSpec = new StudentSpecialty("PHP Developer", pesho.FacultyNumber);
            StudentSpecialty goshoSpec = new StudentSpecialty("PHP Developer", gosho.FacultyNumber);
            StudentSpecialty toshoSpec = new StudentSpecialty("QA Engineer", tosho.FacultyNumber);


            List<Student> students = new List<Student>() { asen, milen, pesho, gosho, tosho };
            List<StudentSpecialty> specialities = new List<StudentSpecialty>(){asenSpec, milenSpec,peshoSpec,goshoSpec,toshoSpec};

            //foreach (var s in students)
            //{
            //    Console.WriteLine(s.FirstName + " " + s.LastName + ", Age: " + s.Age + ", Group:" + s.GroupNumber);
            //}

            
            ////Problem 4.	Students by Group //
            //Console.WriteLine();
            Console.WriteLine("PROBLEM 4.STUDENTS BY GROUP");
            var studentsByGroup = from student in students
                                  where student.GroupNumber == 2
                                  orderby student.FirstName
                                  select student;
            foreach (var s in studentsByGroup)
            {
                Console.WriteLine(s.FirstName + " " + s.GroupNumber);
            }

            ////Problem 5.	Students by First and Last Name //
            Console.WriteLine();
            Console.WriteLine("PROBLEM 5.STUDENTS BY FIRST AND LAST NAME");
            var studentsFirstLastname = from student in students
                                        where student.FirstCharInInt(student.FirstName) < student.FirstCharInInt(student.LastName)
                                        select student;
            foreach (var s in studentsFirstLastname)
            {
                Console.WriteLine("{0}({1}) {2}({3})",
                    s.FirstName,
                    s.FirstCharInInt(s.FirstName),
                    s.LastName,
                    s.FirstCharInInt(s.LastName));
            }

            ////Problem 6.	Students by Age //
            Console.WriteLine();
            Console.WriteLine("PROBLEM 6.STUDENTS BY AGE");
            var studentsByAge = from student in students
                                where student.Age >= 18 && student.Age <= 24
                                orderby student.Age, student.FirstName
                                select student;
            foreach (var s in studentsByAge)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.Age);
            }

            ////Problem 7.	Sort Students //
            Console.WriteLine();
            Console.WriteLine("PROBLEM 7.SORT STUDENTS");
            var studentsSortExtention = students.OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName);
            foreach (var s in studentsSortExtention)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName );
            }

            ////Problem 8.	Filter Students by Email Domain //
            Console.WriteLine();
            Console.WriteLine("PROBLEM 8.FILTER STUDENTS BY EMAIL DOMAIN");
            var studentsEmailDomain = from student in students
                                      where student.Email.Contains("@abv.bg")
                                      select student;
            foreach (var s in studentsEmailDomain)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.Email);
            }

            //// Problem 9.	Filter Students by Phone //
            Console.WriteLine();
            Console.WriteLine("PROBLEM 9.FILTER STUDENTS BY PHONE");
            var studentsFiletrByPnone = from student in students
                                        where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
                                        select student;
            foreach (var s in studentsFiletrByPnone)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.Phone);
            }

            //// Problem 10.	Excellent Students //
            Console.WriteLine();
            Console.WriteLine("PROBLEM 10.EXCELLENT STUDENTS");
            var studentExelentMark = from student in students
                                     where student.Marks.Contains(6)
                                     select student;
            foreach (var s in studentExelentMark)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.GetStudentMarks());
            }

            //// Problem 11.	Weak Students //
            Console.WriteLine();
            Console.WriteLine("PROBLEM 11.WEAK STUDENTS");
            var weakStudents = students.Where(s => s.Marks.Where(m => m == 2).Count() == 2);
            foreach (var s in weakStudents)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.GetStudentMarks());
            }

            //// Problem 12.Students Enrolled in 2014 //
            Console.WriteLine();
            Console.WriteLine("PROBLEM 12.STUDENTS ENROLLED IN 2014");
            var students2014 = from student in students
                               where student.FacultyNumber.ToString().Substring(5, 1) == "1" && student.FacultyNumber.ToString().Substring(6, 1) == "4"
                               select student;
            foreach (var s in students2014)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.FacultyNumber);
            }

            //// Problem 13.* Students by Groups //
            Console.WriteLine();
            Console.WriteLine("PROBLEM 13.* STUDENTS BY GROUPS");
            var studentsGroupName = from student in students
                                    orderby student.GroupName
                                    group student by student.GroupName into groupName
                                    select new { GroupName = groupName.Key };
            foreach (var s in studentsGroupName)
            {
                Console.WriteLine("Group: "+ s.GroupName+ ":");
                var stu = students.OrderBy(n => n.FirstName).ThenBy(ln => ln.LastName);
                foreach (var ss in stu.Where(g => g.GroupName == s.GroupName))
                {
                    Console.WriteLine(ss.FirstName + " "+ ss.LastName);
                }

                Console.WriteLine();
            }

            ////Problem 14.	* Students Joined to Specialties//
            Console.WriteLine();
            Console.WriteLine("PROBLEM 14.* STUDENTS JOINED TO SPECIALTIES");
            var studentJoinSpec = from student in students.OrderBy(sn => sn.FirstName)
                                  join spec in specialities.OrderBy(sp => sp.SpecialtyName) on student.FacultyNumber equals spec.SpecFacultyNum
                                  select new { Name = student.FirstName + " " + student.LastName, FacNum = spec.SpecFacultyNum, Specialty = spec.SpecialtyName };
            foreach (var s in studentJoinSpec)
            {
                Console.WriteLine(s.Name + " " + s.FacNum + " " +s.Specialty);
            }

        }
    }
}

