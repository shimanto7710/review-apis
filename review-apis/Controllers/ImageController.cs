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
    public class ImageController : ControllerBase
    {
        ImageInterface _db;

        public ImageController(ImageInterface context)
        {
            _db = context;
        }

        [Route("api/images")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.GetAll());
        }


        [Route("api/image/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_db.GetById(id));
        }

        [Route("api/create-image")]
        [HttpPost]
        public IActionResult Create(ImageModel model)
        {
            return Ok(_db.Create(model));
        }

        [Route("api/update-image/{id}")]
        [HttpPatch]
        public IActionResult Update(int id, ImageModel model)
        {
            return Ok(_db.Update(id, model));
        }

        [Route("api/delete-image/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_db.Delete(id));
        }

    }
}
