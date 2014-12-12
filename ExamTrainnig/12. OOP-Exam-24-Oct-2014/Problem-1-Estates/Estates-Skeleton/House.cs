using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public class House : Estate, IHouse
    {
        private int floors;
        #region IHouse Members

        public int Floors
        {
            get
            {
                return this.floors;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentNullException("Floors must be >=0 and <10!");
                }

                this.floors = value;
            }
        }

        #endregion
        public override string ToString()
        {
            return String.Format("{0}, Floors: {1}",
            base.ToString(),
            this.floors);
        }
    }


}
