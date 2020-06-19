using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class addClimb : Form
    {
        //get global database 
        Data climbDb = Data.getInstance();

        // windows form initialization 
        public addClimb()
        {
            InitializeComponent();
        }

        // save the climb on click
        private void saveClimb_Click(object sender, EventArgs e)
        {
            //create a new climb
            singleClimb climb = new singleClimb();
            routeData route;
            bool saveCheck = false;

            //Error Handling
            // Try to parse the attemps value, if it's not a number don't save the climb
            if (Int32.TryParse(txtBox_attempts.Text, out route.attempts))
            {
                saveCheck = true;
            }
            route.color = txtBox_color.Text;
            route.date = dateTimePicker_addClimb.Value;
            //if (float.TryParse(txtBox_grade.Text, out route.grade)) { }
            route.grade = txtBox_grade.Text;
            route.notes = rTxtBox_notes.Text;
            route.routeDesc = txtBox_routeDesc.Text;

            //if save is true save add the climb to the database
            if (saveCheck)
            {
    
                climb.assignInfo(route);
                climbDb.addClimbToDb(climb);
                //create new route info 
                RouteInfo routeInfo = new RouteInfo(climb);
                routeInfo.Show();
                this.Close();
            }
            //if the save is false create error message
            else
            {
                MessageBox.Show("Attempts value needs to be a whole number");
            }
            
        }
    }
}
