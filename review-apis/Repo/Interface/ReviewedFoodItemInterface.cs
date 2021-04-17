using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface ReviewedFoodItemInterface
    {
        public ReviewedIFoodModel GetById(int id);

        List<ReviewedIFoodModel> GetAll();

        ReviewedIFoodModel Create(ReviewedIFoodModel ReviewedIFoodModel);

        bool Delete(int id);

        ReviewedIFoodModel Update(int id, ReviewedIFoodModel ReviewedIFoodModel);
    }
}
