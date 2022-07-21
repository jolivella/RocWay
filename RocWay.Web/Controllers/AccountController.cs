using Microsoft.AspNetCore.Mvc;

namespace RocWay.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
