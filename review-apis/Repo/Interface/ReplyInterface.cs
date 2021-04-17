using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface ReplyInterface
    {
        public ReplyModel GetById(int id);

        List<ReplyModel> GetAll();

        ReplyModel Create(ReplyModel ReplyModel);

        bool Delete(int id);

        ReplyModel Update(int id, ReplyModel ReplyModel);
    }
}
