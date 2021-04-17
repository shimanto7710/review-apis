using System;
using System.Collections.Generic;
using System.Linq;
using review_apis.Models;
using System.Threading.Tasks;
using review_apis.Repo.Interface;
using Microsoft.EntityFrameworkCore;

namespace review_apis.Repo.RealRepo
{
    public class SqlImage : ImageInterface
    {
        private DbReferenceContext _dbReference;

        public SqlImage(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public ImageModel Create(ImageModel ImageModel)
        {
            _dbReference.ImageModel.Add(ImageModel);
            _dbReference.SaveChanges();
            return ImageModel;
        }

        public bool Delete(int id)
        {
            var item = _dbReference.ImageModel.Find(id);
            if (item != null)
            {
                _dbReference.Remove(item);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ImageModel> GetAll()
        {
            return _dbReference.ImageModel
                .ToList();
        }

        public ImageModel GetById(int id)
        {
            var item = _dbReference.ImageModel
                .FirstOrDefault(x => x.Id == id);

            return item;
        }

        public ImageModel Update(int id, ImageModel ImageModel)
        {
            throw new NotImplementedException();
        }
    }
}
