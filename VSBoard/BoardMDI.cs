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
    public partial class BoardMDI : Form
    {
        public BoardMDI()
        {
            InitializeComponent();
        }

        void showHome()
        {
            Views.frmHome hm = new Views.frmHome();
            hm.ShowDialog();
        }

        void showProjects()
        {
            Views.frmProjects proj = new Views.frmProjects();
            proj.ShowDialog();
        }
        void showManhours()
        {
            Views.frmManhours man = new Views.frmManhours();
            man.ShowDialog();
        }

        private void BoardMDI_Load(object sender, EventArgs e)
        {
            while(true)
            {
                showHome();
                showProjects();
                showManhours();
            }
        }
        
    }
}
