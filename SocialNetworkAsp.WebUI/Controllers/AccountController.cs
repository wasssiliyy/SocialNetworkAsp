using Microsoft.AspNetCore.Mvc;

namespace SocialNetworkAsp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
