using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOftUniSystem
{
    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer()
            :base()
        {

        }

        public void DeleteCourse(string courseName)
        {
            base.CourseName.Remove(courseName);
        }

               
    }
}
