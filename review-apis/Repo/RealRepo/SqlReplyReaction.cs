using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using review_apis.Models;
using Microsoft.EntityFrameworkCore;
using review_apis.Repo.Interface;
namespace review_apis.Repo.RealRepo
{
    public class SqlReplyReaction : ReplyReactionInterface
    {
        private DbReferenceContext _dbReference;

        public SqlReplyReaction(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public ReplyReactionModel Create(ReplyReactionModel ReplyReactionModel)
        {
            _dbReference.ReplyReactionModel.Add(ReplyReactionModel);
            _dbReference.SaveChanges();
            return ReplyReactionModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.ReplyReactionModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ReplyReactionModel> GetAll()
        {
            return _dbReference.ReplyReactionModel
                .Include(c => c.UserModel)
                .ToList();
        }

        public ReplyReactionModel GetById(int id)
        {
            var item = _dbReference.ReplyReactionModel
                .Include(c => c.UserModel)
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public ReplyReactionModel Update(int id, ReplyReactionModel ReplyReactionModel)
        {
            throw new NotImplementedException();
        }
    }
}
