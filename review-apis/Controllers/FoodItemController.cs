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
    [Authorize]
    public class FoodItemController : ControllerBase
    {
        FoodItemInterface _db;

        public FoodItemController(FoodItemInterface context)
        {
            _db = context;
        }

        [Route("api/food-items")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.GetAll());
        }


        [Route("api/food-item/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_db.GetById(id));
        }

        [Route("api/create-food-item")]
        [HttpPost]
        public IActionResult Create(FoodItemModel model)
        {
            return Ok(_db.Create(model));
        }

        [Route("api/update-food-item/{id}")]
        [HttpPatch]
        public IActionResult Update(int id, FoodItemModel model)
        {
            return Ok(_db.Update(id, model));
        }

        [Route("api/delete-food-item/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_db.Delete(id));
        }
    }
}
