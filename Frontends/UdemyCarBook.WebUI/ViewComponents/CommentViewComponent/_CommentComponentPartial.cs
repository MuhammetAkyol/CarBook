using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.CommentViewComponent
{
    public class _CommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
               return View();
        }
    }
}
