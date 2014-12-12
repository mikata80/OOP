using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public class Garage:Estate,IGarage
    {
        private int width;
        private int height;
        #region IGarage Members

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <0 || value >500)
                {
                    throw new ArgumentOutOfRangeException("The garage width maust by >=0 and < 500!");
                }

                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0 || value > 500)
                {
                    throw new ArgumentOutOfRangeException("The garage height maust by >=0 and < 500!");
                }

                this.height = value;
            }
        }

        #endregion
        public override string ToString()
        {
            return String.Format("{0}, Width: {1}, Height: {2}",
            base.ToString(),
            this.width,
            this.height);
        }
    }
}
