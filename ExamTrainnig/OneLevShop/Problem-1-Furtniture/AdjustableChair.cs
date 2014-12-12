using FurnitureManufacturer.Engine.Factories;
using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class AdjustableChair : Furniture, IAdjustableChair
    {
        #region IAdjustableChair Members

        public void SetHeight(decimal height)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IChair Members

        public int NumberOfLegs
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
