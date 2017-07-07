using System.Web.Mvc;

namespace Pasapalabra.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}