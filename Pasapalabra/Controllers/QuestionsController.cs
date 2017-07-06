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

        public IList<Question> GetQuestions()
        { 
            var questions = db.Questions.ToList();
            return questions;
        }

        public Question GetQuestionByLetter(string letter)
        {
            var questions = db.Questions.ToList();

            var question = questions.SingleOrDefault(q => q.Letter == letter);

            if(question == null)
            {
                return null;
            }

            return question;
        }
    }
}