using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOftUniSystem
{
    public class CurrentStudent :Student
    {
        public List<string> CurrentCourse { get; set; }

        public CurrentStudent(List<string> currentCourse)
            :base()
        {
            this.CurrentCourse = currentCourse;
        }

        public CurrentStudent()
        {
            // TODO: Complete member initialization
        }
    }
}
