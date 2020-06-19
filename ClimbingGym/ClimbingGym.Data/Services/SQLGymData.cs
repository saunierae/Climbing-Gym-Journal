using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClimbingGym.Data.Models;

namespace ClimbingGym.Data.Services
{
    public class SQLGymData : IClimbingGymData
    {
        private readonly ClimbingGymDbContext db;

        //creating instance of database 
        public SQLGymData(ClimbingGymDbContext db)
        {
            this.db = db;
        }

        // add to database
        public void Add(SingleGym gym)
        {
            db.Gyms.Add(gym);
            db.SaveChanges();
        }

        //delete from database by id
        public void Delete(int id)
        {
            var gym = db.Gyms.Find(id);
            db.Gyms.Remove(gym);
            db.SaveChanges();
        }

        // pull info from database by id
        public SingleGym Get(int id)
        {
            return db.Gyms.FirstOrDefault(g => g.GymId == id);
        }

        //get all gyms and order by name
        public IEnumerable<SingleGym> GetAll()
        {
            return from g in db.Gyms
                   orderby g.Name
                   select g;
        }

        //update gym entry
        public void Update(SingleGym gym)
        {
            var entry = db.Entry(gym);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
