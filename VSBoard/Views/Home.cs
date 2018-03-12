using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSBoard.Views
{
    public partial class Home : Form
    {
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();

        int i = 0;
        public Home()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToLocalTime().ToShortTimeString();
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 50;   //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start(); 
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            i++;
            if(i==7)
            {
                this.Dispose();
                this.Close();
            
            //Views.frmProjects proj = new Views.frmProjects();
            //proj.ShowDialog();
            
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(10);
        }
    }
}
