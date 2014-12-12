using Estates.Engine;
using Estates.Interfaces;
using System;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new EstateEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type)
            {
                case EstateType.Apartment:
                    Estate apartamet = new Apartment();
                    return apartamet;
                case EstateType.Office:
                    Estate office = new Office();
                    return office;
                case EstateType.House:
                    Estate house = new House();
                    return house;
                case EstateType.Garage:
                    Estate garage = new Garage();
                    return garage;
            }

            throw new NotImplementedException();
        }//DONE

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type)
            {
                case OfferType.Sale:
                    Sale sale = new Sale();
                    return sale;
                case OfferType.Rent:
                    Rent rent = new Rent();
                    return rent;
                default:
                    break;
            }
            throw new NotImplementedException();
        }
    }
}
