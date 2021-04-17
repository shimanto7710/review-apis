using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.Interface
{
    public interface BadgeInterface
    {
        public BadgeModel GetBadgeById(int id);

        List<BadgeModel> GetBadgeList();

        BadgeModel CreateBadge(BadgeModel BadgeModel);

        bool DeleteBadge(int id);

        BadgeModel UpdateBadge(int id, BadgeModel BadgeModel);
    }
}
