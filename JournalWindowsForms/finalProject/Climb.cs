using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    //Declare Struct for route data
    public struct routeData
    {
        public DateTime date;
        public string grade;
        public int attempts;
        public string routeDesc, color, notes;
    }

    //declare interface for route
    public interface Route
    {
        void showInfo();
        void assignInfo(routeData data);
    }

    //abstract class for climb
    public abstract class Climb
    {
        public abstract routeData getDetails();
    }

    //delcaring single climb
    public class singleClimb : Climb, Route
    {
        routeData details;
        
        // create new route data for climb
        public singleClimb()
        {
            details = new routeData();
        }

        //get route info
        public override routeData getDetails()
        {
            return details;
        }

        //moved to view climb shows route info.
        public void showInfo()
        {
            throw new NotImplementedException();
        }
        public void assignInfo(routeData data)
        {
            details.attempts = data.attempts;
            details.color = data.color;
            details.date = data.date;
            details.grade = data.grade;
            details.notes = data.notes;
            details.routeDesc = data.routeDesc;
        }
    }

    //Declare Milti pitch class
    public class multiPitch : Climb, Route
    {
        List<routeData> details = new List<routeData>();

        //get details
        public override routeData getDetails()
        {
            throw new NotImplementedException();
        }

        //add details
        public void assignInfo(routeData data)
        {
            details.Add(data);
        }

        //show details
        public void showInfo()
        {
            throw new NotImplementedException();
        }
    }
}
