using System.Web.Mvc;

namespace MvcUI.Areas.YoneticiStation
{
    public class YoneticiStationAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "YoneticiStation";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "YoneticiStation_default",
                "YoneticiStation/{controller}/{action}/{id}",
                new { controller = "AdminHome", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}