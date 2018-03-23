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

namespace VSBoard.Views
{
    public partial class frmAnnouncements : Form
    {
        LinkedList<String> annlist = new LinkedList<String>();
        int i = 0;
        //Task wait = Task.Delay(5000);
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
  
        public frmAnnouncements()
        {
            InitializeComponent();         
        }
        void setDelay()
        {
            String sql = "Select delay_announcements from tbl_meta_conf where id like 3";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                timerForAnn.Interval = Convert.ToInt32(dr.GetValue(0)) * 1000;


                //  i++;
            }
            dr.Close();

        }

        private void timerForAnn_Tick(object sender, EventArgs e)
        {
            if (i < annlist.Count)
            {

                //lblProjName.Text = projlist.ElementAtOrDefault(i).ToString();
                lblAnnouncement.Text = annlist.ElementAtOrDefault(i).ToString();

                i++;
            }
            else if (i == annlist.Count)
            {
                this.Dispose();
                this.Close();
                //tableLayoutPanel1.Controls.Clear();
                //lblProjName.Text = "ALL LOADED";
            }
        }

        void getAnnouncements()
        {
            String sql = "Select a_content from tbl_Announcements where display_until >= CAST(CURRENT_TIMESTAMP AS DATETIME)";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                annlist.AddLast(dr.GetValue(0).ToString());



            }
            dr.Close();
        }

        private void frmAnnouncements_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connection.constring);
            cn.Open();
            setDelay();
            getAnnouncements();
            try
            {
                lblAnnouncement.Text = annlist.ElementAtOrDefault(0).ToString();
            }
            catch
            {
                this.Close();
            }
            i++;
        }
    }
}
