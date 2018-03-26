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
    public partial class frmProjects : Form
    {
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        int ongoing ;
        int delayed ;
        int done = 0;
        int delay = 0;
        int value1 = 60, value2 = 70;
        LinkedList<String> projlist = new LinkedList<String>();
        int i = 0;
        //Task wait = Task.Delay(5000);
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        dbConnector connection = new dbConnector();

        public ListViewItem list = new ListViewItem();
        public ListViewItem listOngoing = new ListViewItem();
        public ListViewItem listDelayed = new ListViewItem();
        public ListViewItem listUpcoming = new ListViewItem();
        public ListViewItem listAccomplished = new ListViewItem();
        public ListViewItem listMilestone = new ListViewItem();


        public frmProjects()
        {
            InitializeComponent();

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 50;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start(); 

            cn = new SqlConnection(connection.constring);
            cn.Open();
            
            /// pie chart creation ///
        }
        void setDelay()
        {
            String sql = "Select delay_projects from tbl_meta_conf where id like 3";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                timerTicker.Interval = Convert.ToInt32(dr.GetValue(0)) * 1000;


                //  i++;
            }
            dr.Close();
           
        }

        private void lblProjectTitle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void setGraph(int projid)
        {
         

            listViewAccomplished.Items.Clear();
            listViewOngoing.Items.Clear();
            listViewMilestone.Items.Clear();
            listViewDelayed.Items.Clear();

            string pname = "";
            ///////////////QUERY TO SELECT PROJECT////////////////////
            String sql = "Select status,name from tbl_projects where id like " + projid + " ";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
              
                lblProjectStat.Text =  dr.GetValue(0).ToString();
               
                lblProjectTitle.Text = dr.GetValue(1).ToString();
                pname = dr.GetValue(1).ToString();

            }
            dr.Close();
            //listViewDeliverables.Items.Clear();
            listViewOngoing.Items.Clear();
           // deliverables(pname);
            OngoingTasks(pname);
            DelayedTasks(pname);
            UpcomingTasks(pname);
            MilestoneTasks(pname);
            AccomplishedTasks(pname);
            //////////GRAPH/////
            //lblStat.Text = value1.ToString();
//////////////////////////////////////////////////////////////////MAN HOURS///////////////////////////////////////////////
            int mh = 0;
            int con = 0;
            int rem = 0;
 //////////////////////////////////////////////////////////////////Total MAN HOURS///////////////////////////////////////////////
            sql = "Select manhour from tbl_projects where id = " + projid + " ";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                mh = dr.GetInt32(0);
            }
            dr.Close();
