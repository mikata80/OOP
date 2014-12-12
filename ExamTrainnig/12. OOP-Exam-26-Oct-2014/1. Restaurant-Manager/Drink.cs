using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Data
{
    public class Drink : Meal, IDrink
    {
        private bool isCarbonated;
        private int calories;
        private int timeToOperate;
        private Models.MetricUnit dinkUnit = Models.MetricUnit.Milliliters;

        public int Calories
        {
            get
            {
                return this.calories;
            }
            set
            {
                if (value <=0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Calories in drink must be 0 to 100!");
                }
                this.calories = value;
            }
        }

        public int TimeToOperate
        {
            get
            {
                return this.timeToOperate;
            }
            set
            {
                if (value <= 0 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Time to operate in drink must be 0 to 20 minutes!");
                }
                this.timeToOperate = value;
            }
        }

        public Models.MetricUnit Unit 
        {
            get
            {
                return this.dinkUnit;
            }
            set 
            {
                
                this.dinkUnit = value;
            } 

        }
        #region IDrink Members

        public bool IsCarbonated
        {
            get
            {
                return this.isCarbonated;
            }
            set
            {
                this.isCarbonated = value;
            }
        }

        #endregion

        public override string ToString()
        {
            /*
                ==  <name> == $<price>
                Per serving: <quantity> <unit>, <calories> kcal
                Ready in <time_to_prepare> minutes
                Carbonated: <yes / no>
             */
            string unitNew = "ml";
            
            return String.Format("==  {0} == ${1}\nPer serving: {2} {3}, {4} kcal\nReady in {5} minutes\nCarbonated: {6}",
                this.Name,
                this.Price,
                this.QuantityPerServing,
                unitNew,
                this.Calories,
                this.TimeToPrepare,
                (this.IsCarbonated) ? "yes" : "no");
        }
    }
}
