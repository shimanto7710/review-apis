using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using review_apis.Models;
using review_apis.Repo.Interface;
using Microsoft.EntityFrameworkCore;
namespace review_apis.Repo.RealRepo
{
    public class SqlReaction : ReactionInterface
    {
        private DbReferenceContext _dbReference;

        public SqlReaction(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public ReactionModel Create(ReactionModel ReactionModel)
        {
            _dbReference.ReactionModel.Add(ReactionModel);
            _dbReference.SaveChanges();
            return ReactionModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.ReactionModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ReactionModel> GetAll()
        {
            return _dbReference.ReactionModel
                .Include(c => c.UserModel)
                .ToList();
        }

        public ReactionModel GetById(int id)
        {
            var item = _dbReference.ReactionModel
                .Include(c => c.UserModel)
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public ReactionModel Update(int id, ReactionModel ReactionModel)
        {
            throw new NotImplementedException();
        }
    }
}
