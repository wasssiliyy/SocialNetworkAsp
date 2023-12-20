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

        public IActionResult Birthday()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        public IActionResult Favorite()
        {
            return View();
        }

        public IActionResult Friends()
        {
            return View();
        }


        public IActionResult HelpAndSupport()
        {
            return View();
        }

        public IActionResult Live_Chat()
        {
            return View();
        }

        public IActionResult Messages()
        {
            return View();
        }


        public IActionResult MyProfile()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}