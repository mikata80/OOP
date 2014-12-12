using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public class Office : Estate, IOffice
    {
        private int numberOfRooms;
        private bool hasElevator;

        public Office()
        {

        }

        #region IBuildingEstate Members

        public int Rooms
        {
            get
            {
                return this.numberOfRooms;
            }
            set
            {
                if (value <0 || value > 20)
                {
                    throw new ArgumentNullException("Rooms must be >0 and <20!");
                }
                this.numberOfRooms = value;
            }
        }

        public bool HasElevator
        {
            get
            {
                return this.hasElevator;
            }
            set
            {
                this.hasElevator = value;
            }
        }

        #endregion
          public override string ToString()
        {
            /*
             * Apartment: Name = aptLozenec24, Area = 150, Location = Sofia, Furnitured = Yes, Rooms: 4, Elevator: Yes
             */
            string resElevator = "No";
            if (this.hasElevator)
            {
                resElevator = "Yes";
            }

            return String.Format("{0}, Rooms: {1}, Elevator: {2}",
                base.ToString(),
                this.numberOfRooms,
                resElevator
                );
        }
    }
}
