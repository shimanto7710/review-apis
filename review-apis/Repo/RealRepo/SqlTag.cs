using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using review_apis.Models;
using review_apis.Repo.Interface;
using Microsoft.EntityFrameworkCore;
namespace review_apis.Repo.RealRepo
{
    public class SqlTag : TagInterface
    {
        private DbReferenceContext _dbReference;

        public SqlTag(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public TagModel Create(TagModel TagModel)
        {
            _dbReference.TagModel.Add(TagModel);
            _dbReference.SaveChanges();
            return TagModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.TagModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<TagModel> GetAll()
        {
            return _dbReference.TagModel
              .ToList();
        }

        public TagModel GetById(int id)
        {
            var item = _dbReference.TagModel
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public TagModel Update(int id, TagModel TagModel)
        {
            throw new NotImplementedException();
        }
    }
}
