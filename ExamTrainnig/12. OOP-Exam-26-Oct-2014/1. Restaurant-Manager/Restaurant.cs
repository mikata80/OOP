using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Data
{
    public class Restaurant : IRestaurant
    {
        private string name;
        private string loacation;
        private IList<IRecipe> recipes = new List<IRecipe>();

        public Restaurant()
        {

        }

        #region IRestaurant Members

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
                    throw new ArgumentNullException("name cannnot be emty!");
                }

                this.name = value;
            }
        }

        public string Location
        {
            get
            {
                return this.loacation;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Loacation cannnot be emty!");
                }

                this.loacation = value;
            }
        }

        public IList<IRecipe> Recipes
        {
            get
            {
                return this.recipes;
            }
            set
            {
                this.recipes = value;
            }
        }

        public void AddRecipe(IRecipe recipe)
        {
            recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            recipes.Remove(recipe);
        }

        public string PrintMenu()
        {


            string res = String.Format("**** {0} - {1} *****",
                this.name,
                this.loacation);

            var drinks = this.recipes.Where(r => r.GetType().Name == "Drink");
            var salads = this.recipes.Where(r => r.GetType().Name == "Salad");
            var mainCourses = this.recipes.Where(r => r.GetType().Name == "MainCourse");
            var desserts = this.recipes.Where(r => r.GetType().Name == "Dessert");

            if (this.recipes.Count == 0)
            {
                res = "No recipes... yet";
                return res;
            }

            if (drinks.Count() != 0)
            {
                 res += "\n~~~~~ DRINKS ~~~~~\n";
                 foreach (var drink in drinks)
                {
                    res += drink.ToString();
                }
            }

            if (salads.Count() != 0)
            {
                res += "\n~~~~~ SALADS ~~~~~\n";
                foreach (var salad in salads)
                {
                    res += salad.ToString();
                }
            }

            if (mainCourses.Count() != 0)
            {
                res += "\n~~~~~ MAIN COURSES ~~~~~\n";
                foreach (var mainCourse in mainCourses)
                {
                    res += mainCourse.ToString();
                }
            }

            if (desserts.Count() != 0)
            {
                res += "\n~~~~~ DESSERTS ~~~~~\n";
                foreach (var dessert in desserts)
                {
                    res += dessert.ToString();
                }
                
            }
            
            return String.Format(res);
        }

        #endregion

    }
}
