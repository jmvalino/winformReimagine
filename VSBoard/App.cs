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
using System.Windows.Forms.Design;

namespace VSBoard
{
    public partial class App : Form
    {
        private int iScroll;
        private string strString = "Over time, most database applications grow, become more complex, and need to support more users. At some point in the life of your Microsoft Office Access application, you might want to consider upsizing to it to a Microsoft SQL Server database to optimize performance, scalability, availability, security, reliability, and recoverability.";
        int i = 0;
        public App()
        {
            InitializeComponent();
            //panelButtom.Dock = DockStyle.Fill;
            showHome();
        }
        void clearBColors()
        {
            projectsToolStripMenuItem.BackColor = Color.Transparent;
            manhoursToolStripMenuItem.BackColor = Color.Transparent;
            jToolStripMenuItem.BackColor = Color.Transparent;
        }

        private void timerTicker_Tick(object sender, EventArgs e)
        {

            i++;


            if (i == 4)
            {

                hideBar();
                showMisc();

                //  menuStripMain.Items.
                //projectsToolStripMenuItem.BackColor = Color.FromArgb(255, 232, 232);
                //this.panelHolder.Controls.Clear();
                //Views.Home home = new Views.Home();
                //home.PerformAutoScale();
                //panelHolder.Controls.Add(home);
                //tableLayoutPanelCtr.Visible = false;

            }

            if (i == 6)
            {

                //hideBar();
                showMMV();

                //  menuStripMain.Items.
                //projectsToolStripMenuItem.BackColor = Color.FromArgb(255, 232, 232);
                //this.panelHolder.Controls.Clear();
                //Views.Home home = new Views.Home();
                //home.PerformAutoScale();
                //panelHolder.Controls.Add(home);
                //tableLayoutPanelCtr.Visible = false;

            }
            if (i == 8)
            {

                showBar();
                showProjects();
                
              //  menuStripMain.Items.
                 //projectsToolStripMenuItem.BackColor = Color.FromArgb(255, 232, 232);
                //this.panelHolder.Controls.Clear();
                //Views.Home home = new Views.Home();
                //home.PerformAutoScale();
                //panelHolder.Controls.Add(home);
                //tableLayoutPanelCtr.Visible = false;

            }
            if (i == 14)
            {
                
                showMahours();
                //tableLayoutPanelCtr.Visible = true;
                //this.panelHolder.Controls.Clear();
                //Views.MMV mmv = new Views.MMV();
                //mmv.PerformAutoScale();
                //panelHolder.Controls.Add(mmv);

            }
            if (i == 21)
            {
                
                showAnnouncements();

            }
            if (i == 30)
            {
                i = 0;
                showHome();

            }

            
        }

        void showBar()
        {
            panelButtom.Show();
            panelCrawl.Show();
        }

        void hideBar()
        {
            panelButtom.Hide();
            panelCrawl.Hide();
        }
        ///uc show functions///

        void showHome()
        {

            clearBColors();
           // panelButtom.Dock = DockStyle.Bottom;
           // jToolStripMenuItem.BackColor = Color.FromArgb(244, 66, 182);
           this.panelHolder.Controls.Clear();
           Views.frmHome home = new Views.frmHome();
            home.PerformAutoScale();
            panelHolder.Controls.Add(home);

        }


        void showProjects()
        {
            clearBColors();
            projectsToolStripMenuItem.BackColor = Color.HotPink;
           this.panelHolder.Controls.Clear();
            Views.Projects proj = new Views.Projects();
            proj.PerformAutoScale();
      panelHolder.Controls.Add(proj);

        }

        void showMahours()
        {
            clearBColors();
            //manToolStripMenuItem.BackColor = Color.FromArgb(244, 66, 182);
            manhoursToolStripMenuItem.BackColor = Color.HotPink;
          this.panelHolder.Controls.Clear();
            Views.Manhours man = new Views.Manhours();
            man.PerformAutoScale();
           panelHolder.Controls.Add(man);

        }

        void showAnnouncements()
        {
            clearBColors();
            jToolStripMenuItem.BackColor = Color.HotPink;
            //annToolStripMenuItem.BackColor = Color.FromArgb(244, 66, 182);
            this.panelHolder.Controls.Clear();
            Views.Announcements ann = new Views.Announcements();
            ann.PerformAutoScale();
            panelHolder.Controls.Add(ann);

        }

        void showMisc()
        {
            
            this.panelHolder.Controls.Clear();
            Views.Misc misc = new Views.Misc();
            misc.PerformAutoScale();
            panelHolder.Controls.Add(misc);

        }


        void showMMV()
        {

            this.panelHolder.Controls.Clear();
            Views.MMV mmv = new Views.MMV();
            mmv.PerformAutoScale();
            panelHolder.Controls.Add(mmv);

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

        private void jToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showProjects();
        }

        private void lblBoardname_Click(object sender, EventArgs e)
        {
            this.Close();
            //Maintainance.Maintain mn = new Maintainance.Maintain();
            //mn.Show();
        }

        private void manToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMahours();
        }

        private void annToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAnnouncements();
        }

        private void projectsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showProjects();
        }

        private void manhoursToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showMahours();
        }

        private void jToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showAnnouncements();
        }

        private void timerForClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();

           

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            panelButtom.Hide();
            showMisc();
        }

        private void timerForCrawler_Tick(object sender, EventArgs e)
        {
            iScroll = iScroll + 1;
            int iLmt = strString.Length - iScroll;
            if (iLmt < 100)
            {
                iScroll = 0;
            }

            string str = strString.Substring(iScroll, 100);
            lblCrawl.Text = str;

        }
    }
}
