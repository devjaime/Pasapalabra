using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Pasapalabra.Models;

namespace Pasapalabra.Controllers.Api
{
    public class QuestionsController : ApiController
    {
        private PasapalabraContext db = new PasapalabraContext();

        // GET: api/Questions
        public IList<Question> GetQuestions()
        {
            var questions = db.Questions.ToList();
            return questions;
        }

        // GET: api/Questions/5
        [ResponseType(typeof(Question))]
        public IHttpActionResult GetQuestionById(int id)
        {
            Question question = db.Questions.Find(id);
            if (question == null)
            {
                return NotFound();
            }

            return Ok(question);
        }
    }
}