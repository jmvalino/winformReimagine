using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace VSBoard.Maintainance
{
    public partial class Maintain : Form
    {
        public Maintain()
        {
            InitializeComponent();
        }

        private void btnAnnoucements_Click(object sender, EventArgs e)
        {
            Views.Announcements ann = new Views.Announcements();
            ann.ShowDialog();
        }

        private void btnBanners_Click(object sender, EventArgs e)
        {
            Views.Banner ban = new Views.Banner();
            ban.ShowDialog();
        }

        private void btnMeta_Click(object sender, EventArgs e)
        {
            Views.Meta meta = new Views.Meta();
            meta.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Views.Configuration conf = new Views.Configuration();
            conf.ShowDialog();
        }

        private void llPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BoardMDI board = new BoardMDI();
            board.Show();
        }

        private void dbconfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dbConnector conf = new dbConnector();
            conf.ShowDialog();
        }

        private void Maintain_Load(object sender, EventArgs e)
        {
          
        }
    }
}
