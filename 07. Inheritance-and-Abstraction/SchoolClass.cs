using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class SchoolClass : Details
    {
        private int classNumber;
        private string classLetter;
        public List<Teacher> teachers;

        public SchoolClass(int classNumber, string classLetter, List<Teacher> teachers = null, string detail = null)
            : base(detail)
        {
            this.ClassNumber = classNumber;
            this.ClassLetter = classLetter;
            this.teachers = teachers;
            this.Detail = detail;
        }
        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentNullException("Class number must be > 0 !");
                }
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
            string res = classNumber + "" + classLetter;
            return res;
        }
        public override string ToString()
        {
            string tech = "";
            string disc = "";

            foreach (var t in teachers)
            {
                tech += t.Name + ", " + t.Detail + "\n\t\tDisciplines: ";
                foreach (var d in t.disciplines)
                {
                    disc += d.DisciplineName + ", ";
                }
                tech += disc + "\n\t";
                disc = "";
            }

            return String.Format("\nClass: {0}{1}\nClass detail:{3} \nTeachers:\n\t{2}", ClassNumber, ClassLetter, tech, Detail);
        }
    }
}
