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
    public partial class Meta : Form
    {


        //Task wait = Task.Delay(5000);
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
      
        public Meta()
        {
            InitializeComponent();   
        }

        void saveMeta()
        {

            string sql = "update tbl_meta_conf set board_name = '" + txtBoardname.Text + "',board_desc = '" + txtBoarddesc.Text + "' where id like 3";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
           
            cm.Dispose();

        }
        void getMeta()
        {
            String sql = "Select * from tbl_meta_conf where id like 3";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                txtBoardname.Text = dr.GetValue(1).ToString();
                txtBoarddesc.Text = dr.GetValue(2).ToString();


                //  i++;
            }
            dr.Close();

        }

        private void txtBoardname_TextChanged(object sender, EventArgs e)
        {
           //saveMeta();
        }

        private void txtBoarddesc_TextChanged(object sender, EventArgs e)
        {
            //saveMeta();
        }

        private void Meta_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(connection.constring);
                cn.Open();
                getMeta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
                this.Dispose();
                this.Close();

            }
          
        }

        private void txtBoardname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //saveMeta();
        }

        private void Meta_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                saveMeta();
            }
            catch (Exception ex)
            {
                this.Close();
            }
        }
    }
}
