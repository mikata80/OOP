using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Engine.Factories
{
    class Table : Furniture, ITable

    {
        #region ITable Members

        public decimal Length
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Width
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Area
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
