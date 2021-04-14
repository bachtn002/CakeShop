using Admin.IntegrateBackendAPI;
using CakeShop.Service.Users.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Controllers
{

    public class LoginController : Controller
    {
        private readonly ILoginApi _loginApi;
        private readonly IConfiguration _configuration;
        public LoginController(ILoginApi loginApi, IConfiguration configuration)
        {
            _loginApi = loginApi;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }
        [HttpGet]
        public async Task<IActionResult> Login()

        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            // Câu lệnh trên là: vào trang login thì sẽ logout các session cũ đi 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginAuthenRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            else
            {
                // Goi den backend api
                var token = await _loginApi.Authen(request);
                if (string.IsNullOrEmpty(token))
                {
                    return View();
                }
                else
                { 
                    // Sau khi lấy được token, chúng ta sẽ giải mã token này bằng hàm giải mã
                    var userPrincipal = this.ValidateToken(token);
                    var authenProperties = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTimeOffset.UtcNow.AddSeconds(30),
                        IsPersistent = false
                    };
                    HttpContext.Session.SetString("Token", token);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        userPrincipal, authenProperties);
                    return RedirectToAction("Index", "Home");
                }
            }
        }
        private ClaimsPrincipal ValidateToken(string ValidToken)
        {
            IdentityModelEventSource.ShowPII = true;
            SecurityToken securityToken;
            TokenValidationParameters tokenValidatio = new TokenValidationParameters();
            tokenValidatio.ValidateLifetime = true;
            tokenValidatio.ValidAudience = _configuration["JWT:ValidAudience"];
            tokenValidatio.ValidIssuer = _configuration["JWT:ValidIssuer"];
            tokenValidatio.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            ClaimsPrincipal claimsPrincipal = new JwtSecurityTokenHandler().ValidateToken(ValidToken, tokenValidatio, out securityToken);
            return claimsPrincipal;
        }
    }
}
