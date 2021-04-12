using CakeShop.Service.Users.Interface;
using CakeShop.Service.Users.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CakeShop.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterModel request)
        {
            var result = await _userService.RegisterUser(request);
            if (result == false)
            {
                return BadRequest("Register not succeeded!");
            }
            return Ok("Register OK!");
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAuthen([FromBody] LoginAuthenRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var resultToken = await _userService.LoginAuthenticate(request);
            if (string.IsNullOrEmpty(resultToken))
            {
                return BadRequest(resultToken);
            }
            return Ok(resultToken);
        }
        [HttpGet("get-all-user")]
        public async Task<IActionResult> GetAllUsers()
        {
            var user = await _userService.GetAllUserService();
            return Ok(user);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _userService.DeleteUser(id);
            return Ok(result);
        }
    }
}
