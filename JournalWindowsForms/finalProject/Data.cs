using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace finalProject
{
    //create data class
    class Data
    {
        //create data instance
        public static volatile Data _instance;
        
        //function to return current instance
        public static Data getInstance()
        {
            lock (typeof(Data))
            {
                if (null == _instance)
                    _instance = new Data();
            }
            return _instance;
        }

        //declare data table
        DataTable dt;

        //default constructor
        Data()
        {
            //exception handling
            try
            {
                //create data table and columns
                dt = new DataTable();
                dt.Columns.Add("date", typeof(DateTime));
                dt.Columns.Add("routeDesc", typeof(string));
                dt.Columns.Add("color", typeof(string));
                dt.Columns.Add("grade", typeof(string));
                dt.Columns.Add("attempts", typeof(int));
                dt.Columns.Add("notes", typeof(string));
            }
            //exception handling 
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //get the data table
        public DataTable getDt()
        {
            return dt;
        }        

        //get the number of rows in data table
        public int dbSize()
        {
            return dt.Rows.Count;
        }

        //add the climb to the database
        public void addClimbToDb(Climb climb)
        {
            routeData route = climb.getDetails();
            //exception handling
            try
            {
                //add row to data table
                dt.Rows.Add(route.date, route.routeDesc, route.color, route.grade, route.attempts, route.notes);
            }
            //exception handling
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }        
    }
}
