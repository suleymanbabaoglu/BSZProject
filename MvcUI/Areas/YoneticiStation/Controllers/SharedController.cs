using System.Web.Mvc;

namespace MvcUI.Areas.YoneticiStation.Controllers
{
    public class SharedController : Controller
    {
        public ActionResult _Header()
        {
            return PartialView();
        }
        public ActionResult _Sidebar()
        {
            return PartialView();
        }
    }
}