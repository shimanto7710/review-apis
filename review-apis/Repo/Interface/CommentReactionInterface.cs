using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface CommentReactionInterface
    {
        public CommentReactionModel GetById(int id);

        List<CommentReactionModel> GetAll();

        CommentReactionModel Create(CommentReactionModel CommentReactionModel);

        bool Delete(int id);

        CommentReactionModel Update(int id, CommentReactionModel CommentReactionModel);
    }
}
