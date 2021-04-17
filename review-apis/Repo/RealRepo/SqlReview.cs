using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using review_apis.Models;
using review_apis.Repo.Interface;
using Microsoft.EntityFrameworkCore;
namespace review_apis.Repo.RealRepo
{
    public class SqlReview :ReviewInterface
    {
        private DbReferenceContext _dbReference;

        public SqlReview(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public ReviewModel Create(ReviewModel ReviewModel)
        {
            _dbReference.ReviewModel.Add(ReviewModel);
            _dbReference.SaveChanges();
            return ReviewModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.ReviewModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ReviewModel> GetAll()
        {
            return _dbReference.ReviewModel
               .Include(c => c.UserModel)
               .Include(c => c.ReviewedRestaurantModel)
               .Include(c => c.ReviewedFoodList)
               .Include(c => c.ImageList)
               .Include(c => c.CommentList)
               .Include(c => c.ReactionList)
               .ToList();
        }

        public ReviewModel GetById(int id)
        {
            var item = _dbReference.ReviewModel
                .Include(c => c.UserModel)
               .Include(c => c.ReviewedRestaurantModel)
               .Include(c => c.ReviewedFoodList)
               .Include(c => c.ImageList)
               .Include(c => c.CommentList)
               .Include(c => c.ReactionList)
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public ReviewModel Update(int id, ReviewModel ReviewModel)
        {
            throw new NotImplementedException();
        }
    }
}
