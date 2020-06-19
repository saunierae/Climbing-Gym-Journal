using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClimbingGym.Data.Models;

namespace ClimbingGym.Data.Services
{
    public interface IClimbingGymData
    {
        //declaring methods
        IEnumerable<SingleGym> GetAll();
        SingleGym Get(int id);
        void Add(SingleGym gym);
        void Update(SingleGym gym);
        void Delete(int id);
    }
}
