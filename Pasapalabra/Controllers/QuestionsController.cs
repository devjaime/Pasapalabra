using Pasapalabra.Models;
using System.Linq;
using System.Web.Mvc;

namespace Pasapalabra.Controllers
{
    public class QuestionsController : Controller
    {
        private PasapalabraContext db = new PasapalabraContext();

        public ActionResult Index()
        {
            return View();
        }

        // Returns array of questions from database as a Json object
        public JsonResult GetQuestions()
        {
            var questions = db.Questions.ToArray();

            if(questions == null)
            {
                return null;
            }

            return Json(questions, JsonRequestBehavior.AllowGet);
        }
    }
}