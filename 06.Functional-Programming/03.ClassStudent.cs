using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }
        public string GroupName { get; set; }

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;

        }

        public int FirstCharInInt(string str)
        {
            int result = 0;
            char[] firstArr = str.Substring(0, 1).ToCharArray();
            char firstCh = firstArr[0];
            result = (int)firstCh;
            return result;
        }

        public string GetStudentMarks()
        {
            string resMark = "(";
            foreach (var m in Marks)
            {
                resMark += m + " ";
            }
            resMark += ")";
            return resMark;
        }
    

        public override string ToString()
        {
            string resMarks = "";
            foreach (var m in Marks)
	        {
		        resMarks += m.ToString()+" ";
	        }


            return String.Format("Name: {0} {1}\n"+
                "Age: {2}\n"+
                "FacultyNumber: {3}\n"+
                "Phone: {4}\n"+
                "Email: {5}\n"+
                "Marks: {6}\n"+
                "GroupNumber: {7}\n", 
                FirstName, 
                LastName, 
                Age, 
                FacultyNumber,
                Phone,
                Email,
                resMarks,
                GroupNumber);
        }

    }
}
