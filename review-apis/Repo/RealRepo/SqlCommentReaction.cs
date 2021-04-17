using review_apis.Models;
using System;
using review_apis.Repo.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace review_apis.Repo.RealRepo
{
    public class SqlCommentReaction : CommentReactionInterface
    {
        private DbReferenceContext _dbReference;

        public SqlCommentReaction(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public CommentReactionModel Create(CommentReactionModel CommentReactionModel)
        {
            _dbReference.CommentReactionModel.Add(CommentReactionModel);
            _dbReference.SaveChanges();
            return CommentReactionModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.CommentReactionModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<CommentReactionModel> GetAll()
        {
            return _dbReference.CommentReactionModel
                .Include(c => c.UserModel)
                .ToList();
        }

        public CommentReactionModel GetById(int id)
        {
            var item = _dbReference.CommentReactionModel
                .Include(c => c.UserModel)
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public CommentReactionModel Update(int id, CommentReactionModel CommentReactionModel)
        {
            throw new NotImplementedException();
        }
    }
}
