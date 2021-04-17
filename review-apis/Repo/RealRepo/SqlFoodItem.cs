using System;
using System.Collections.Generic;
using System.Linq;
using review_apis.Models;
using System.Threading.Tasks;
using review_apis.Repo.Interface;
using Microsoft.EntityFrameworkCore;

namespace review_apis.Repo.RealRepo
{
    public class SqlFoodItem : FoodItemInterface
    {
        private DbReferenceContext _dbReference;

        public SqlFoodItem(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public FoodItemModel Create(FoodItemModel FoodItemModel)
        {
            _dbReference.FoodItemModel.Add(FoodItemModel);
            _dbReference.SaveChanges();
            return FoodItemModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.FoodItemModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<FoodItemModel> GetAll()
        {
            return _dbReference.FoodItemModel
                //.Include(c => c.UserModel)
                .ToList();
        }

        public FoodItemModel GetById(int id)
        {
            var item = _dbReference.FoodItemModel
                //.Include(c => c.UserModel)
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public FoodItemModel Update(int id, FoodItemModel FoodItemModel)
        {
            throw new NotImplementedException();
        }
    }
}
