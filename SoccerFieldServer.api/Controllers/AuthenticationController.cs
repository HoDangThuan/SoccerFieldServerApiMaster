using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SoccerFieldServer.Core.Entities;
using SoccerFieldServer.Infrastructure.Data;
using System.Linq;


namespace SoccerFieldServer.api.Controllers
{    
    /*
    [Route("api/[controller]/[action]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly SoccerFieldServerContext _context;

        public AuthenticationController(IConfiguration config, SoccerFieldServerContext context)
        {
            _config = config;
            _context = context;
        }
        
        [HttpPost]
        public IActionResult CreateToken([FromBody]LoginModel login)
        {
            IActionResult response = Unauthorized();
            var user = Authenticate(login);

            if (user != null)
            {
                var tokenString = BuildToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        private string BuildToken(Customer user)
        {
            //claimns là nội dung ở phần payload, bạn có thể set các thông tin của người dùng tại đây
            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.NameId, user.Id),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Birthdate, user.DateOfBirth.ToString("dd-MM-yyyy")),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(30), //expire time là 30 phút
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        
        private Customer Authenticate(LoginModel login)
        {
            Customer user = (from customer in _context.Customers
                             where login.Id == customer.Id && login.Password==customer.PassWord
                             select customer).SingleOrDefault();
            return user;
        }

        public class LoginModel
        {
            public string Id { get; set; }
            public string Password { get; set; }
        }
    }
    */
}