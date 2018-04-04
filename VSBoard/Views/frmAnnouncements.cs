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
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        int delay = 0;

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
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 70;   //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start(); 
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        void setDelay()
        {
            try
            {
                String sql = "Select delay_announcements from tbl_meta_conf where id = 3";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    timerForAnn.Interval = Convert.ToInt32(dr.GetValue(0)) * 1000;


                    //  i++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
            }
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
            try
            {
                String sql = "Select a_content from tbl_Announcements where display_until > getdate()";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    annlist.AddLast(dr.GetValue(0).ToString());



                }
                dr.Close();
            }
            catch(Exception ex){
                MessageBox.Show("DB Error");
            }
        }

        private void frmAnnouncements_Load(object sender, EventArgs e)
        {
            try
            {
            cn = new SqlConnection(connection.constring);
            cn.Open();
            setDelay();
            getAnnouncements();

           
                lblAnnouncement.Text = annlist.ElementAtOrDefault(0).ToString();
            }

            catch(Exception ex)
            {
                this.Close();
            }
          
            i++;
        }
    }
}
