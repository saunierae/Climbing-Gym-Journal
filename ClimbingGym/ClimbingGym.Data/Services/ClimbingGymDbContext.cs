using ClimbingGym.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingGym.Data.Services
{
    public class ClimbingGymDbContext: DbContext
    {
        //Getter and Setter for gyms
        public DbSet<SingleGym> Gyms { get; set; }
    }
}
