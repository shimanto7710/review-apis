using review_apis.Models;
using review_apis.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace review_apis.Repo.RealRepo
{
    public class SqlComment : CommentInterface
    {
        private DbReferenceContext _dbReference;

        public SqlComment(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public CommentModel Create(CommentModel CommentModel)
        {
            _dbReference.CommentModel.Add(CommentModel);
            _dbReference.SaveChanges();
            return CommentModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.CommentModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<CommentModel> GetAll()
        {
            return _dbReference.CommentModel
                .Include(c=> c.ReplyList)
                .Include(c=> c.CommentReactionList)
                .Include(c=> c.UserModel)
                .ToList();
        }

        public CommentModel GetById(int id)
        {
            var item = _dbReference.CommentModel
                .Include(c => c.ReplyList)
                .Include(c => c.CommentReactionList)
                .Include(c => c.UserModel)
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public CommentModel Update(int id, CommentModel CommentModel)
        {
            throw new NotImplementedException();
        }
    }
}
