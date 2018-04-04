namespace VSBoard.Views
{
    partial class frmProjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjects));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel3c = new System.Windows.Forms.TableLayoutPanel();
            this.listViewMilestone = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableIcons = new System.Windows.Forms.ImageList(this.components);
            this.listViewAccomplished = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDelayed = new System.Windows.Forms.ListView();
            this.dt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ddt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewOngoing = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUpcoming = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerTicker = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProjname = new System.Windows.Forms.Label();
            this.tableLayoutPanel3c.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3c
            // 
            this.tableLayoutPanel3c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(143)))), ((int)(((byte)(254)))));
            this.tableLayoutPanel3c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3c.ColumnCount = 2;
            this.tableLayoutPanel3c.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.21975F));
            this.tableLayoutPanel3c.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.78025F));
            this.tableLayoutPanel3c.Controls.Add(this.listViewMilestone, 0, 3);
            this.tableLayoutPanel3c.Controls.Add(this.listViewAccomplished, 0, 2);
            this.tableLayoutPanel3c.Controls.Add(this.listViewDelayed, 0, 1);
            this.tableLayoutPanel3c.Controls.Add(this.listViewOngoing, 1, 1);
            this.tableLayoutPanel3c.Controls.Add(this.listViewUpcoming, 1, 2);
            this.tableLayoutPanel3c.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayoutPanel3c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3c.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3c.Name = "tableLayoutPanel3c";
            this.tableLayoutPanel3c.RowCount = 4;
            this.tableLayoutPanel3c.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.642487F));
            this.tableLayoutPanel3c.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.25389F));
            this.tableLayoutPanel3c.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3c.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3c.Size = new System.Drawing.Size(936, 772);
            this.tableLayoutPanel3c.TabIndex = 0;
            // 
            // listViewMilestone
            // 
            this.listViewMilestone.BackColor = System.Drawing.Color.White;
            this.listViewMilestone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMilestone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listViewMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMilestone.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMilestone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.listViewMilestone.GridLines = true;
            this.listViewMilestone.LargeImageList = this.tableIcons;
            this.listViewMilestone.Location = new System.Drawing.Point(3, 542);
            this.listViewMilestone.Name = "listViewMilestone";
            this.listViewMilestone.Size = new System.Drawing.Size(482, 227);
            this.listViewMilestone.SmallImageList = this.tableIcons;
            this.listViewMilestone.TabIndex = 8;
            this.listViewMilestone.UseCompatibleStateImageBehavior = false;
            this.listViewMilestone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Critical Milestones";
            this.columnHeader6.Width = 468;
            // 
            // tableIcons
            // 
            this.tableIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tableIcons.ImageStream")));
            this.tableIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.tableIcons.Images.SetKeyName(0, "milestone.png");
            // 
            // listViewAccomplished
            // 
            this.listViewAccomplished.BackColor = System.Drawing.Color.White;
            this.listViewAccomplished.BackgroundImage = global::VSBoard.Properties.Resources.ip2;
            this.listViewAccomplished.BackgroundImageTiled = true;
            this.listViewAccomplished.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAccomplished.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listViewAccomplished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAccomplished.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAccomplished.ForeColor = System.Drawing.Color.Gray;
            this.listViewAccomplished.GridLines = true;
            this.listViewAccomplished.Location = new System.Drawing.Point(3, 311);
            this.listViewAccomplished.Name = "listViewAccomplished";
            this.listViewAccomplished.Size = new System.Drawing.Size(482, 225);
            this.listViewAccomplished.TabIndex = 7;
            this.listViewAccomplished.UseCompatibleStateImageBehavior = false;
            this.listViewAccomplished.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Accomplished Tasks";
            this.columnHeader5.Width = 330;
            // 
            // listViewDelayed
            // 
            this.listViewDelayed.BackColor = System.Drawing.Color.White;
            this.listViewDelayed.BackgroundImage = global::VSBoard.Properties.Resources.ip1;
            this.listViewDelayed.BackgroundImageTiled = true;
            this.listViewDelayed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDelayed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dt,
            this.pic,
            this.sd,
            this.ddt,
            this.nt});
            this.listViewDelayed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDelayed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDelayed.ForeColor = System.Drawing.Color.Red;
            this.listViewDelayed.GridLines = true;
            this.listViewDelayed.Location = new System.Drawing.Point(3, 62);
            this.listViewDelayed.Name = "listViewDelayed";
            this.listViewDelayed.Size = new System.Drawing.Size(482, 243);
            this.listViewDelayed.TabIndex = 6;
            this.listViewDelayed.UseCompatibleStateImageBehavior = false;
            this.listViewDelayed.View = System.Windows.Forms.View.Details;
            // 
            // dt
            // 
            this.dt.Text = "Delayed Tasks";
            this.dt.Width = 267;
            // 
            // pic
            // 
            this.pic.Text = "PIC";
            // 
            // sd
            // 
            this.sd.Text = "Start Date";
            // 
            // ddt
            // 
            this.ddt.Text = "Due Date";
            // 
            // nt
            // 
            this.nt.Text = "Notes";
            // 
            // listViewOngoing
            // 
            this.listViewOngoing.BackColor = System.Drawing.Color.White;
            this.listViewOngoing.BackgroundImage = global::VSBoard.Properties.Resources.ip;
            this.listViewOngoing.BackgroundImageTiled = true;
            this.listViewOngoing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewOngoing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.ic,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewOngoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOngoing.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOngoing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listViewOngoing.GridLines = true;
            this.listViewOngoing.Location = new System.Drawing.Point(491, 62);
            this.listViewOngoing.Name = "listViewOngoing";
            this.listViewOngoing.Size = new System.Drawing.Size(442, 243);
            this.listViewOngoing.TabIndex = 4;
            this.listViewOngoing.UseCompatibleStateImageBehavior = false;
            this.listViewOngoing.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Active Tasks";
            this.columnHeader2.Width = 330;
            // 
            // ic
            // 
            this.ic.Text = "PIC";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Start Date";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Due Date";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Notes";
            // 
            // listViewUpcoming
            // 
            this.listViewUpcoming.BackColor = System.Drawing.Color.White;
            this.listViewUpcoming.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewUpcoming.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewUpcoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUpcoming.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUpcoming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.listViewUpcoming.GridLines = true;
            this.listViewUpcoming.Location = new System.Drawing.Point(491, 311);
            this.listViewUpcoming.Name = "listViewUpcoming";
            this.listViewUpcoming.Size = new System.Drawing.Size(442, 225);
            this.listViewUpcoming.TabIndex = 5;
            this.listViewUpcoming.UseCompatibleStateImageBehavior = false;
            this.listViewUpcoming.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Upcoming Tasks";
            this.columnHeader3.Width = 330;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(491, 542);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 227);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(224, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(215, 221);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chart2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedVertical;
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            this.chart2.BorderlineWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(215, 221);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // timerTicker
            // 
            this.timerTicker.Enabled = true;
            this.timerTicker.Interval = 5000;
            this.timerTicker.Tick += new System.EventHandler(this.timerTicker_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblProjname, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(936, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblProjname
            // 
            this.lblProjname.BackColor = System.Drawing.Color.Transparent;
            this.lblProjname.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProjname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProjname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(143)))), ((int)(((byte)(254)))));
            this.lblProjname.Image = global::VSBoard.Properties.Resources.database_plus;
            this.lblProjname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProjname.Location = new System.Drawing.Point(3, 0);
            this.lblProjname.Name = "lblProjname";
            this.lblProjname.Size = new System.Drawing.Size(852, 54);
            this.lblProjname.TabIndex = 0;
            this.lblProjname.Text = "     Project";
            this.lblProjname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 772);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3c);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProjects";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmProjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProjects_Load);
            this.tableLayoutPanel3c.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3c;
        private System.Windows.Forms.ListView listViewOngoing;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timerTicker;
        private System.Windows.Forms.ListView listViewMilestone;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listViewAccomplished;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listViewDelayed;
        private System.Windows.Forms.ColumnHeader dt;
        private System.Windows.Forms.ListView listViewUpcoming;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ColumnHeader pic;
        private System.Windows.Forms.ColumnHeader sd;
        private System.Windows.Forms.ColumnHeader ddt;
        private System.Windows.Forms.ColumnHeader nt;
        private System.Windows.Forms.ColumnHeader ic;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ImageList tableIcons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblProjname;
    }
}