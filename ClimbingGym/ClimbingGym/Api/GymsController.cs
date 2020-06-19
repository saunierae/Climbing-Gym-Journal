using ClimbingGym.Data.Models;
using ClimbingGym.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace ClimbingGym.Api
{
    //creating controller and initiating database
    public class GymsController: Controller
    {
        private readonly IClimbingGymData db;

        public GymsController(IClimbingGymData db)
        {
            this.db = db;
        }

        public IEnumerable<SingleGym> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}