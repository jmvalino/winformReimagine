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
    public partial class Announcements : Form
    {
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
        public Announcements()
        {
            InitializeComponent();
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addAnnouncement();
        }

        void getAnnouncement()
        {
            disabled();
            String sql = "Select * from tbl_Announcements";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                list = listViewAnnouncements.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());


            }
            dr.Close();

        }

        void addAnnouncement()
        {
            if (txtTitle.Text == "" || txtContent.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "select * from tbl_Announcements where title like '" + txtTitle.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("The " + txtTitle.Text + " is already added to Announcements", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    dr.Close();
                    return;
                }
                dr.Close();

          
                sql = "insert into tbl_Announcements(title,a_content,display_until) values('" + txtTitle.Text + "','" + txtContent.Text + "','" + dtpDU.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Announcement Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listViewAnnouncements.Items.Clear();
                cm.Dispose();
            }
            listViewAnnouncements.Items.Clear();
            getAnnouncement();
        }

        void updateAnnouncement(int id)
        {
            if (txtTitle.Text == "" || txtContent.Text == "")
            {
                MessageBox.Show("Please input the empty fields", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                

                string sql = "update tbl_Announcements set title = '" + txtTitle.Text + "',display_until = '"+dtpDU.Text+"',a_content = '" + txtContent.Text + "' where id like '" + id+ "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Announcement successfully updated", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cm.Dispose();
                listViewAnnouncements.Items.Clear();
                getAnnouncement();
            }

        }


        void deleteAnnouncement(int id)
        {

            string sql = "delete from tbl_Announcements where id like '" + id + "'";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Announcement successfully deleted", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cm.Dispose();
            listViewAnnouncements.Items.Clear();
            getAnnouncement();
        }

        private void listViewAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabled();
            lblID.Text = listViewAnnouncements.FocusedItem.Text;
           txtTitle.Text = listViewAnnouncements.FocusedItem.SubItems[1].Text;
           txtContent.Text = listViewAnnouncements.FocusedItem.SubItems[2].Text;
           dtpDU.Text = listViewAnnouncements.FocusedItem.SubItems[3].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteAnnouncement(Convert.ToInt32(lblID.Text));
        }

        private void Announcements_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(connection.constring);
                cn.Open();
                getAnnouncement();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error");
                this.Dispose();
                this.Close();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateAnnouncement(Convert.ToInt32(lblID.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtTitle.Text = "";
            txtContent.Text = "";

            disabled();
        }
        void enabled()
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        void disabled()
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
    }
}
