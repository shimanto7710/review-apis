using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface ReviewInterface
    {
        public ReviewModel GetById(int id);

        List<ReviewModel> GetAll();

        ReviewModel Create(ReviewModel ReviewModel);

        bool Delete(int id);

        ReviewModel Update(int id, ReviewModel ReviewModel);
    }
}
