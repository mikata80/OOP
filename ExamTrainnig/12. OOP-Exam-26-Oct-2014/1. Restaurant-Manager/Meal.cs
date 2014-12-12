using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Data
{
    public abstract class Meal : IMeal
    {
        private Models.MainCourseType type;
        private bool isVegan;
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private Models.MetricUnit unit = Models.MetricUnit.Grams;
        private int timeToPrepare;

        public Meal()
        {

        }

        #region IMeal Members

        public bool IsVegan
        {
            get
            {
                return this.isVegan;
            }

            set
            {
                this.isVegan = value;
            }
        }

        public void ToggleVegan()
        {
            bool res = !this.isVegan;
            String.Format(res.ToString());
        }

        #endregion

        #region IRecipe Members

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Name cannnot be emty!");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannnot be only positive!");
                }

                this.price = value;
            }
        }

        public int Calories
        {
            get
            {
                return this.calories;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Calories cannnot be only positive!");
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get
            {
                return this.quantityPerServing;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("QuantityPerServing cannnot be only positive!");
                }

                this.quantityPerServing = value;
            }
        }

        public Models.MetricUnit Unit
        {
            get
            {
                return this.unit;
            }
            set
            {
                this.unit = value;
            }
        }

        public int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Time to prepare cannnot be only positive!");
                }

                this.timeToPrepare = value;
            }
        }


        #endregion
    }
}
