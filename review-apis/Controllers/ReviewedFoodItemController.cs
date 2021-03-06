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
    public class ReviewedFoodItemController : ControllerBase
    {
        ReviewedFoodItemInterface _db;

        public ReviewedFoodItemController(ReviewedFoodItemInterface context)
        {
            _db = context;
        }

        [Route("api/reviewed-food-items")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.GetAll());
        }


        [Route("api/reviewed-food-item/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_db.GetById(id));
        }

        [Route("api/create-reviewed-food-item")]
        [HttpPost]
        public IActionResult Create(ReviewedIFoodModel model)
        {
            return Ok(_db.Create(model));
        }

        [Route("api/update-reviewed-food-item/{id}")]
        [HttpPatch]
        public IActionResult Update(int id, ReviewedIFoodModel model)
        {
            return Ok(_db.Update(id, model));
        }

        [Route("api/delete-reviewed-food-item/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_db.Delete(id));
        }
    }
}
