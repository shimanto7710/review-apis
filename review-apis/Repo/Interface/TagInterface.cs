using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface TagInterface
    {
        public TagModel GetById(int id);

        List<TagModel> GetAll();

        TagModel Create(TagModel TagModel);

        bool Delete(int id);

        TagModel Update(int id, TagModel TagModel);
    }
}
