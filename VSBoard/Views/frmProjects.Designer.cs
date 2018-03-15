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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel3c = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProjectStat = new System.Windows.Forms.Label();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDeliverables = new System.Windows.Forms.ListView();
            this.d = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerTicker = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2c = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3c.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2c.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3c
            // 
            this.tableLayoutPanel3c.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3c.ColumnCount = 3;
            this.tableLayoutPanel3c.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.30973F));
            this.tableLayoutPanel3c.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.47788F));
            this.tableLayoutPanel3c.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.21239F));
            this.tableLayoutPanel3c.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel3c.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3c.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel3c.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3c.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3c.Name = "tableLayoutPanel3c";
            this.tableLayoutPanel3c.RowCount = 1;
            this.tableLayoutPanel3c.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3c.Size = new System.Drawing.Size(936, 350);
            this.tableLayoutPanel3c.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(314, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(279, 344);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblProjectTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 344);
            this.panel1.TabIndex = 3;
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblProjectTitle.Location = new System.Drawing.Point(-13, 124);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(355, 176);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.Text = "#ProjectName";
            this.lblProjectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProjectTitle.Click += new System.EventHandler(this.lblProjectTitle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.lblProjectStat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(599, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 344);
            this.panel2.TabIndex = 4;
            // 
            // lblProjectStat
            // 
            this.lblProjectStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProjectStat.BackColor = System.Drawing.Color.OrangeRed;
            this.lblProjectStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectStat.ForeColor = System.Drawing.Color.White;
            this.lblProjectStat.Location = new System.Drawing.Point(0, 92);
            this.lblProjectStat.Name = "lblProjectStat";
            this.lblProjectStat.Size = new System.Drawing.Size(331, 176);
            this.lblProjectStat.TabIndex = 1;
            this.lblProjectStat.Text = "#ProjectStat";
            this.lblProjectStat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listViewTasks
            // 
            this.listViewTasks.BackColor = System.Drawing.Color.White;
            this.listViewTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTasks.ForeColor = System.Drawing.Color.OrangeRed;
            this.listViewTasks.GridLines = true;
            this.listViewTasks.Location = new System.Drawing.Point(599, 3);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(334, 416);
            this.listViewTasks.TabIndex = 4;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Active Tasks";
            this.columnHeader2.Width = 330;
            // 
            // listViewDeliverables
            // 
            this.listViewDeliverables.BackColor = System.Drawing.Color.White;
            this.listViewDeliverables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDeliverables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.d,
            this.columnHeader1});
            this.listViewDeliverables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDeliverables.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDeliverables.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listViewDeliverables.GridLines = true;
            this.listViewDeliverables.Location = new System.Drawing.Point(3, 3);
            this.listViewDeliverables.Name = "listViewDeliverables";
            this.listViewDeliverables.Size = new System.Drawing.Size(590, 416);
            this.listViewDeliverables.TabIndex = 3;
            this.listViewDeliverables.UseCompatibleStateImageBehavior = false;
            this.listViewDeliverables.View = System.Windows.Forms.View.Details;
            // 
            // d
            // 
            this.d.Text = "Deliverables";
            this.d.Width = 428;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 313;
            // 
            // timerTicker
            // 
            this.timerTicker.Enabled = true;
            this.timerTicker.Interval = 5000;
            this.timerTicker.Tick += new System.EventHandler(this.timerTicker_Tick);
            // 
            // tableLayoutPanel2c
            // 
            this.tableLayoutPanel2c.ColumnCount = 2;
            this.tableLayoutPanel2c.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.76196F));
            this.tableLayoutPanel2c.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.23804F));
            this.tableLayoutPanel2c.Controls.Add(this.listViewDeliverables, 0, 0);
            this.tableLayoutPanel2c.Controls.Add(this.listViewTasks, 1, 0);
            this.tableLayoutPanel2c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2c.Location = new System.Drawing.Point(0, 350);
            this.tableLayoutPanel2c.Name = "tableLayoutPanel2c";
            this.tableLayoutPanel2c.RowCount = 1;
            this.tableLayoutPanel2c.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2c.Size = new System.Drawing.Size(936, 422);
            this.tableLayoutPanel2c.TabIndex = 1;
            // 
            // frmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::VSBoard.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(936, 772);
            this.Controls.Add(this.tableLayoutPanel2c);
            this.Controls.Add(this.tableLayoutPanel3c);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProjects";
            this.Text = "frmProjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel3c.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2c.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3c;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView listViewDeliverables;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader d;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timerTicker;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2c;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProjectStat;
    }
}