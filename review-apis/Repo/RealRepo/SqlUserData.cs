using review_apis.Models;
using review_apis.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace review_apis.Repo.RealRepo
{
    public class SqlUserData : UserInterface
    {
        private DbReferenceContext _dbReference;

        public SqlUserData(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public UserModel CreateUser(UserModel userModel)
        {
            _dbReference.User.Add(userModel);
            _dbReference.SaveChanges();
            return userModel;
        }

        public bool DeleteUser(int id)
        {
            var user = _dbReference.User.Where(i => i.Id == (id));
            if (user != null)
            {
                _dbReference.Remove(user);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public UserModel GetUserById(int id)
        {
            var user = _dbReference.User
                .Include(user => user.Badge)
                //.Include(user => user.RestaurantModel)
                .FirstOrDefault(x=>x.Id==id);

            return user;
        }

        public UserModel GetUserByIdWithReview(int id)
        {
            var user = _dbReference.User
                .Include(user => user.Badge)
                .Include(user => user.RestaurantModel)
                .Include(user => user.ReviewList)
                .FirstOrDefault(x => x.Id == id);

            return user;
        }

        public List<UserModel> GetUserList()
        {
            return _dbReference.User.Include(a=> a.Badge)
                //.Include(user => user.RestaurantModel)
                //.Include(user => user.ReviewList)
                //.Include(user => user.FoodItemModel)
                .ToList();
            //return _dbReference.User.Include(a =>a.Badge).ToList();
        }

        public UserModel UpdateUser(int id, UserModel userModel)
        {
            var user = _dbReference.User.Find(id);

            if (user != null)
            {
                if (userModel.Email != null)
                {
                    user.Email = userModel.Email;
                }
                if (userModel.Name != null){
                    user.Name = userModel.Name;
                }
                if (userModel.Sex != 0){
                    user.Sex = userModel.Sex;
                }

                if (userModel.Dp != null){
                    user.Dp = userModel.Dp;
                }

                if (userModel.CreatedAt != null){
                    user.CreatedAt = userModel.CreatedAt;
                }
                if (userModel.PhoneNumber != null) {
                    user.PhoneNumber = userModel.PhoneNumber;
                }

                if (userModel.UserType != 0) {
                    user.UserType = userModel.UserType;
                }
                if (userModel.IsFirstTime != false) {
                    user.IsFirstTime = userModel.IsFirstTime;

                }

                if (userModel.FirebaseKey != null) {
                    user.FirebaseKey = userModel.FirebaseKey;
                }
                if (userModel.BadgeId != 0) {
                    user.BadgeId = userModel.BadgeId;
                }


                _dbReference.Update(user);
                _dbReference.SaveChangesAsync();
                return user;
            }

            return userModel;
        }
    }
}
