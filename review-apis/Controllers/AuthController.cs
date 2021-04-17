using Microsoft.AspNetCore.Mvc;
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
    public class AuthController : Controller
    {
        public IConfiguration _configuration;
        private DbReferenceContext _dbReference;
        UserInterface _userInterface;

        public AuthController(UserInterface _uInterface, IConfiguration config, DbReferenceContext dbContext)
        {
            _userInterface = _uInterface;
            _configuration = config;
            _dbReference = dbContext;
        }

        [Route("api/login")]
        [HttpPost]
        public IActionResult Auth()
        {
            string Phone = "+8801686352645";
            if (Phone != null)
            {
                //var user = _dbReference.User.AsQueryable();

                var user = _dbReference.User.Where(i => i.PhoneNumber == (Phone));

                //var user=_dbReference.User.FirstOrDefault(user => user.PhoneNumber==Phone);
                //var user = _dbReference.User.FromSql("Select * from Students where Name = 'Bill'");


                // var user = _dbReference.User.FromSqlRaw("SELECT * FROM User Where PhoneNumber == +8801686352645").ToList();




                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("PhoneNumber", Phone.ToString()),
                   /* new Claim("FirstName", user.FirstName),
                    new Claim("LastName", user.LastName),
                    new Claim("UserName", user.UserName),
                    new Claim("Email", user.Email)*/
                   };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                    //return Ok(user);
                }
                else
                {
                    var newUser = new UserModel();
                    newUser.PhoneNumber = Phone;
                    newUser.BadgeId = 1;

                    _dbReference.User.Add(newUser);
                    _dbReference.SaveChanges();

                    //create claims details based on the user information
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("PhoneNumber", Phone.ToString()),
                   /* new Claim("FirstName", user.FirstName),
                    new Claim("LastName", user.LastName),
                    new Claim("UserName", user.UserName),
                    new Claim("Email", user.Email)*/
                   };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));

                }
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
