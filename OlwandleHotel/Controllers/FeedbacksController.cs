using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OlwandleHotel.Models;
using System.Threading.Tasks;

namespace OlwandleHotel.Controllers
{
    public class FeedbacksController : Controller
    {
        ApplicationDbContext context;

        public FeedbacksController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Feedback
        public ActionResult Index()
        {
            return View(context.Feedbacks.ToList());
        }

        public ActionResult Index1()
        {
            return View();
        }

        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(FeedbackViewModel model)
        {
            if (ModelState.IsValid)
            {
               
                return RedirectToAction("Index1");

            }
            model.Answers = Common.GetAnswers();
            return RedirectToAction("Index1");
        }
    }
}