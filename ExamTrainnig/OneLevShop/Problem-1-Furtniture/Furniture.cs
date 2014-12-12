using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Engine.Factories
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private string material;
        private decimal height;


        #region IFurniture Members

        public string Model
        {
            get 
            {
                return this.model;
            }

            set 
            {
                if (value == null || value == "" || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Model cannot be empty, null or with less than 3 symbols.");
                }

                this.model = value;
            }
        }//Done

        public string Material
        {
            get
            {
                return this.material;
            }

            set 
            {
                this.material = value;
            }
        }// Done

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0.00M)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less or equal to $0.00.");
                }

                this.price = value;
            }
        } //Done

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set 
            {
                if (value <= 0.00M)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less or equal to 0.00 m.");
                }
            }
        }//Done

        #endregion
    }
}
