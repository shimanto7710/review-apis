using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using review_apis.Models;
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
    public class BadgeController : ControllerBase
    {
        BadgeInterface _db;

        public BadgeController(BadgeInterface _uInterface)
        {
            _db = _uInterface;
        }

        [Route("api/badges")]
        [HttpGet]
        public IActionResult GetBadges()
        {
            return Ok(_db.GetBadgeList());
        }


        [Route("api/badge/{id}")]
        [HttpGet]
        public IActionResult GetBadgeById(int id)
        {
            return Ok(_db.GetBadgeById(id));
        }

        [Route("api/create-badge")]
        [HttpPost]
        public IActionResult CreateBadge(BadgeModel BadgeModel)
        {
            return Ok(_db.CreateBadge(BadgeModel));
        }

        [Route("api/update-badge/{id}")]
        [HttpPatch]
        public IActionResult UpdateBadge(int id, BadgeModel BadgeModel)
        {
            return Ok(_db.UpdateBadge(id, BadgeModel));
        }

        [Route("api/delete-badge/{id}")]
        [HttpDelete]
        public IActionResult DeleteIBadge(int id)
        {
            return Ok(_db.DeleteBadge(id));
        }

    }
}
