using Microsoft.AspNetCore.Mvc;
using SocialNetworkAsp.WebUI.Models;

namespace SocialNetworkAsp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var obj= new RegisterViewModel();
            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid) 
            {
            }


            return View();
        }
    }
}
