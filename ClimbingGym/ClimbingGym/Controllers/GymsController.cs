using ClimbingGym.Data.Models;
using ClimbingGym.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClimbingGym.Controllers
{
    public class GymsController : Controller
    {
        private GymDBDataContext dataContext;

        public GymsController()
        {
            dataContext = new GymDBDataContext();
        }

        // GET: Gym
        public ActionResult Index()
        {
            IList<SingleGym> gymList = new List<SingleGym>();

            var climbingGyms = from gym in dataContext.Gyms select gym;

            var gyms = climbingGyms.ToList();

            foreach(var gym in gyms)
            {
                gymList.Add(new SingleGym()
                {
                    GymId = gym.GymID,
                    Name = gym.Name,
                    Type = (GymType)gym.Type
                });
            }

            return View(gymList);
        }

        // GET: Gym/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gym/Create
        public ActionResult Create()
        {
            SingleGym newGym = new SingleGym();

            return View(newGym);
        }

        // POST: Gym/Create
        [HttpPost]
        public ActionResult Create(SingleGym model)
        {
            try
            {
                Gym newGym = new Gym()
                {
                    Name = model.Name,
                    Type = (int)model.Type
                };

                dataContext.Gyms.InsertOnSubmit(newGym);
                dataContext.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View(model);
            }
        }

        // GET: Gym/Edit/5
        public ActionResult Edit(int id)
        {
            SingleGym gym = dataContext.Gyms.Where(x => x.GymID == id).Select(x =>
            new SingleGym()
            {
                GymId = x.GymID,
                Name = x.Name,
                Type = (GymType)x.Type
            }).SingleOrDefault();

            return View(gym);
        }

        // POST: Gym/Edit/5
        [HttpPost]
        public ActionResult Edit(SingleGym model)
        {
            try
            {
                string tempString = model.Name.Replace(" ", String.Empty);
                if (tempString == String.Empty)
                {                    
                    throw new System.ArgumentException("Name cannot be blank", "NameField");
                }
                Gym selectGym = dataContext.Gyms.Where(x => x.GymID == model.GymId).Single<Gym>();
                selectGym.Name = model.Name;
                selectGym.Type = (int)model.Type;

                dataContext.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Gym/Delete/5
        public ActionResult Delete(int id)
        {
            SingleGym gym = dataContext.Gyms.Where(x => x.GymID == id).Select(x =>
            new SingleGym()
            {
                GymId = x.GymID,
                Name = x.Name,
                Type = (GymType)x.Type
            }).SingleOrDefault();


            return View(gym);
        }

        // POST: Gym/Delete/5
        [HttpPost]
        public ActionResult Delete(SingleGym model)
        {
            try
            {
                Gym selectGym = dataContext.Gyms.Where(x => x.GymID == model.GymId).Single<Gym>();
                dataContext.Gyms.DeleteOnSubmit(selectGym);

                dataContext.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View(model);
            }
        }
    }
}
