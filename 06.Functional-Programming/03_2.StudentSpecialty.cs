using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    class StudentSpecialty
    {
        public string SpecialtyName { get; set; }
        public int SpecFacultyNum { get; set; }

        public StudentSpecialty(string specialtyName, int specFacultyNum)
        {
            this.SpecialtyName = specialtyName;
            this.SpecFacultyNum = specFacultyNum;
        }
    }
}
