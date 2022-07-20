using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProjectTracker.API.Models;
using ProjectTracker.Business;
using System.IdentityModel.Tokens.Jwt;

using System.Security.Claims;
using System.Text;

namespace ProjectTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginModel userLoginModel)
        {
            var user = await userService.ValidateUser(userLoginModel.UserName, userLoginModel.Password);
            if (user != null)
            {
                //payload
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Name, user.UserName),
                    new Claim(ClaimTypes.Role, user.Role)
                };

                //key:
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("cok gizli ve onemli bir cumle"));
                var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    issuer: "kalegrup",
                    audience: "kalegrup",
                    claims: claims,
                    notBefore: DateTime.Now,
                    expires: DateTime.Now.AddMinutes(10),
                    signingCredentials: credential
                    );
                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });


                //TOKEN verilecek.
            }
            return BadRequest(new { message="Kullanıcı adı ya da şifre yanlış" });
        }
    }
}
