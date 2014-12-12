using RestaurantManager.Data;
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Engine.Factories
{
    public class Dessert : Meal, IDessert
    {
        private bool withSugar;


        #region IDessert Members

        public bool WithSugar
        {
            get
            {
                return this.withSugar;
            }
            set
            {
                this.withSugar = value;
            }
        }

        public void ToggleSugar()
        {
            bool res = !this.withSugar;
            String.Format(res.ToString());
        }

        #endregion
        public override string ToString()
        {
            /*
                <[NO SUGAR] ><[VEGAN] >==  <name> == $<price>
                Per serving: <quantity> <unit>, <calories> kcal
                Ready in <time_to_prepare> minutes

             */
            return String.Format("{0} {1} ==  {2} == ${3}\nPer serving: {4} {5}, {6} kcal\nReady in {7} minutes",
                (this.IsVegan) ? "[VEGAN]" :"[NO VEGAN]",
                (!this.withSugar)? "[NO SUGAR]":"[SUGAR]",
                this.Name,
                this.Price,
                this.QuantityPerServing,
                this.Unit,
                this.Calories,
                this.TimeToPrepare);
        }
    }
}
