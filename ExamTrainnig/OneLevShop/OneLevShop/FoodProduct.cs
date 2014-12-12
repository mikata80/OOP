using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLevShop
{
    class FoodProduct : Product,IExpirable

    {
        private const  string pattern = "dd-mm-yyyy";
        private string expireDate;

        public FoodProduct(string name, double price, double qty, AgeRestriction ageRestriction, string expDate = null)
            :base(name,price,qty,ageRestriction)
        {
            this.ExpireDate = expDate;   
        }

        public string ExpireDate 
        {
            get 
            {
                return this.expireDate;
            }
            set 
            {
                
                if (value != null)
                {
                    try
                    {
                        DateTime parsedDate = DateTime.ParseExact(value, pattern, CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {

                        throw new ArgumentOutOfRangeException("Invalid date format dd-mm-yyyy!");
                    }    
                }
                
                this.expireDate = value;
            
            }
        }

        public override double getPrice()
        {
            double resPrice = this.Price;
            DateTime now = DateTime.Now;
            DateTime exp = this.getExpirationDate();
            TimeSpan res = exp - now;
            if (res.Days >= 15)
            {
                resPrice *= 0.7;
            }

            return resPrice;
        }

        #region IExpirable Members

        public DateTime getExpirationDate()
        {
            DateTime resDate = DateTime.ParseExact(expireDate,pattern, CultureInfo.InvariantCulture);
            return resDate;
        }

        #endregion
    }
}
