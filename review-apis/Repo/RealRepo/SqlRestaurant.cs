using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using review_apis.Models;
using review_apis.Repo.Interface;
using Microsoft.EntityFrameworkCore;
namespace review_apis.Repo.RealRepo
{
    public class SqlRestaurant : RestaurantInterface
    {
        private DbReferenceContext _dbReference;

        public SqlRestaurant(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public RestaurantModel Create(RestaurantModel RestaurantModel)
        {
            _dbReference.RestaurantModel.Add(RestaurantModel);
            _dbReference.SaveChanges();
            return RestaurantModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.RestaurantModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<RestaurantModel> GetAll()
        {
            return _dbReference.RestaurantModel
               //.Include(c => c.UserModel)
               .ToList();
        }

        public RestaurantModel GetById(int id)
        {
            var item = _dbReference.RestaurantModel
                //.Include(c => c.UserModel)
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public RestaurantModel Update(int id, RestaurantModel RestaurantModel)
        {
            throw new NotImplementedException();
        }
    }
}
