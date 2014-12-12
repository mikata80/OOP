using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class AdjustableChair : Chair, IAdjustableChair 
    {
        public AdjustableChair(int legs, string model, decimal price, decimal height, MaterialType matType)
            : base(legs,model, price, height, matType)
        {

        }
        #region IAdjustableChair Members

        public void SetHeight(decimal height)
        {
            height = this.Height;
        }

        #endregion

        public override string ToString()
        {
            return String.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}\n", 
                this.GetType().Name, 
                this.Model, 
                this.Material, 
                this.Price, 
                this.Height, 
                this.NumberOfLegs);
        } 

        
    }
}
