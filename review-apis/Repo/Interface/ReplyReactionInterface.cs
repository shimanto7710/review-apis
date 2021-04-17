using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface ReplyReactionInterface
    {
        public ReplyReactionModel GetById(int id);

        List<ReplyReactionModel> GetAll();

        ReplyReactionModel Create(ReplyReactionModel ReplyReactionModel);

        bool Delete(int id);

        ReplyReactionModel Update(int id, ReplyReactionModel ReplyReactionModel);
    }
}
