using Microsoft.EntityFrameworkCore;
using review_apis.Models;
using review_apis.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Repo.RealRepo
{
    public class SqlBadge : BadgeInterface
    {
        private DbReferenceContext _dbReference;

        public SqlBadge(DbReferenceContext context)
        {
            _dbReference = context;
        }

        public BadgeModel CreateBadge(BadgeModel BadgeModel)
        {
            _dbReference.Badge.Add(BadgeModel);
            _dbReference.SaveChanges();
            return BadgeModel;
        }

        public bool DeleteBadge(int id)
        {
            var badge = _dbReference.Badge.Find(id);
            if (badge != null)
            {
                _dbReference.Remove(badge);
                _dbReference.SaveChanges();
                return true;
            }
            return false;
        }

        public BadgeModel GetBadgeById(int id)
        {
            var badge = _dbReference.Badge
                .FirstOrDefault(x => x.Id == id);

            return badge;
        }

        public List<BadgeModel> GetBadgeList()
        {
            return _dbReference.Badge.ToList();
        }

        public BadgeModel UpdateBadge(int id, BadgeModel BadgeModel)
        {
            var badge = _dbReference.Badge.Find(id);

            if (badge != null)
            {
                if (BadgeModel.Name != null)
                {
                    badge.Name = BadgeModel.Name;
                }

                if (BadgeModel.CreatedAt != null)
                {
                    badge.CreatedAt = BadgeModel.CreatedAt;
                }

                if (BadgeModel.Point != 0)
                {
                    badge.Point = BadgeModel.Point;
                }

                _dbReference.Update(badge);
                _dbReference.SaveChangesAsync();
                return badge;
            }

            return BadgeModel;
        }
    }
}
