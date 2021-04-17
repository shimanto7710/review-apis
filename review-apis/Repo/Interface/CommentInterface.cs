using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface CommentInterface
    {
        public CommentModel GetById(int id);

        List<CommentModel> GetAll();

        CommentModel Create(CommentModel CommentModel);

        bool Delete(int id);

        CommentModel Update(int id, CommentModel CommentModel);
    }
}
