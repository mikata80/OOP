using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Engine.Factories
{
    class Chair : Furniture,IChair
    {
        #region IChair Members

        public int NumberOfLegs
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
