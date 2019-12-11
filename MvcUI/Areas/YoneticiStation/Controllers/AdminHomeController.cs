using System.Web.Mvc;
using MvcUI.Models.ViewModels;

namespace MvcUI.Areas.YoneticiStation.Controllers
{
    [_SessionControl]
    public class AdminHomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            DashViewModel dm=new DashViewModel();
            return View(dm);
        }
    }
}