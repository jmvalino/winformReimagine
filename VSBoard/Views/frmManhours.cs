using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace VSBoard.Views
{
    public partial class frmManhours : Form
    {
        int i = 0;
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
        public ListViewItem list1 = new ListViewItem();
        public frmManhours()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();

            activemanhours();
        }

        void activemanhours()
        {
            String sql = "Select * from tbl_scheduledtask where Status like 'PAUSED'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                list = listViewManhours.Items.Add(dr.GetValue(9).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(10).ToString());


            }
            dr.Close();
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 7)
            {
                this.Dispose();
                this.Close();

                //Views.frmProjects proj = new Views.frmProjects();
                //proj.ShowDialog();

            }
        }
    }
}
