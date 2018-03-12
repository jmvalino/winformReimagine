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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.lblProjectStat = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listViewDeliverables = new System.Windows.Forms.ListView();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.d = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerTicker = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lblProjectTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProjectStat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewDeliverables, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewTasks, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.4526F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.5474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.Color.White;
            this.lblProjectTitle.Location = new System.Drawing.Point(3, 0);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(238, 21);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.Text = "#ProjectName";
            this.lblProjectTitle.Click += new System.EventHandler(this.lblProjectTitle_Click);
            // 
            // lblProjectStat
            // 
            this.lblProjectStat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProjectStat.AutoSize = true;
            this.lblProjectStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectStat.ForeColor = System.Drawing.Color.White;
            this.lblProjectStat.Location = new System.Drawing.Point(731, 0);
            this.lblProjectStat.Name = "lblProjectStat";
            this.lblProjectStat.Size = new System.Drawing.Size(207, 21);
            this.lblProjectStat.TabIndex = 1;
            this.lblProjectStat.Text = "#ProjectStat";
            this.lblProjectStat.Click += new System.EventHandler(this.lblProjectStat_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(316, 24);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(307, 131);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // listViewDeliverables
            // 
            this.listViewDeliverables.BackColor = System.Drawing.Color.Black;
            this.listViewDeliverables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDeliverables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.d});
            this.listViewDeliverables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDeliverables.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDeliverables.ForeColor = System.Drawing.Color.LawnGreen;
            this.listViewDeliverables.Location = new System.Drawing.Point(3, 24);
            this.listViewDeliverables.Name = "listViewDeliverables";
            this.listViewDeliverables.Size = new System.Drawing.Size(307, 131);
            this.listViewDeliverables.TabIndex = 3;
            this.listViewDeliverables.UseCompatibleStateImageBehavior = false;
            this.listViewDeliverables.View = System.Windows.Forms.View.Details;
            // 
            // listViewTasks
            // 
            this.listViewTasks.BackColor = System.Drawing.Color.Black;
            this.listViewTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTasks.ForeColor = System.Drawing.Color.LawnGreen;
            this.listViewTasks.Location = new System.Drawing.Point(629, 24);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(309, 131);
            this.listViewTasks.TabIndex = 4;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // d
            // 
            this.d.Text = "Deliverables";
            this.d.Width = 290;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tasks";
            this.columnHeader2.Width = 330;
            // 
            // timerTicker
            // 
            this.timerTicker.Enabled = true;
            this.timerTicker.Interval = 5000;
            this.timerTicker.Tick += new System.EventHandler(this.timerTicker_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::VSBoard.Properties.Resources.cube_outline;
            this.pictureBox1.Location = new System.Drawing.Point(419, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::VSBoard.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(941, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProjects";
            this.Text = "frmProjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label lblProjectStat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView listViewDeliverables;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader d;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timerTicker;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}