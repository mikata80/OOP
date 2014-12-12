using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public abstract class Offer: IOffer
    {
        private OfferType offerType;
        private IEstate estate;

        public Offer(OfferType offerType, IEstate estate)
        {
            this.Type = offerType;
            this.Estate = estate;
        }

        public Offer()
        {
            // TODO: Complete member initialization
        }

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
    }
}
