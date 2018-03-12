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
    public partial class frmHome : Form
    {
        int i = 0;
        public frmHome()
        {
            InitializeComponent();
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            
            if (i == 7) this.Close();
            i++;
        }
    }
}
