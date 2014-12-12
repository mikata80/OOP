using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class Chair :Furnuture, IChair
    {
        private int legs;
        #region IChair Members

        public Chair(int legs,string model, decimal price, decimal height, MaterialType matType)
            : base(model, price, height, matType)
        {
            this.NumberOfLegs = legs;
        }

        public int NumberOfLegs
        {
            get 
            {
                return this.legs;
            }

            set 
            {
                this.legs = value;
            } 
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
