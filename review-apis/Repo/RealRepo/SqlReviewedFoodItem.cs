using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using review_apis.Models;
using review_apis.Repo.Interface;
using Microsoft.EntityFrameworkCore;
namespace review_apis.Repo.RealRepo
{
    public class SqlReviewedFoodItem : ReviewedFoodItemInterface
    {
        private DbReferenceContext _dbReference;

        public SqlReviewedFoodItem(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public ReviewedIFoodModel Create(ReviewedIFoodModel ReviewedIFoodModel)
        {
            _dbReference.ReviewedIFoodModel.Add(ReviewedIFoodModel);
            _dbReference.SaveChanges();
            return ReviewedIFoodModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.ReviewedIFoodModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ReviewedIFoodModel> GetAll()
        {
            return _dbReference.ReviewedIFoodModel
               .Include(c => c.TagList)
               .ToList();
        }

        public ReviewedIFoodModel GetById(int id)
        {
            var item = _dbReference.ReviewedIFoodModel
                .Include(c => c.TagList)
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public ReviewedIFoodModel Update(int id, ReviewedIFoodModel ReviewedIFoodModel)
        {
            throw new NotImplementedException();
        }
    }
}
