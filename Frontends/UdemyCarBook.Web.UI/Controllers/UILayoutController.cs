using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.Web.UI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
