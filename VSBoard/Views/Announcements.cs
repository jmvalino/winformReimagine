using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VSBoard.Views
{
    public partial class Announcements : UserControl
    {
        int value1 = 60, value2 = 70;
        LinkedList<String> projlist = new LinkedList<String>();
        int i = 0;
        //Task wait = Task.Delay(5000);
        public OleDbCommand cm = new OleDbCommand();
        public OleDbConnection cn = new OleDbConnection();
        public OleDbDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
        public Announcements()
        {
            InitializeComponent();

            //db initialization //
            cn = new OleDbConnection(connection.constring);
            cn.Open();
            getAnnouncements();
            //setManhour(Convert.ToInt32(projlist.ElementAtOrDefault(i).ToString()));  
            this.Dock = DockStyle.Fill;

        }

        private void Announcements_Load(object sender, EventArgs e)
        {

        }

        void getAnnouncements()
        {
            String sql = "Select * from tbl_announcements";
            cm = new OleDbCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                projlist.AddLast(dr.GetValue(1).ToString());



            }
            dr.Close();
        }

        void fillAnnoucement()
        {

        }

        private void timerForAnn_Tick(object sender, EventArgs e)
        {
            if (i < projlist.Count)
            {

                //lblProjName.Text = projlist.ElementAtOrDefault(i).ToString();
                lblAnnouncement.Text = projlist.ElementAtOrDefault(i).ToString();

                i++;
            }
            else if (i == projlist.Count)
            {
               // tableLayoutPanel1.Controls.Clear();
                //lblProjName.Text = "ALL LOADED";
            }
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {

        }
    }
}
