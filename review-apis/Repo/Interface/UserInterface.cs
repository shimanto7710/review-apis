using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface UserInterface
    {
        public UserModel GetUserById(int id);

        public UserModel GetUserByIdWithReview(int id);

        List<UserModel> GetUserList();

        UserModel CreateUser(UserModel userModel);

        bool DeleteUser(int id);

        UserModel UpdateUser(int id,UserModel userModel);
    }
}
