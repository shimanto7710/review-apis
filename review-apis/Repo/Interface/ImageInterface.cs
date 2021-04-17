using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface ImageInterface
    {
        public ImageModel GetById(int id);

        List<ImageModel> GetAll();

        ImageModel Create(ImageModel ImageModel);

        bool Delete(int id);

        ImageModel Update(int id, ImageModel ImageModel);
    }
}
