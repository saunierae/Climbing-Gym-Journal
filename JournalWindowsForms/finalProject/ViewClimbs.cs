using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace finalProject
{
    public partial class ViewClimbs : Form
    {
        Data climbDb = Data.getInstance();        

        //view climbs
        public ViewClimbs()
        {
            // this is windows from project
            InitializeComponent();

            //clear the data grid if there is content
            dataGrid_climbs.Columns.Clear();
            dataGrid_climbs.Rows.Clear();
            
            //get data table from database
            dataGrid_climbs.DataSource = climbDb.getDt();
        }

        //take in form inputs and popluate grid content
        private void dataGrid_climbs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = climbDb.getDt();
            DataRow dr = dt.Rows[e.RowIndex];
            routeData route = new routeData();

            //exception handling
            try
            {
                //collect information from the form
                route.attempts = Convert.ToInt32(dr["attempts"]);
                route.color = dr["color"].ToString();
                route.date = Convert.ToDateTime(dr["date"].ToString());
                route.grade = dr["grade"].ToString();
                route.notes = dr["notes"].ToString();
                route.routeDesc = dr["routeDesc"].ToString();

                //create new climb
                singleClimb climb = new singleClimb();
                //assign form data to climb
                climb.assignInfo(route);

                //create new route
                RouteInfo routeInfo = new RouteInfo(climb);
                //show route
                routeInfo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
