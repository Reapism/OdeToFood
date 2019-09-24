using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Italian Pizza", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "French Pizza", Cuisine = CuisineType.French },
                new Restaurant { Id = 3, Name = "Indian Pizza", Cuisine = CuisineType.Indian }
            };
        }

        public Restaurant Get(int id)
        {
            // first or default means return the first object that
            // satisfies the condition or return the default.
            // which for restaurant is null.d
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
