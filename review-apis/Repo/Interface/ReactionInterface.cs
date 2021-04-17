using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface ReactionInterface
    {
        public ReactionModel GetById(int id);

        List<ReactionModel> GetAll();

        ReactionModel Create(ReactionModel ReactionModel);

        bool Delete(int id);

        ReactionModel Update(int id, ReactionModel ReactionModel);
    }
}
