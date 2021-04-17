using review_apis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review_apis.ProfileData
{
   public interface ProfileInterface
    {
         List<ProfileModel> GetProfiles();

        ProfileModel GetProfile(Guid id);

        ProfileModel AddProfile(ProfileModel profileModel);

        bool DeleteProfile(ProfileModel profileModel);

        ProfileModel UpdateProfile(Guid id);

        bool UpdateProfile(Guid id, ProfileModel profile);
    }
}
