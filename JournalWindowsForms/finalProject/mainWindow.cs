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
      

    public partial class mainWindow : Form
    {
        Data climbDb = Data.getInstance();
        private BindingSource BSource = new BindingSource();

        public mainWindow()
        {
            InitializeComponent();
            BSource.DataSource = climbDb;
        }

        private void btn_addClimb_Click(object sender, EventArgs e)
        {
            addClimb addClimb = new addClimb();            
            addClimb.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            ViewClimbs viewClimbs = new ViewClimbs();
            viewClimbs.Show();
        }
    }
    
}
