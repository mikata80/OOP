using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    public class Guest
    {
        public string  FirstName { get; set; }

        public string LastName { get; set; }

        public string Egn { get; set; }

        public Guest(string fname, string lname, string egn)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Egn = egn;
        }

        public override string ToString()
        {
            return String.Format("Guest: {0} {1}, EGN: {2}",FirstName,LastName,Egn);
        }
    }
}
