using ClimbingGym.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimbingGym.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<SingleGym> Gyms { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}