using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOftUniSystem
{
    class OnsiteStudent :CurrentStudent
    {
        public int NumberOfvisits { get; set; }

        public OnsiteStudent(int numberOfVisits)
            :base()
        {
            this.NumberOfvisits = numberOfVisits;
        }

        public OnsiteStudent()
        {
            // TODO: Complete member initialization
        }
    }
}
