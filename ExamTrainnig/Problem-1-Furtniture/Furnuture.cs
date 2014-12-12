using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public abstract class Furnuture : IFurniture
    {


        private string model;
        private decimal price;
        private decimal height;
        public MaterialType materialType;

        public Furnuture(string model, decimal price, decimal height, MaterialType materialType)
        {
            this.Model = model;
            this.Price = price;
            this.Height = height;
            this.materialType = materialType;
        }

        #region IFurniture Members

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value.Length < 3 || value == null || value == "")
                {
                    throw new ArgumentOutOfRangeException("Model name must be gather than 3 letters!");
                }
                this.model = value;
            }
        }//done

        public string Material
        {
            get
            {
                return this.materialType.ToString();
            }
        }//done

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
                    throw new ArgumentOutOfRangeException("Price cannot be 0.00 or < 0.00!");
                }

                this.price = value;
            }
        }//done

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
                    throw new ArgumentOutOfRangeException();
                }

                this.height = value;
            }
        }//done

        #endregion

        
     
    }
}
