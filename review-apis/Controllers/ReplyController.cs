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
    public class ReplyController : ControllerBase
    {
        ReplyInterface _db;

        public ReplyController(ReplyInterface context)
        {
            _db = context;
        }

        [Route("api/replys")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.GetAll());
        }


        [Route("api/reply/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_db.GetById(id));
        }

        [Route("api/create-reply")]
        [HttpPost]
        public IActionResult Create(ReplyModel model)
        {
            return Ok(_db.Create(model));
        }

        [Route("api/update-reply/{id}")]
        [HttpPatch]
        public IActionResult Update(int id, ReplyModel model)
        {
            return Ok(_db.Update(id, model));
        }

        [Route("api/delete-reply/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_db.Delete(id));
        }
    }
}
