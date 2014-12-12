namespace RestaurantManager.Engine.Factories
{
    using System;
    using RestaurantManager.Interfaces;
    using RestaurantManager.Interfaces.Engine;
    using RestaurantManager.Data;

    public class RecipeFactory : IRecipeFactory
    {
        public IDrink CreateDrink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
        {
            // TODO: Implement this method
            Drink drink = new Drink();
            drink.Name = name;
            drink.Price = price;
            drink.Calories = calories;
            drink.QuantityPerServing = quantityPerServing;
            drink.TimeToPrepare = timeToPrepare;
            drink.IsCarbonated = isCarbonated;
            return drink;
        }

        public ISalad CreateSalad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
        {
            // TODO: Implement this method
            Salad salad = new Salad();
            salad.Name = name;
            salad.Price = price;
            salad.QuantityPerServing = quantityPerServing;
            salad.TimeToPrepare = timeToPrepare;
            salad.ContainsPasta = containsPasta;
            return salad;
        }
        
        public IMainCourse CreateMainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
        {
            // TODO: Implement this method
            Models.MainCourseType t;
            t = (Models.MainCourseType)Enum.Parse(typeof(Models.MainCourseType), type);
            MainCourse mainCourse = new MainCourse();
            mainCourse.Name = name;
            mainCourse.Price = price;
            mainCourse.Calories = calories;
            mainCourse.QuantityPerServing = quantityPerServing;
            mainCourse.TimeToPrepare = timeToPrepare;
            mainCourse.IsVegan = isVegan;
            mainCourse.Type = t;
            return mainCourse;
        }

        public IDessert CreateDessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
        {
            // TODO: Implement this method
            Dessert dessert = new Dessert();
            dessert.Name = name;
            dessert.Price = price;
            dessert.Calories = calories;
            dessert.QuantityPerServing = quantityPerServing;
            dessert.TimeToPrepare = timeToPrepare;
            dessert.IsVegan = isVegan;
            return dessert;
        }
    }
}
