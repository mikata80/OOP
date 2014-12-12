using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Data
{
    public class MainCourse :Meal, IMainCourse
    {
        private Models.MainCourseType type;
        
        #region IMainCourse Members

        public Models.MainCourseType Type
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

        #endregion

        public override string ToString()
        {
            /*
             * <[VEGAN] >==  <name> == $<price>
                Per serving: <quantity> <unit>, <calories> kcal
                Ready in <time_to_prepare> minutes
                Type: <type>

             */
            string unitNew ="";
            if (this.Unit.ToString() == "Grams")
            {
                unitNew = "g";
            }
            if (this.Unit.ToString() == "Milliliters")
            {
                unitNew = "mm";
            }
            return String.Format("{0} ==  {1} == ${2}\nPer serving: {3} {4}, {5} kcal\nReady in {6} minutes\nType: {7}",
                (this.IsVegan) ? "[VEGAN]" :"[NO VEGAN]",
                this.Name,
                this.Price,
                this.QuantityPerServing,
                unitNew,
                this.Calories,
                this.TimeToPrepare,
                this.Type);
        }
    }
}
