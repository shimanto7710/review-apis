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
using System.Text.Json;
using System.Threading.Tasks;

namespace review_apis.Controllers
{
    [Authorize]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public IConfiguration _configuration;
        UserInterface _userInterface;

        public UsersController(UserInterface _uInterface, IConfiguration config)
        {
            _userInterface = _uInterface;
            _configuration = config;
         
        }



        [Route("api/users")]
        [HttpGet]
        public IActionResult GetUsers()
        {
            //var x = JsonSerializer.Serialize(_userInterface.GetUserList());
            return Ok(_userInterface.GetUserList());
        }


        [Route("api/user/{id}")]
        [HttpGet]
        public IActionResult GetUserById(int id)
        {
            return Ok(_userInterface.GetUserById(id));
        }

        [Route("api/user-with-review/{id}")]
        [HttpGet]
        public IActionResult GetUserByIdWithReview(int id)
        {
            return Ok(_userInterface.GetUserByIdWithReview(id));
        }

        [Route("api/create-user")]
        [HttpPost]
        public IActionResult AddUser(UserModel userModel)
        {
            return Ok(_userInterface.CreateUser(userModel));
        }

        [Route("api/update-user/{id}")]
        [HttpPatch]
        public IActionResult UpdateUser(int id, UserModel userModel)
        {
            return Ok(_userInterface.UpdateUser(id,userModel));
        }

        [Route("api/delete-user/{id}")]
        [HttpDelete]
        public IActionResult DeleteIUser(int id)
        {
            return Ok(_userInterface.DeleteUser(id));
        }



    }
}
