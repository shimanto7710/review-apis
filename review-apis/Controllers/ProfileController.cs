using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using review_apis.Models;
using review_apis.ProfileData;
using review_apis.Repo.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
namespace review_apis.Controllers
{

    [Authorize]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private ProfileInterface _iProfileData;


        public ProfileController(ProfileInterface iProfileData)
        {
            _iProfileData = iProfileData;
        }

        [Route("api/profiles")]
        [HttpGet]
        public IActionResult GetRofiles()
        {
            return Ok(_iProfileData.GetProfiles());
        }

        [Route("api/profile/{id}")]
        [HttpGet]
        public IActionResult GetProfile(Guid id)
        {
            return Ok(_iProfileData.GetProfile(id));
        }

        [Route("api/add-profile")]
        [HttpPost]
        public IActionResult AddProfile(ProfileModel profileModel)
        {
            return Ok(_iProfileData.AddProfile(profileModel));
        }

        [Route("api/delete-profile")]
        [HttpDelete]
        public IActionResult DeletedProfile(ProfileModel profileModel)
        {
            return Ok(_iProfileData.DeleteProfile(profileModel));
        }

        [Route("api/update-profile/{id}")]
        [HttpPatch]
        public IActionResult UpdateProfile(Guid id,ProfileModel profileModel)
        {
            return Ok(_iProfileData.UpdateProfile(id, profileModel));
        }




    }
}
