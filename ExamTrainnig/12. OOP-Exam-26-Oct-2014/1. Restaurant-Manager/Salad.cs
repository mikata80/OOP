using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Data
{
    public class Salad :Meal, ISalad
    {
        private bool containsPasta;

        public Salad()
        {

        }
        #region ISalad Members

        public bool ContainsPasta
        {
            get 
            {
                return this.containsPasta;
            }
            set 
            {
                this.containsPasta = value;
            }
        }

        #endregion

        public override string ToString()
        {
            /*
             <[VEGAN] >==  <name> == $<price>
            Per serving: <quantity> <unit>, <calories> kcal
            Ready in <time_to_prepare> minutes
            Contains pasta: <yes / no>
             */
            return String.Format("{0} ==  {1} == ${2}\nPer serving: {3} {4}, {5} kcal\nReady in {6}\nContains pasta: {7}",
                (this.IsVegan) ? "[VEGAN]" :"[NO VEGAN]",
                this.Name,
                this.Price,
                this.QuantityPerServing,
                this.Unit,
                this.Calories,
                this.TimeToPrepare,
                (this.ContainsPasta) ? "yes" : "no");
        }

        
    }
}
