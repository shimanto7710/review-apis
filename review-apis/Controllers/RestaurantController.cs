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
    public class RestaurantController : ControllerBase
    {
        RestaurantInterface _db;

        public RestaurantController(RestaurantInterface context)
        {
            _db = context;
        }

        [Route("api/restaurants")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.GetAll());
        }


        [Route("api/restaurant/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_db.GetById(id));
        }

        [Route("api/create-restaurant")]
        [HttpPost]
        public IActionResult Create(RestaurantModel model)
        {
            return Ok(_db.Create(model));
        }

        [Route("api/update-restaurant/{id}")]
        [HttpPatch]
        public IActionResult Update(int id, RestaurantModel model)
        {
            return Ok(_db.Update(id, model));
        }

        [Route("api/delete-restaurant/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_db.Delete(id));
        }
    }
}
