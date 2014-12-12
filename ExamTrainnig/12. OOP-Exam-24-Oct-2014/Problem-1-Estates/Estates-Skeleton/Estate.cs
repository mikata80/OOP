using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public abstract class Estate : IEstate
    {
        private string name;
        private EstateType estateType;
        private double area;
        private string location;
        private bool isFurnished;

        #region IEstate Members

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("The name of esatate cannot be empty!");
                }

                this.name = value;
            }
        }

        public EstateType Type
        {
            get
            {
                return this.estateType;
            }
            set
            {
                this.estateType = value;
            }
        }

        public double Area
        {
            get
            {
                return this.area;
            }
            set
            {
                if (value <0 || value>10000)
                {
                    throw new ArgumentOutOfRangeException("Area must be >0 and < 10000!");
                }

                this.area = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public bool IsFurnished
        {
            get
            {
                return this.isFurnished;
            }
            set
            {
                this.isFurnished = value;
            }
        }

        #endregion

        public override string ToString()
        {
            /*
             * Apartment: Name = aptLozenec24, Area = 150, Location = Sofia, Furnitured = Yes, Rooms: 4, Elevator: Yes
             */
            string resIsFurnitured = "No";
            if (this.isFurnished)
            {
                resIsFurnitured = "Yes";
            }

            return String.Format("{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}",
                this.GetType().Name,
                this.name,
                this.area,
                this.location,
                resIsFurnitured
                );
        }

      
    }
}
