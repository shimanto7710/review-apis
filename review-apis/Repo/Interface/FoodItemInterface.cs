using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface FoodItemInterface
    {
        public FoodItemModel GetById(int id);

        List<FoodItemModel> GetAll();

        FoodItemModel Create(FoodItemModel FoodItemModel);

        bool Delete(int id);

        FoodItemModel Update(int id, FoodItemModel FoodItemModel);
    }
}
