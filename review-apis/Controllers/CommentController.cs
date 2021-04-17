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
    public class CommentController : ControllerBase
    {
        CommentInterface _db;

        public CommentController(CommentInterface context)
        {
            _db = context;
        }

        [Route("api/comments")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.GetAll());
        }


        [Route("api/comment/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_db.GetById(id));
        }

        [Route("api/create-comment")]
        [HttpPost]
        public IActionResult Create(CommentModel model)
        {
            return Ok(_db.Create(model));
        }

        [Route("api/update-comment/{id}")]
        [HttpPatch]
        public IActionResult Update(int id, CommentModel model)
        {
            return Ok(_db.Update(id, model));
        }

        [Route("api/delete-comment/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_db.Delete(id));
        }

    }
}
