using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class SchoolExample
    {
        private static Student AddStudent(string name, string details, SchoolClass _class, Discipline[] disciplines)
        {

            var student = new Student(name, details, _class);//new Student(name, "asdasdasd", disciplines);

            foreach (var d in disciplines)
            {
                d.Students.Add(student);
            }

            return student;
        }

        static void Main()
        {
            //Disciplines
            Discipline math = new Discipline("Math", 150, new List<Student> { }, "Math and Informatics");
            Discipline history = new Discipline("History", 200, new List<Student> { },"History of Bulgarisa and world history");
            Discipline html = new Discipline("HTML", 50, new List<Student> { },"HTML5");
            Discipline cSharp = new Discipline("C#", 250, new List<Student> { },"OOP C#");
            Discipline java = new Discipline("JAVA", 250, new List<Student> { }, "OOP Java");
            Discipline geography = new Discipline("Geography", 200, new List<Student> { }, "Geography");
            List<Discipline> allDisciplines = new List<Discipline>() { math, history, geography, html };
            // teachers
            Teacher mrIvanov = new Teacher("Ivan Ivanov", " Male, 59 years old from Plovdiv, Bulgaria.", new List<Discipline> { math, history });
            Teacher mrPetrov = new Teacher("Peter Petrov", "Male, 35 years old from Varna, Bulgaria.", new List<Discipline> { html });
            Teacher mrGeorgiev = new Teacher("Todor Georgiev", "Male, 45 years old from Plovdiv, Bulgaria.", new List<Discipline> { cSharp, java });
            Teacher msPesheva = new Teacher("Vaia Pesheva", "Female, 42 years old from Sofia, Bulgaria.", new List<Discipline> { geography });
            //// Schooll classes
            SchoolClass _12A = new SchoolClass(12, "A", new List<Teacher> { mrIvanov, mrPetrov, msPesheva, mrGeorgiev },"Programers");
            SchoolClass _11A = new SchoolClass(11, "A", new List<Teacher> { mrPetrov, msPesheva, mrPetrov, mrGeorgiev }, "Informatics");
            //Students
            Student mPetrov = AddStudent("Milen Petrov", "Male, 17 years old from Dupnica, Bulgaria ", _12A, new Discipline[] { math, history, html });
            Student tDimitrova = AddStudent("Mariq Dimitrova", "Female, 16 years old from Burgas, Bulgaria ", _11A, new Discipline[] { math, html, cSharp, java });
            Student pPetrov = AddStudent("Peter Petrov", "Male, 18 years old from Vratza, Bulgaria ", _12A, new Discipline[] { math, history, html, cSharp, java });
            Student tTodorova = AddStudent("Petq Dimitrova", "Female, 16 years old from Burgas, Bulgaria ", _11A, new Discipline[] { math, html, cSharp, java });
            List<Student> allStudents = new List<Student>() { mPetrov, tDimitrova, pPetrov, tTodorova };
            foreach (var s in allStudents)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();
            foreach (var d in allDisciplines)
            {
                Console.WriteLine(d.ToString());
                Console.WriteLine(d.getDisciplineStudents(d));
            };
        }
    }
}
