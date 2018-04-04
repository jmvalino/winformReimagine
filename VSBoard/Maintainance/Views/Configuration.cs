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
namespace VSBoard.Maintainance.Views
{
    public partial class Configuration : Form
    {

        LinkedList<String> annlist = new LinkedList<String>();
        int i = 0;
        //Task wait = Task.Delay(5000);
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
        int imageID = 0;
        int rowg = 0;
        public Configuration()
        {
            InitializeComponent();
            try
            {
                cn = new SqlConnection(connection.constring);
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error" +ex);
                return;
            }
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            getDelay();
        }

        void setDelay()
        {
            try
            {
                string sql = "update tbl_meta_conf set delay_home = '" + numericUpDownHome.Value + "',delay_projects = '" + numericUpDownProject.Value + "',delay_manhours = '" + numericUpDownManhours.Value + "',delay_banners = '" + numericUpDownBanner.Value + "',delay_announcements = '" + numericUpDownAnnouncements.Value + "' where id = 3";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();

                cm.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error" +ex);
                return;
            }
        }

        void getDelay()
        {
            try
            {
                String sql = "Select delay_home,delay_projects,delay_manhours,delay_banners,delay_announcements from tbl_meta_conf where id like 3";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    numericUpDownHome.Value = Convert.ToInt32(dr.GetValue(0));
                    numericUpDownProject.Value = Convert.ToInt32(dr.GetValue(1));
                    numericUpDownManhours.Value = Convert.ToInt32(dr.GetValue(2));
                    numericUpDownBanner.Value = Convert.ToInt32(dr.GetValue(3));
                    numericUpDownAnnouncements.Value = Convert.ToInt32(dr.GetValue(4));


                    //  i++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error" +ex);
                return;
            }
        }

        private void Configuration_FormClosing(object sender, FormClosingEventArgs e)
        {
            setDelay();
        }
    }
}
