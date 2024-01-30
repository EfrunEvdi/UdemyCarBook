using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.Web.UI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
