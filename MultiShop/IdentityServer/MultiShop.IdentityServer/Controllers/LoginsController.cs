using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MultiShop.IdentityServer.Dtos;
using MultiShop.IdentityServer.Models;
using MultiShop.IdentityServer.Tools;
using System.Threading.Tasks;

namespace MultiShop.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _singInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public LoginsController(SignInManager<ApplicationUser> singInManager, UserManager<ApplicationUser> userManager)
        {
            _singInManager = singInManager;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginDto userLoginDto)
        {
            var result = await _singInManager.PasswordSignInAsync(userLoginDto.UserName, userLoginDto.Password, false, false);
            var user = await _userManager.FindByNameAsync(userLoginDto.UserName);

            if (result.Succeeded)
            {
                GetCheckAppUserViewModel model = new GetCheckAppUserViewModel();
                model.UserName = userLoginDto.UserName;
                model.Id = user.Id;
                var token = JwtTokenGenerator.GenerateToken(model);
                return Ok(token);
            }
            else
            {
                return Ok("Kullanıcı adı veya şifre hatalı");
            }
        }
    }
}
