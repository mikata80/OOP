using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FurnitureManufacturer
{
    class Company : ICompany
    {
        private string name;
        private string regNum;
        private ICollection<IFurniture> furnitures = new List<IFurniture>();

        #region ICompany Members

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null || value == "" || value.Length < 5 )
                {
                    throw new ArgumentNullException("Company name cannot be empty, null or with less than 5 symbols");
                }
                this.name = value;
            }
        }// Done

        public string RegistrationNumber
        {
            get
            {
                return this.regNum;
            }

            set
            {
                bool isNotDigit = true;

                foreach (char ch in value)
                {
                    if (!char.IsDigit(ch))
                    {
                        isNotDigit = false;
                        break;
                    }
                }

                //int n;
                //bool isNumeric = int.TryParse("123", out n);
                //This will return true if input is all numbers
                //Regex.IsMatch(input, @"^\d+$")
               
                if (value == null || 
                    value == "" || 
                    value.Length != 10 ||
                    isNotDigit == false
                   )
                {
                    throw new ArgumentNullException("Registration number must be exactly 10 symbols and must contain only digits.");
                }

              this.regNum = value;
            }
        }// Done

        public ICollection<IFurniture> Furnitures// Done
        {
            get
            { 
                return this.furnitures;
            }

            set 
            {
                this.furnitures = value;
            }

        }

        public void Add(IFurniture furniture)// Done
        {
            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)// Done
        {
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)// Done
        {
            IFurniture res = null;
            foreach (var f in this.Furnitures)
            {
                if (f.Model == model)
                {
                    res = f;
                    break;
                }
            }

            return res;
        } 

        public string Catalog()
        {
            return String.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture");
        }

        #endregion
    }
}
