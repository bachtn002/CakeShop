using CakeShop.Admin.IntegrateBackendAPI;
using CakeShop.Service.Users.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CakeShop.Admin.Controllers
{
    // Lu nhoc ky quai pho backer


    [Authorize]
    public class UserController : Controller
    {
        private readonly IManageUsersApi _manageUsersApi;
        public UserController(IManageUsersApi manageUsersApi)
        {
            _manageUsersApi = manageUsersApi;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _manageUsersApi.GetAllUser();
            return View(data);
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            return View(new DeleteModel()
            {
                Id = id
            });

        }
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteModel request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _manageUsersApi.DeleteUserById(request.Id);
            if (result.IsSuccessed)
                return RedirectToAction("Index");
            ModelState.AddModelError("", result.Message);
            return View(request);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create(RegisterModel request)
        {
            if (!ModelState.IsValid)
                return View();

            var result =await _manageUsersApi.Create(request);
            if (result)
            {
                return RedirectToAction("Index");
            }
            return View(request);

        }
    }
}
