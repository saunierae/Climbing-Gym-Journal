//Saunie Burke
//SDEV360
//Climbing Gym Website Database
//2/9/2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClimbingGym.Data.Services;

namespace ClimbingGym.Controllers
{
    public class HomeController : Controller
    {
        //IClimbingGymData db;        

        //public HomeController(IClimbingGymData db)
        //{
        //    this.db = db;
        //}

        //access in memory data
        public ActionResult Index()
        {
            //var model = db.GetAll();
            //return View(model);

            var dataContext = new ClimbingGymDbContext();
            var climbingGyms = from gym in dataContext.Gyms select gym;

            return View(climbingGyms);
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