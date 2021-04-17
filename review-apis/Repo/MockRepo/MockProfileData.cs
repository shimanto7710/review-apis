

using review_apis.ProfileData;
using System;
using System.Collections.Generic;

namespace review_apis.Models
{
    public class MockProfileData : ProfileInterface
    {
        private List<ProfileModel> _profileList = new List<ProfileModel>()
        {
            new ProfileModel()
            {
                Id=Guid.NewGuid(),
                UserName="Shimanto Ahmed"
            },
            new ProfileModel()
            {
                Id=Guid.NewGuid(),
                UserName="Md. Afser Uddin"
            }
        };

        public ProfileModel AddProfile(ProfileModel profileModel)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProfile(ProfileModel profileModel)
        {
            throw new NotImplementedException();
        }

        public ProfileModel GetProfile(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ProfileModel> GetProfiles()
        {
            return _profileList;
        }

        public ProfileModel UpdateProfile(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProfile(Guid id, ProfileModel profile)
        {
            throw new NotImplementedException();
        }
    }
}
