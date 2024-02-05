using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.Web.UI.ViewComponents.AboutViewComponents
{
    public class _BecomeADriverComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
