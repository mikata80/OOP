namespace RestaurantManager.Engine.Factories
{
    using System;
    using RestaurantManager.Interfaces.Engine;
    using RestaurantManager.Data;

    public class RestaurantFactory : IRestaurantFactory
    {
        public Interfaces.IRestaurant CreateRestaurant(string name, string location)
        {
            // TODO: Implement this method
            Restaurant restaurant = new Restaurant();
            restaurant.Name = name;
            restaurant.Location = location;
            return restaurant;

        }
    }
}
