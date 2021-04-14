using CakeShop.Data.EF;
using CakeShop.Data.Entities;
using CakeShop.Service.ApiResult;
using CakeShop.Service.Users.Interface;
using CakeShop.Service.Users.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CakeShop.Service.Users.Service
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly CakeShopDbContext _cakeShopDbContext;
        public UserService(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration, CakeShopDbContext cakeShopDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _cakeShopDbContext = cakeShopDbContext;
        }

        public async Task<ApiResult<bool>> DeleteUser(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<bool>("User khong ton tai !");
            }
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
                return new ApiSuccessResult<bool>();
            return new ApiErrorResult<bool>("Xoa khong thanh cong !");

        }

        public async Task<PagedResultUser<ViewModelUsers>> GetAllUserService()
        {
            var query = from p in _cakeShopDbContext.Users
                        select new { p };
            var data = await query.Select(x => new ViewModelUsers()
            {
                FirstName = x.p.FirstName,
                LastName = x.p.LastName,
                UserName = x.p.UserName,
                Id = x.p.Id,
                PhoneNumber = x.p.PhoneNumber,
                Email = x.p.Email
            }).ToListAsync();
            var pagedResult = new PagedResultUser<ViewModelUsers>()
            {
                Items = data
            };
            return pagedResult;
        }

        public async Task<string> LoginAuthenticate(LoginAuthenRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null) return null;
            var result = await _signInManager
                .PasswordSignInAsync(user, request.PassWord, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return null;
            }
            var authClaim = new List<Claim>
            {
                new Claim(ClaimTypes.GivenName,user.LastName),
                new Claim(ClaimTypes.Surname,user.FirstName),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                new Claim(ClaimTypes.Name,request.UserName),
                new Claim(ClaimTypes.Hash,request.PassWord)

            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaim,
                    signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
            );
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        public async Task<bool> RegisterUser(RegisterModel request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user != null) return false;
            var RegisterUser = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                DateOfB = request.DateOfBirth,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber
            };
            var result = await _userManager.CreateAsync(RegisterUser, request.PassWord);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }


    }
}
