using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace VSBoard
{
    public partial class App : Form
    {
        int i = 0;
        public App()
        {
            InitializeComponent();
        }

        private void timerTicker_Tick(object sender, EventArgs e)
        {

            i++;

           //btnTime.Text = DateTime.Now.ToShortTimeString();
            if (i == 1)
            {
                this.panelHolder.Controls.Clear();
                Views.Home home = new Views.Home();
                home.PerformAutoScale();
                panelHolder.Controls.Add(home);
                tableLayoutPanelCtr.Visible = false;

            }
            if (i == 14)
            {
                tableLayoutPanelCtr.Visible = true;
                this.panelHolder.Controls.Clear();
                Views.MMV mmv = new Views.MMV();
                mmv.PerformAutoScale();
                panelHolder.Controls.Add(mmv);

            }
            if (i == 21)
            {
                this.panelHolder.Controls.Clear();
                Views.Projects proj = new Views.Projects();
                proj.PerformAutoScale();
                panelHolder.Controls.Add(proj);

            }
            if (i == 30)
            {
                i = 0;
                return;

            }

            
        }
        ///uc show functions///

        void showProjects()
        {
            this.panelHolder.Controls.Clear();
            Views.Projects proj = new Views.Projects();
            proj.PerformAutoScale();
            panelHolder.Controls.Add(proj);

        }

        void showMahours()
        {
            this.panelHolder.Controls.Clear();
            Views.Manhours man = new Views.Manhours();
            man.PerformAutoScale();
            panelHolder.Controls.Add(man);

        }

        void showAnnouncements()
        {
            this.panelHolder.Controls.Clear();
            Views.Announcements ann = new Views.Announcements();
            ann.PerformAutoScale();
            panelHolder.Controls.Add(ann);

        }


        ///uc show functions///




        private void App_Load(object sender, EventArgs e)
        {
            
        }

        private void eventsReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAnnouncements();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showProjects();
        }

        private void manhoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMahours();
        }
    }
}
