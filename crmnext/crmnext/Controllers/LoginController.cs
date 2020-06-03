using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;

namespace APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public Object GetToken() {
            string key = "my_secreat_key_2020";
            var issuer = "http://localhost/";
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var parmClaims = new List<Claim>();
            parmClaims.Add(new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            parmClaims.Add(new Claim("valid", "1"));
            parmClaims.Add(new Claim("userid", "1"));
            parmClaims.Add(new Claim("name", "vinod"));

            var token = new JwtSecurityToken(
                issuer,
                issuer,
                parmClaims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
                );
            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);

            return new { data = jwt_token };
        }
    }
}