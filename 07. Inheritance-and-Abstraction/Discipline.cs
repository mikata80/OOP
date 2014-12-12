using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Discipline :Details
    {
        private string disciplineName;
        private int lecturesCount;
        private List<Student> students;

        public Discipline(string disciplineName, int lecturesCount, List<Student> students,string detail)
            :base(detail)
        {
            this.DisciplineName = disciplineName;
            this.LecturesCount = lecturesCount;
            this.Students = students;
            this.Detail = detail;

        }
        public string DisciplineName
        {
            get
            {
                return this.disciplineName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Discipline name can be empty");
                }
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
        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
        public string getDisciplineStudents(Discipline discipline)
        {
            string result = "";
            foreach (var s in discipline.students)
            {
                result += s.Name + ", ";
            }

            return String.Format("{0}:\n\t{1}", discipline.disciplineName, result);
        }
        public override string ToString()
        {
            return String.Format("\nDietails: "+ Detail + " " + lecturesCount + " hours");
        }
    }
}