//////////////////////////////////////////////////////////////////Total task hours///////////////////////////////////////////////
            sql = "Select Manhours from tbl_scheduledtask where Project = '" +pname+ "' ";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
               con += dr.GetInt32(0);
            }
            dr.Close();

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
            chart1.Series[seriesname].Points.AddXY("CONSUMED", con);
            chart1.Series[seriesname].Points.AddXY("REMAINING", mh-con);
            /////////////////////////////////////////////////////TASKS///////////////////////////////////////////
            chart2.Series.Clear();
            chart2.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chart2.Legends.Add("MyLegend");
            // chart1.Legends[0].LegendStyle = LegendStyle.Column;
            chart2.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            chart2.Legends[0].Alignment = StringAlignment.Center;
            //chart2.Legends[0].Title = "TASK";
            // chart1.Legends[0].BorderColor = Color.;

            //Add a new chart-series
            string seriesname1 = "Number Of Task";
            chart2.Series.Add(seriesname1);
            //set the chart-type to "Pie"
            chart2.Series[seriesname1].ChartType = SeriesChartType.Bar;

            //Add some datapoints so the series. in this case you can pass the values to this method
            chart2.Series[seriesname1].Points.AddXY("DONE", done);
            chart2.Series[seriesname1].Points.AddXY("ONGOING", ongoing);
            chart2.Series[seriesname1].Points.AddXY("DELAYED", delayed);

        }

        //void deliverables(String project)
        //{
        //    String sql = "Select * from tbl_deliverables where project  = '"+ project +"'";
        //    cm = new SqlCommand(sql, cn);
        //    dr = cm.ExecuteReader();
        //    while (dr.Read())
        //    {

        //        //list = listViewDeliverables.Items.Add(dr.GetValue(1).ToString());
        //        //list.SubItems.Add(dr.GetValue(2).ToString());
        //        //list.SubItems.Add(dr.GetValue(3).ToString());


        //    }
        //    dr.Close();
        //}

       

        void OngoingTasks(String project)
        {
            ongoing = 0;
            String sql = "Select * from tbl_scheduledtask where Project  = '"+project+"' and Status = 'ON GOING'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ongoing++;
                DateTime startdate = DateTime.Parse(dr.GetValue(3).ToString());
                DateTime duedate = DateTime.Parse(dr.GetValue(4).ToString());


                listOngoing = listViewOngoing.Items.Add(dr.GetValue(1).ToString());
                listOngoing.SubItems.Add(dr.GetValue(9).ToString());
                listOngoing.SubItems.Add(startdate.ToString("dd-MMM"));
                listOngoing.SubItems.Add(duedate.ToString("dd-MMM"));
                listOngoing.SubItems.Add(dr.GetValue(8).ToString());


            }
            dr.Close();
            listViewOngoing.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewOngoing.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewOngoing.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewOngoing.Columns[3].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewOngoing.Columns[4].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void DelayedTasks(String project)
        {
            delayed = 0;
            String sql = "Select * from tbl_scheduledtask where Project  = '" + project + "' and Status = 'DELAYED'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                delayed++;
                DateTime startdate = DateTime.Parse(dr.GetValue(3).ToString());
                DateTime duedate = DateTime.Parse(dr.GetValue(4).ToString());


                listDelayed = listViewDelayed.Items.Add(dr.GetValue(1).ToString());
                listDelayed.SubItems.Add(dr.GetValue(9).ToString());
                listDelayed.SubItems.Add(startdate.ToString("dd-MMM"));
                listDelayed.SubItems.Add(duedate.ToString("dd-MMM"));
                listDelayed.SubItems.Add(dr.GetValue(8).ToString());


            }
            dr.Close();
     
            listViewDelayed.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDelayed.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDelayed.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDelayed.Columns[3].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDelayed.Columns[4].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void UpcomingTasks(String project)
        {
            String sql = "Select * from tbl_scheduledtask where Project  = '" + project + "' and Status = 'DELAYED'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                DateTime startdate = DateTime.Parse(dr.GetValue(3).ToString());
                DateTime duedate = DateTime.Parse(dr.GetValue(4).ToString());


                listUpcoming = listViewUpcoming.Items.Add(dr.GetValue(1).ToString());
                listUpcoming.SubItems.Add(dr.GetValue(9).ToString());
                listUpcoming.SubItems.Add(startdate.ToString("dd-MMM"));
                listUpcoming.SubItems.Add(duedate.ToString("dd-MMM"));
                listUpcoming.SubItems.Add(dr.GetValue(8).ToString());


            }
            dr.Close();
        }
        void AccomplishedTasks(String project)
        {
            done=0;
            String sql = "Select * from tbl_scheduledtask where Project  = '" + project + "' and Status = 'DONE'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                done++;
                DateTime startdate = DateTime.Parse(dr.GetValue(3).ToString());
                DateTime duedate = DateTime.Parse(dr.GetValue(4).ToString());


                listAccomplished = listViewAccomplished.Items.Add(dr.GetValue(1).ToString());
                listAccomplished.SubItems.Add(dr.GetValue(9).ToString());
                listAccomplished.SubItems.Add(startdate.ToString("dd-MMM"));
                listAccomplished.SubItems.Add(duedate.ToString("dd-MMM"));
                listAccomplished.SubItems.Add(dr.GetValue(8).ToString());


            }
            dr.Close();
        }
        void MilestoneTasks(String project)
        {
            String sql = "Select * from tbl_scheduledtask where Project  = '" + project + "' and Importance = 'HIGH'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                DateTime startdate = DateTime.Parse(dr.GetValue(3).ToString());
                DateTime duedate = DateTime.Parse(dr.GetValue(4).ToString());


                listMilestone = listViewMilestone.Items.Add(dr.GetValue(1).ToString());
                listMilestone.SubItems.Add(dr.GetValue(9).ToString());
                listMilestone.SubItems.Add(startdate.ToString("dd-MMM"));
                listMilestone.SubItems.Add(duedate.ToString("dd-MMM"));
                listMilestone.SubItems.Add(dr.GetValue(8).ToString());


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
            String sql = "Select id from tbl_projects";
            cm = new SqlCommand(sql, cn);
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
                setGraph(Convert.ToInt32(projlist.ElementAtOrDefault(i).ToString()));

                i++;
            }
            else if (i == projlist.Count)
            {
                //App app = new App();
               // app.Show();
               // this.Hide();
                this.Dispose();
                this.Close();
                //Views.Home home = new Views.Home();
                //home.ShowDialog();
              
                // tableLayoutPanel1.Controls.Clear();
                //lblProjName.Text = "ALL LOADED";
            }
        }

       
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void frmProjects_Load(object sender, EventArgs e)
        {
            setDelay();


            getProjects();
            timerTicker.Start();
            setGraph(Convert.ToInt32(projlist.ElementAtOrDefault(0).ToString()));
            i++;
            
        }
    }
}
