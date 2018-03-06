using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VSBoard.Views
{
    public partial class Projects : UserControl
    {
        public Projects()
        {

            InitializeComponent();
            this.Dock = DockStyle.Fill;
            DrawPieChart(3, 3, 5, 6, 6);
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DrawPieChart(int value1, int value2, int value3, int value4, int value5)
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("MyLegend");
           // chart1.Legends[0].LegendStyle = LegendStyle.Table;
            //chart1.Legends[0].Docking = DockStyle.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "MANHOURS METER";
            chart1.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart1.Series[seriesname].ChartType = SeriesChartType.Doughnut;

            //Add some datapoints so the series. in this case you can pass the values to this method
            chart1.Series[seriesname].Points.AddXY("CONSUMED", value1);
            chart1.Series[seriesname].Points.AddXY("REMAINING", value2);
           
        }
    }
}
