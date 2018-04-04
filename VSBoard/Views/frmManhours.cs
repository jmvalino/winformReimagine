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
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();

        int i = 0;
        int delay = 0;
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
        public ListViewItem list1 = new ListViewItem();
        public frmManhours()
        {
            InitializeComponent();
          
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 70;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start(); 
            cn = new SqlConnection(connection.constring);
            cn.Open();
            setDelay();
           activemanhours();
           inactivemanhours();
        }
        void setDelay()
        {
            try
            {
                String sql = "Select delay_manhours from tbl_meta_conf where id = 3";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    delay = Convert.ToInt32(dr.GetValue(0));


                    //  i++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
            }
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        void activemanhours()
        {
            try
            {
                String sql = "Select * from tbl_scheduledtask where Status = 'ON GOING'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    //myImageList = new ImageList();
                    //using (Icon myIcon = new Icon("online.ico"))
                    //{
                    //    myImageList.Images.Add(myIcon);
                    //}

                    //listViewManhours.Items.;

                    //list.Group = listViewManhours.Groups[1];
                    //listViewManhours.Items.add

                    list = listViewManhoursActive.Items.Add(dr.GetValue(9).ToString());
                    list.SubItems.Add(dr.GetValue(1).ToString());
                    list.SubItems.Add(dr.GetValue(10).ToString());
                    list.ImageIndex = 0;

                }

                //while (dr.Read())
                //{
                //    listViewManhoursActive.Items[i].Group = listViewManhoursActive.Groups[1];
                //    i++;
                //}
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
            }
        }
        void inactivemanhours()
        {
            //try
            //{
            //    String sql = "Select * from tbl_scheduledtask where Status like 'PAUSED'";
            //    cm = new SqlCommand(sql, cn);
            //    dr = cm.ExecuteReader();
            //    int i = 0;
            //    while (dr.Read())
            //    {
            //        //myImageList = new ImageList();
            //        //using (Icon myIcon = new Icon("offline.ico"))
            //        //{
            //        //    myImageList.Images.Add(myIcon);
            //        //}

            //        //listViewManhours.Items.;

            //        //list.Group = listViewManhours.Groups[1];
            //        //listViewManhours.Items.add
            //        list = listViewManhoursInactive.Items.Add(dr.GetValue(9).ToString());
            //        list.SubItems.Add(dr.GetValue(1).ToString());
            //        list.SubItems.Add(dr.GetValue(10).ToString());
            //        list.ImageIndex = 1;

            //    }
            //    //while (dr.Read())
            //    //{
            //    //    listViewManhoursInactive.Items[i].Group = listViewManhoursInactive.Groups[0];
            //    //    i++;

            //    //}
            //    dr.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("DB Error");
            //}
        }
        private void Ticker_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == delay)
            {
                this.Dispose();
                this.Close();

                //Views.frmProjects proj = new Views.frmProjects();
                //proj.ShowDialog();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
