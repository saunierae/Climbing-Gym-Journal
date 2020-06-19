using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClimbingGym.Data.Models;

namespace ClimbingGym.Data.Services
{
    public class InMemoryClimbingGymData : IClimbingGymData
    {
        //create list of gyms
        List<SingleGym> gyms;

        public InMemoryClimbingGymData()
        {
            gyms = new List<SingleGym>()
            {  
                //hard code gym values for testing
                new SingleGym { GymId = 1, Name = "Stone Gardens", Type = GymType.All},
                new SingleGym { GymId = 2, Name = "Vertical World", Type = GymType.All},
                new SingleGym { GymId = 3, Name = "Momentum", Type = GymType.Bouldering},
            };
        }

        // add 
        public void Add(SingleGym gym)
        {
            gyms.Add(gym);
            gym.GymId = gyms.Max(g => g.GymId) + 1;
        }

        // update
        public void Update(SingleGym gym)
        {
            var existing = Get(gym.GymId);
            if(existing != null)
            {
                existing.Name = gym.Name;
                existing.Type = gym.Type;
            }
        }

        // get gym by id
        public SingleGym Get(int id)
        {
            return gyms.FirstOrDefault(g => g.GymId == id);
        }

        // get gyms and order by name
        public IEnumerable<SingleGym> GetAll()
        {
            return gyms.OrderBy(g => g.Name);
        }

        // delete gym by id if it is not null
        public void Delete(int id)
        {
            var gym = Get(id);
            if(gym != null)
            {
                gyms.Remove(gym);
            }
        }

    }
}
