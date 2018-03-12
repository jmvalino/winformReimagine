using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace VSBoard.Views
{
    public partial class frmProjects : Form
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
        public ListViewItem list1 = new ListViewItem();

        public frmProjects()
        {
            InitializeComponent();
            cn = new OleDbConnection(connection.constring);
            cn.Open();
            getProjects();
            setManhour(Convert.ToInt32(projlist.ElementAtOrDefault(0).ToString()));
            /// pie chart creation ///
        }

        private void lblProjectTitle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void setManhour(int projid)
        {

            string pname = "";
            ///////////////QUERY TO SELECT PROJECT////////////////////
            String sql = "Select * from tbl_projects where id = " + projid + " ";
            cm = new OleDbCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                lblProjectStat.Text = dr.GetValue(6).ToString();
                value1 = Convert.ToInt32(dr.GetValue(4).ToString());
                value2 = Convert.ToInt32(dr.GetValue(5).ToString());
                //value2 = Convert.ToInt32(dr.GetValue(5).ToString());
                lblProjectTitle.Text = dr.GetValue(1).ToString() +" Development";
                pname = dr.GetValue(1).ToString();

            }
            dr.Close();
            listViewDeliverables.Items.Clear();
            listViewTasks.Items.Clear();
            deliverables(pname);
            Tasks(pname);

            //////////GRAPH/////
            //lblStat.Text = value1.ToString();

            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("MyLegend");
           // chart1.Legends[0].LegendStyle = LegendStyle.Column;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "MANHOURS METER";
            // chart1.Legends[0].BorderColor = Color.;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;

            //Add some datapoints so the series. in this case you can pass the values to this method
            chart1.Series[seriesname].Points.AddXY("CONSUMED", value1);
            chart1.Series[seriesname].Points.AddXY("REMAINING", value2);

        }

        void deliverables(String project)
        {
            String sql = "Select * from tbl_deliverables where project  like'" + project + "'";
            cm = new OleDbCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                list = listViewDeliverables.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());


            }
            dr.Close();
        }

        void Tasks(String project)
        {
            String sql = "Select * from tbl_tasks where project  like'" + project + "'";
            cm = new OleDbCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                list1 = listViewTasks.Items.Add(dr.GetValue(2).ToString());
                //list.SubItems.Add(dr.GetValue(2).ToString());
                //list.SubItems.Add(dr.GetValue(3).ToString());


            }
            dr.Close();
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

        void getProjects()
        {
            String sql = "Select * from tbl_projects";
            cm = new OleDbCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                projlist.AddLast(dr.GetValue(0).ToString());



            }
            dr.Close();

        }

        private void timerTicker_Tick(object sender, EventArgs e)
        {

            if (i < projlist.Count)
            {

                //lblProjName.Text = projlist.ElementAtOrDefault(i).ToString();
                setManhour(Convert.ToInt32(projlist.ElementAtOrDefault(i).ToString()));

                i++;
            }
            else if (i == projlist.Count)
            {
                //App app = new App();
               // app.Show();
               // this.Hide();
                this.Close();
                this.Dispose();
                // tableLayoutPanel1.Controls.Clear();
                //lblProjName.Text = "ALL LOADED";
            }
        }

        private void lblProjectStat_Click(object sender, EventArgs e)
        {
            frmManhours nm = new frmManhours();
            nm.Show();
           // this.Close();
        }
    }
}
