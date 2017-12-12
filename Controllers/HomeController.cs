using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using restauranter.Models;


namespace restauranter.Controllers
{
    public class HomeController : Controller
    {
        private ReviewContext _context;
 
        public HomeController(ReviewContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddReview(Review rev)
        {
            if (ModelState.IsValid)
            {
                // add a review here and redirect to a reviews page 
                _context.Add(rev);
                // OR _context.Users.Add(rev);
                _context.SaveChanges();             
                return RedirectToAction("ShowReviews");
            }
            return View("Index");
        }

        [HttpGet]
        [Route("reviews")]
        public IActionResult ShowReviews()
        {   
            // Showing retrieved reviews from db on the following page
            List<Review> RetrievedReviews = _context.reviews.ToList();
            // ViewBag.reviews =  ReturnedReviews; 
            RetrievedReviews.Reverse();     
            return View(model: RetrievedReviews);
        }
        
    }
}
