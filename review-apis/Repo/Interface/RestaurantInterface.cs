using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface RestaurantInterface
    {
        public RestaurantModel GetById(int id);

        List<RestaurantModel> GetAll();

        RestaurantModel Create(RestaurantModel RestaurantModel);

        bool Delete(int id);

        RestaurantModel Update(int id, RestaurantModel RestaurantModel);
    }
}
