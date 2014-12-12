using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    public class Reservation
    {
        
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Guest Guest { get; set; }

        public Reservation(DateTime sDate, DateTime eDate, Guest guest)
        {
            this.StartDate = sDate;
            this.EndDate = eDate;
            this.Guest = guest;
        }

        public Reservation()
        {
            // TODO: Complete member initialization
        }
    }
}
