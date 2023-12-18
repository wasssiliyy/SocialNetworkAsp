using Microsoft.AspNetCore.Mvc;
using SocialNetworkAsp.WebUI.Models;
using System.Diagnostics;

namespace SocialNetworkAsp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

       

        
    }
}