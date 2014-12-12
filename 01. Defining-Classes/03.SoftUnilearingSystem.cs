using System;
using System.Collections.Generic;


namespace Definig_Classes
{
    class softUniLS
    {
        static void Main()
        {

            Person petrov = new Person("Milen", "Petrov", 34);
            Person pet = new Person("Milen1", "Petrov1", 34);
            //go p = new go();
            
            
        }
    }
    class Person
    {
        protected string firstName;
        private string lastName;
        private int age;


        public Person(string firstName = null, string lastName = null, int age =0)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //public string FirstName
        //{
        //    get
        //    {
        //        return this.firstName;
        //    }
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            Console.WriteLine("asdasd");
        //        }
        //        else
        //        {
        //            this.firstName = value;
        //        }


        //    }
        //}
        //public string LastName
        //{
        //    get
        //    {
        //        return this.lastName;
        //    }
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            Console.WriteLine("asdasd");
        //        }
        //        else
        //        {
        //            this.lastName = value;
        //        }


        //    }
        //}
        //public int Age { get; set; }
    }

    class go : Person {

        public int StockOptions { get; set; }
        public override string ToString()
        {
            return String.Format("First Name: {0}\n{1}", StockOptions, firstName);
        }
    }



    

}

// Trainers
//class Trainer : Person
//{
//    public Trainer() { 
//    }
//    public int MyProperty { get; set; }
//    /private string courseName;

//    public Trainer(string firstName, string lastName, int age, string courseName)
//        : base(firstName, lastName, age)
//    {
//        this.courseName = courseName;
//    }

//    public void CreateCourse()
//    {
//        Console.WriteLine(String.Format("Added course name : {0}", courseName)); ;
//    }

//    public override string ToString()
//    {
//        return String.Format("Course Name: {0}\n ", MyProperty);
//    }
//}

//class SeniorTrainer : Trainer
//{
//    public SeniorTrainer(string firstName, string lastName, int age, string courseName)
//        : base(firstName, lastName, age, courseName)
//    {

//    }

//    public string courseName
//    {
//        get
//        {
//            return this.courseName;
//        }
//    }
//    public void DeleteCourse()
//    {
//        Console.WriteLine(String.Format("Deleted course name : {0}", courseName)); ;

//    }
//}
//class JuniorTrainer : Trainer
//{

//}


////Students
//class Student : Person
//{

//}

//class GraduateStudent : Student
//{

//}
//class CurrentStudent : Student
//{

//}

//class OnlineStudent : CurrentStudent
//{

//}

//class OnSideStudent : CurrentStudent
//{

//}
//class DropoutStudent : Student
//{

//}

