using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public class Rent :IRentOffer
    {
        private decimal pricePerMonth;
        private OfferType type = OfferType.Rent;
        private IEstate estate;

        public Rent()
        {

        }
        public Rent(decimal pricePerMonth, OfferType type, IEstate estate)
        {
            this.PricePerMonth = pricePerMonth;
            this.Type = type;
            this.Estate = estate;
        }

        #region IRentOffer Members

        public decimal PricePerMonth
        {
            get
            {
                return this.pricePerMonth;
            }
            set
            {
                this.pricePerMonth = value;
            }
        }

        #endregion

        #region IOffer Members

        public OfferType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public IEstate Estate
        {
            get
            {
                return this.estate;
            }
            set
            {
                this.estate = value;
            }
        }

        #endregion
        public override string ToString()
        {
            return String.Format("{0}: Estate = {1}, Location = {2}, Price = {3}",
                this.GetType().Name,
                this.Estate.Name,
                this.Estate.Location,
                this.PricePerMonth);
        }

        public decimal GetPrice()
        {
            return this.PricePerMonth;
        }
    }
}
