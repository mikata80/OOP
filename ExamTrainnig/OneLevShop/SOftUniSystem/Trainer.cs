using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOftUniSystem
{
    public abstract class Trainer :Person
    {
        public List<string> CourseName { get; set; }

        public Trainer(List<string> courseName)
            :base()
        {
            this.CourseName = courseName;
        }

        public Trainer()
        {
            // TODO: Complete member initialization
        }

        public void CreateCourse() 
        {
            //Console.WriteLine("Course {0} has been created",this.CourseName.ForEach(s=> s);
            this.CourseName.ForEach(
                s => 
                    Console.WriteLine("Course {0} has been created",s));

        }

        public override string ToString()
        {
            string coursesPrn = "";
            foreach (var c in CourseName)
            {
                coursesPrn += c + ", ";
            }

            coursesPrn = coursesPrn.Remove(coursesPrn.Length - 2,2);

            return String.Format("{0}: {1} {2}, age: {3}, Courses: {4};",
                this.GetType().Name,
                this.FirstName,
                this.LastName,
                this.Age,
                coursesPrn);
        }
    }
}
