using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Startup_Grab_Focus
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        

        private void btnTrigger_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void Exec_Load(object sender, EventArgs e)
        {
         //   msTop.Items.b
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.StartPosition = FormStartPosition.CenterParent;
            about.ShowDialog();
            //myPanel1.Controls.Add(userControl1)
            //tsmiHelp.Font = new Font(tsmiHelp.Font, FontStyle.Bold); ;
            //this.panelViewContainer.Controls.Clear();
            //ucHelp help_view = new ucHelp();
            //panelViewContainer.Controls.Add(help_view);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.panelViewContainer.Controls.Clear();
            ucHome home_view = new ucHome();
            home_view.PerformAutoScale();
            panelViewContainer.Controls.Add(home_view);
           // home_view.Dispose();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
