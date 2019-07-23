using OdeToFood.Core;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetRestaurantsById(int id);

        Restaurant Update(Restaurant restaurant);

        Restaurant Create(Restaurant restaurant);

        Restaurant Delete(int id);

        int GetCountOfRestaurants();

        int Commit();
    }
}
