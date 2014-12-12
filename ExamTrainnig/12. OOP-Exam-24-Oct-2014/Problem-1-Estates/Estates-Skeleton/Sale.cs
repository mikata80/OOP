using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public class Sale : ISaleOffer
    {
        private OfferType offerType = OfferType.Sale;
        private IEstate estate;
        private decimal price;

        public Sale()
        {

        }
        public Sale(OfferType offerType, IEstate estate, decimal price)
        {
            this.Type = offerType;
            this.Estate = estate;
            this.Price = price;
        }

        #region ISaleOffer Members

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        #endregion

        #region IOffer Members

        public OfferType Type
        {
            get
            {
                return this.offerType;
            }
            set
            {
                this.offerType = value;
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
                this.price);
        }

        public decimal GetPrice() 
        {
            return this.Price;
        }
    }
}
