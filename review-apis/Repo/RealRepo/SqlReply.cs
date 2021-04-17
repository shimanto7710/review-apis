using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using review_apis.Models;
using review_apis.Repo.Interface;
using Microsoft.EntityFrameworkCore;
namespace review_apis.Repo.RealRepo
{
    public class SqlReply : ReplyInterface
    {
        private DbReferenceContext _dbReference;

        public SqlReply(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public ReplyModel Create(ReplyModel ReplyModel)
        {
            _dbReference.ReplyModel.Add(ReplyModel);
            _dbReference.SaveChanges();
            return ReplyModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.ReplyModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ReplyModel> GetAll()
        {
            return _dbReference.ReplyModel
                .Include(c => c.UserModel)
                .Include(c => c.ReplyReactionList)
                .ToList();
        }

        public ReplyModel GetById(int id)
        {
            var item = _dbReference.ReplyModel
                .Include(c => c.UserModel)
                .Include(c => c.ReplyReactionList)
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public ReplyModel Update(int id, ReplyModel ReplyModel)
        {
            throw new NotImplementedException();
        }
    }
}
