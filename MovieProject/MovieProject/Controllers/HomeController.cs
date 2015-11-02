using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieProject.Models;

namespace MovieProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new IndexModel();
            model.Top1Movie = new Top1MovieModel();
            model.Top1Movie.Name = "Terminator 2";
            model.Top1Movie.Directors = new Collection<string>();
            model.Top1Movie.Directors.Add("Dave");
            model.Top1Movie.ImageUri = "/images/header-bg.jpg";
            model.Top1Movie.Rating = 5.5f;
            model.Top1Movie.Genres.Add("Comedy");
            model.Top1Movie.Genres.Add("ActionFilm");
            model.Top1Movie.ReleaDate = new DateTime(2011, 4, 5);
            model.ReviewsList = new ReviewListModel();
            List<string> init_reviews = new List<string>();
            init_reviews.Add("/images/r1.jpg");
            init_reviews.Add("/images/r2.jpg");
            init_reviews.Add("/images/r3.jpg");
            init_reviews.Add("/images/r3.jpg");
            init_reviews.Add("/images/r3.jpg");
            //init_reviews.Add("/images/r3.jpg");
            foreach (string item in init_reviews)
            {
                ReviewModel rModel = new ReviewModel();
                rModel.ImageURI = item;
                rModel.ReviewURI = "";

                model.ReviewsList.Reviews.Add(rModel);
            }
            
            return View(model);
        }

        public ActionResult Error404()
        {
            return View();
        }

        public ActionResult Reviews()
        {
            return View();
        }
    }
}