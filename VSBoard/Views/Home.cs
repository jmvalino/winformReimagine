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
    public partial class Home : Form
    {
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        int i = 0;
        int delay = 0;
        public Home()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
            setDelay();
            lblTime.Text = DateTime.Now.ToLocalTime().ToShortTimeString();
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 50;   //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start(); 
        }
        void setDelay()
        {
            String sql = "Select delay_home from tbl_meta_conf where id like 3";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

              delay = Convert.ToInt32(dr.GetValue(0));
               

                //  i++;
            }
            dr.Close();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            i++;
            if(i>=delay)
            {
               this.Dispose();
                this.Close();
            
            //Views.frmProjects proj = new Views.frmProjects();
            //proj.ShowDialog();
            
            }
        }

    

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            //BoardMDI.ActiveForm.Close();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            BoardMDI.varcontinue = false;
           /// System.Environment.Exit(10);
            //this.ParentForm.Close();
            this.Close();
           
        }

        public bool exitBoard(string test)
        {
            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadMeta();
        }
        void loadMeta()
        {
            try
            {
                String sql = "Select board_name,board_desc from tbl_meta_conf where id = 3 ";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    lblBoardName.Text = dr.GetValue(0).ToString();

                  lblDesc.Text = dr.GetValue(1).ToString();
                   

                }
                dr.Close();
            }
            catch(Exception ex){
                MessageBox.Show("No Connection");

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
