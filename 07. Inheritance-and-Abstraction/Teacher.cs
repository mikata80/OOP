using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : Person
    {
        public List<Discipline> disciplines;
        public Teacher(string name, string details, List<Discipline> disciplines = null)
            : base(name, details)
        {
            this.Name = name;
            this.disciplines = disciplines;
            this.Detail = details;
        }
    }
}
