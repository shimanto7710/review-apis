using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface ReviewedRestaurantInterface
    {
        public ReviewedRestaurantModel GetById(int id);

        List<ReviewedRestaurantModel> GetAll();

        ReviewedRestaurantModel Create(ReviewedRestaurantModel ReviewedRestaurantModel);

        bool Delete(int id);

        ReviewedRestaurantModel Update(int id, ReviewedRestaurantModel ReviewedRestaurantModel);
    }
}
