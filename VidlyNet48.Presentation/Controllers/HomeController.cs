using System.Web.Mvc;
using System.Web.UI;

namespace VidlyNet48.Presentation.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        // [OutputCache(Duration = 50, Location = OutputCacheLocation.Server, VaryByParam = "*")]
        [OutputCache(Duration = 0, VaryByParam = "*", NoStore = true)] // For disabling caching
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}