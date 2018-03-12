using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSBoard
{
    public partial class MainAPP : Form
    {
        public MainAPP()
        {
            InitializeComponent();
        }

        private void timerWorker_Tick(object sender, EventArgs e)
        {
            Views.frmProjects proj = new Views.frmProjects();
            proj.Show();
        }
    }
}
