using FurnitureManufacturer.Engine.Factories;
using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class ConvertibleChair : Furniture, IConvertibleChair
    {
        #region IConvertibleChair Members

        public bool IsConverted
        {
            get { throw new NotImplementedException(); }
        }

        public void Convert()
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
