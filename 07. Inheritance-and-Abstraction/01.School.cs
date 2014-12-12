using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Abstraction
{
    class runSchoolExalmple
    {
        private static Student AddStudent(string name, SchoolClass schoolclass)//, Discipline[] disciplines)
        {
            var student = new Student(name, schoolclass);

            //foreach(var d in disciplines)
            //{
            //    d.students.Add(student);
            //}

            return student;
        }

        static void Main()
        {
            Discipline math = new Discipline("Math", 150);
            Discipline history = new Discipline("History", 200);
            Discipline html = new Discipline("HTML", 50);
            Discipline geography = new Discipline("Geography", 200);

            Teacher mrIvanov = new Teacher("Ivan Ivanoiv", new List<Discipline> { math, history});
            Teacher mrPetrov = new Teacher("Peter Petrov", new List<Discipline> { math, history, html});


            SchoolClass _1A = new SchoolClass(1, "A", new List<Teacher> {mrIvanov,mrIvanov});
            
            Student milen = AddStudent("Milen", _1A);//, new Discipline[] { math, geography });


            Console.WriteLine();
            //SchoolClass
            //Student milen = new Student("Milen Petrov", 12);
            //Student gosho = new Student("Georgi Ivanow", 5);
            //Student pesho = new Student("Peter Nikov", 7);
            //Student tosho = new Student("Todor Dimitriv", 5);
            //Student svet = new Student("Svet Georgiev", 7);
            //List<Student> students = new List<Student>() { milen, gosho, tosho, pesho, svet };
            //var classess = new Classess(students);
            //for (int i = 0; i < classess.; i++)
            //{
                
            //}
            
            
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.StudentClassNumber);
            //}

            
            //Classess cl = new Classess(12,List<Stu>;


            //Console.WriteLine(det.Detail);



        }
    }

     
    // base clasess

    class Details
    {
        private string det;

        public string Detail
        {
            get
            {
                return det;
            }
            set
            {
                this.det = value;
            }
        }

        public Details(string detail)
        {
            this.Detail = detail;
        }
    }

    class Person :Details
    {
        private string personName;

        public string Name
        {
            get
            {
                return this.personName;
            }
            set
            {
                this.personName = value;
            }
        }
        public Person(string name, string details)
            :base(details)
        {
            this.Name = name;
            this.Detail = details;
        }
    }

    class SchoolClass
    {
        private int classNumber;
        private string classLetter;
        public List<Teacher> teachers;

        public SchoolClass(int classNumber, string classLetter, List<Teacher> teachers = null)
        {
            this.ClassNumber = classNumber;
            this.ClassLetter = classLetter;
            this.teachers = teachers;

        }

        public int ClassNumber
        {
            get 
            { 
                return this.classNumber;
            }
            set 
            {
                this.classNumber = value;
            }
        }

        public string ClassLetter
        {
            get
            {
                return this.classLetter;
            }
            set
            {
                this.classLetter = value;
            }
        }

        public string getFullClassName(int classNumber, string classLetter)
        {
            string res = classNumber + ""+ classLetter;
            return res;
        }

    }

    

    //// other classes //
    class Teacher : Person
    {
        private List<Discipline> disciplines;
        public Teacher(string name, List<Discipline> disciplines = null, string details)
            :base(name,details)
        {
            this.Name = name;
            this.disciplines = disciplines;
            this.Detail = details; 
        }
    }
    
    class Student : Person
    {
        public SchoolClass _class;
        
        //Details studentDetail;

        public Student(string name, SchoolClass _class)
            : base(name)
        {
            this.Name = name;
            this._class = _class;
        }

        //public override string ToString()
        //{
        //    return String.Format(Name + " " + StudentClassNumber);
        //}

    }

    class Discipline
    {
        private string disciplineName;
        private int lecturesCount;
        public List<Student> students;

        public Discipline(string disciplineName, int lecturesCount, List<Student> students = null)
        {
            this.DisciplineName = disciplineName;
            this.LecturesCount = lecturesCount;
            this.students = students;
        }

        public string DisciplineName
        {
            get
            {
                return this.disciplineName;
            }
            set
            {
                this.disciplineName = value;
            }
        }

        public int LecturesCount
        {
            get
            {
                return this.lecturesCount;
            }
            set
            {
                this.lecturesCount = value;
            }
        }
    }

}
