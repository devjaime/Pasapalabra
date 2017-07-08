using Pasapalabra.Models;
using System;
using System.Collections.Generic;
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
            // Get all questions from database as an array
            var questions = db.Questions.ToArray();

            // Throw exception if there are no questions in database
            if (questions == null)
            {
                throw new NullReferenceException("There are no questions available in the database.");
            }
            else
            {
                // Initialize new random
                var random = new Random();

                // Get random question from A to Z
                var randomQuestions = questions
                                      .GroupBy(q => q.Letter)
                                      .SelectMany(g => g.Skip(random.Next(g.Count())).Take(1));

                // If there aren't 26 valid questions, throw exception
                if (randomQuestions.Count() != 26)
                {
                    throw new InvalidOperationException("All questions must contain letters A to Z.");
                }

                // Otherwise return randomized questions as Json object
                else
                {
                    return Json(randomQuestions, JsonRequestBehavior.AllowGet);
                }
            }
        }
    }
}