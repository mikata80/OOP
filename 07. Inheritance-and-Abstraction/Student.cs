using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student : Person
    {
        public SchoolClass schoolClass;
        //Details studentDetail;

        public Student(string name, string details, SchoolClass _class)
            : base(name,details)
        {
            this.Name = name;
            this.schoolClass = _class;
            this.Detail = details;
        }

        public override string ToString()
        {
            return String.Format("Student name: {0}\nDetails: {2} {1}\n",Name,schoolClass,Detail);
        }

    }
}
