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
    public partial class Deliverables : Form
    {
        int value1 = 60, value2 = 70;
        LinkedList<String> projlist = new LinkedList<String>();
        int i = 0;
        //Task wait = Task.Delay(5000);
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
        public ListViewItem list1 = new ListViewItem();
        public Deliverables()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
            deliverables();
        }

        private void Deliverables_Load(object sender, EventArgs e)
        {

        }

        void deliverables()
        {
            String sql = "Select * from tbl_deliverables";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                list = listViewDeliverables.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());


            }
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //String sql = "INSERT INTO `tbl_deliverables` (`title`, `date`, `project`) VALUES ('"+t+"', 'rrrrrrrrrr', 'rrrrrrrrrrrrr', '0')";
            //cm = new SqlCommand(sql, cn);
            //cm.ExecuteNonQuery();
        }


    }
}
