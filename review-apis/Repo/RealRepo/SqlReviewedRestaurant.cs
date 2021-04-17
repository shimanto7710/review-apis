using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using review_apis.Models;
using review_apis.Repo.Interface;
using Microsoft.EntityFrameworkCore;
namespace review_apis.Repo.RealRepo
{
    public class SqlReviewedRestaurant : ReviewedRestaurantInterface
    {
        private DbReferenceContext _dbReference;

        public SqlReviewedRestaurant(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public ReviewedRestaurantModel Create(ReviewedRestaurantModel ReviewedRestaurantModel)
        {
            _dbReference.ReviewedRestaurantModel.Add(ReviewedRestaurantModel);
            _dbReference.SaveChanges();
            return ReviewedRestaurantModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.ReviewedRestaurantModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ReviewedRestaurantModel> GetAll()
        {
            return _dbReference.ReviewedRestaurantModel
               .Include(c => c.RestaurantModel)
               .ToList();
        }

        public ReviewedRestaurantModel GetById(int id)
        {
            var item = _dbReference.ReviewedRestaurantModel
                .Include(c => c.RestaurantModel)
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public ReviewedRestaurantModel Update(int id, ReviewedRestaurantModel ReviewedRestaurantModel)
        {
            throw new NotImplementedException();
        }
    }
}
