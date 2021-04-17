using review_apis.ProfileData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.Models
{
    public class SqlProfileData : ProfileInterface
    {
        private DbReferenceContext _profileContext;

        public SqlProfileData(DbReferenceContext profileContext) {
            _profileContext = profileContext;
        }

        public ProfileModel AddProfile(ProfileModel profileModel)
        {
            profileModel.Id = Guid.NewGuid();
            _profileContext.Profile.Add(profileModel);
            _profileContext.SaveChanges();
            return profileModel;
        }

        public bool DeleteProfile(ProfileModel profileModel)
        {
            var profile = _profileContext.Profile.Find(profileModel.Id);
            if (profile != null)
            {
                _profileContext.Remove(profile);
                return true;
            }
            return false;
           // var profile =_profileContext.G
        }

        public ProfileModel GetProfile(Guid id)
        {
            var profile = _profileContext.Profile.Find(id);
            return profile;
          //  return _profileContext.Profile.SingleOrDefault(x => x.Id == id);
        }

        public List<ProfileModel> GetProfiles()
        {
            return _profileContext.Profile.ToList();
        }

        public ProfileModel UpdateProfile(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProfile(Guid id,ProfileModel profile)
        {
            var aaa = _profileContext.Profile.Find(id);
            if (aaa != null)
            {
                profile.Id = id;
                _profileContext.Update(profile);
                return true;
            }

            return true;
        }
    }
}
