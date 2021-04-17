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
    [ApiController]
    public class ReviewedRestaurantController : ControllerBase
    {
        ReviewedRestaurantInterface _db;

        public ReviewedRestaurantController(ReviewedRestaurantInterface context)
        {
            _db = context;
        }

        [Route("api/reviewed-restaurants")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.GetAll());
        }


        [Route("api/reviewed-restaurant/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_db.GetById(id));
        }

        [Route("api/create-reviewed-restaurant")]
        [HttpPost]
        public IActionResult Create(ReviewedRestaurantModel model)
        {
            return Ok(_db.Create(model));
        }

        [Route("api/update-reviewed-restaurant/{id}")]
        [HttpPatch]
        public IActionResult Update(int id, ReviewedRestaurantModel model)
        {
            return Ok(_db.Update(id, model));
        }

        [Route("api/delete-reviewed-restaurant/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_db.Delete(id));
        }
    }
}
