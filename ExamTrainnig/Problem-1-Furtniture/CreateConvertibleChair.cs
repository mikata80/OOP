using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class ConvertibleChair : Chair, IConvertibleChair
    {

        public ConvertibleChair(int legs, string model, decimal price, decimal height, MaterialType matType)
            : base(legs,model, price, height, matType)
        {

        }
        #region IConvertibleChair Members

        public bool IsConverted
        {
            get { return true; }
        }

        public void Convert()
        {
            bool res = IsConverted;
        }

        #endregion

        public override string ToString()
        {
            return String.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}\n", 
                this.GetType().Name, 
                this.Model, 
                this.Material, 
                this.Price, 
                this.Height, 
                this.NumberOfLegs, 
                this.IsConverted ? "Converted" : "Normal");
        }
    }
}
