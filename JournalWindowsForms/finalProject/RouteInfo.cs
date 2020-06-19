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
    public partial class RouteInfo : Form
    {
        public RouteInfo(singleClimb climbInfo)
        {
            //set value of form labels
            InitializeComponent();
            routeData route = climbInfo.getDetails();
            lbl_attempts.Text = route.attempts.ToString();
            lbl_color.Text = route.color.ToString();
            lbl_dateClimbed.Text = route.date.ToString();
            lbl_description.Text = route.routeDesc.ToString();
            lbl_grade.Text = route.grade.ToString();
            lbl_notes.Text = route.notes.ToString();

        }
    }
}
