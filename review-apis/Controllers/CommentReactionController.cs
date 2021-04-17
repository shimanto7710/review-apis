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
    public class CommentReactionController : ControllerBase
    {
        CommentReactionInterface _db;

        public CommentReactionController(CommentReactionInterface context)
        {
            _db = context;
        }

        [Route("api/comment-reactions")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.GetAll());
        }


        [Route("api/comment-reaction/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_db.GetById(id));
        }

        [Route("api/create-comment-reaction")]
        [HttpPost]
        public IActionResult Create(CommentReactionModel model)
        {
            return Ok(_db.Create(model));
        }

        [Route("api/update-comment-reaction/{id}")]
        [HttpPatch]
        public IActionResult Update(int id, CommentReactionModel model)
        {
            return Ok(_db.Update(id, model));
        }

        [Route("api/delete-comment-reaction/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_db.Delete(id));
        }
    }
}
