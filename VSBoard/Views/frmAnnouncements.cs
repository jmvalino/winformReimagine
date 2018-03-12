﻿using System;
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
                // tableLayoutPanel1.Controls.Clear();
                //lblProjName.Text = "ALL LOADED";
            }
        }

        void getAnnouncements()
        {
            String sql = "Select * from tbl_Announcements";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                annlist.AddLast(dr.GetValue(1).ToString());



            }
            dr.Close();
        }
    }
}