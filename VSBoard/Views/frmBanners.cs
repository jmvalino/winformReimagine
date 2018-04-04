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
using System.IO;

namespace VSBoard.Views
{
    public partial class frmBanners : Form
    {
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
       // byte[] ImagemByte;
        LinkedList<byte[]> projlist = new LinkedList<byte[]>();
        int i = 0;
        //Task wait = Task.Delay(5000);
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
        public ListViewItem list1 = new ListViewItem();


   
        public frmBanners()
        {
            InitializeComponent();

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 70;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();

            try
            {
                cn = new SqlConnection(connection.constring);
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
            }
            setDelay();
            getBanners();
            loadBanner();
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 50;   //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start(); 
        }
        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL)
            && (((int)m.WParam & 0xFFFF) == 5))
            {
                // Change SB_THUMBTRACK to SB_THUMBPOSITION
                m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.01;
        }
        void setDelay()
        {
            try
            {
                String sql = "Select delay_banners from tbl_meta_conf where id like 3";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    Ticker.Interval = Convert.ToInt32(dr.GetValue(0)) * 1000;


                    //  i++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
            }

        }
    
        void getBanners()
        {
            try
            {
                String sql = "Select * from tbl_banners";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    projlist.AddLast((byte[])dr.GetValue(2));
                    // ImagemByte = (byte[])dr.GetValue(1);


                    //  i++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
            }
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            if (i < projlist.Count)
            {
                //lblByte.Text = projlist.ElementAtOrDefault(i);
                loadBanner();
            }
            else if (i == projlist.Count)
            {
                this.Dispose();
                this.Close();
            }
          
        }
       void loadBanner()
        {

             try
                {
                    //Get image data from gridview column.
                    byte[] imageData = (byte[])projlist.ElementAtOrDefault(i);

                    //Initialize image variable
                    Image newImage;
                    //Read image data into a memory stream
                    using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                    {
                        ms.Write(imageData, 0, imageData.Length);

                        //Set image variable value using memory stream.
                        newImage = Image.FromStream(ms, true);
                    }

                    //set picture
                    pictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxBanner.Image = newImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                i++;
        }

        private void pictureBoxBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
