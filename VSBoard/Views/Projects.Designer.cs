namespace VSBoard.Views
{
    partial class Projects
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

        #region Component Designer generated code

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProjName = new System.Windows.Forms.Label();
            this.listViewDeliverables = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deliverables = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.d = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStat = new System.Windows.Forms.Label();
            this.timerTicker = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblProjName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listViewDeliverables, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewTasks, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStat, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.24138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.75862F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(864, 413);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblProjName
            // 
            this.lblProjName.AutoSize = true;
            this.lblProjName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProjName.Location = new System.Drawing.Point(3, 0);
            this.lblProjName.Name = "lblProjName";
            this.lblProjName.Size = new System.Drawing.Size(282, 45);
            this.lblProjName.TabIndex = 0;
            // 
            // listViewDeliverables
            // 
            this.listViewDeliverables.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listViewDeliverables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDeliverables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Deliverables,
            this.d});
            this.listViewDeliverables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDeliverables.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDeliverables.ForeColor = System.Drawing.Color.Gray;
            this.listViewDeliverables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDeliverables.Location = new System.Drawing.Point(3, 48);
            this.listViewDeliverables.Name = "listViewDeliverables";
            this.listViewDeliverables.Size = new System.Drawing.Size(282, 210);
            this.listViewDeliverables.TabIndex = 2;
            this.listViewDeliverables.UseCompatibleStateImageBehavior = false;
            this.listViewDeliverables.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 0;
            // 
            // Deliverables
            // 
            this.Deliverables.Text = "Deliverables";
            this.Deliverables.Width = 216;
            // 
            // d
            // 
            this.d.Text = "Date";
            this.d.Width = 125;
            // 
            // listViewTasks
            // 
            this.listViewTasks.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewTasks.BackColor = System.Drawing.Color.White;
            this.listViewTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTasks.Location = new System.Drawing.Point(579, 48);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(282, 210);
            this.listViewTasks.TabIndex = 3;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.SelectedIndexChanged += new System.EventHandler(this.listViewTasks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tasks";
            this.columnHeader1.Width = 311;
            // 
            // chart1
            // 
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent90;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(291, 48);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(282, 210);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.Location = new System.Drawing.Point(579, 0);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(282, 45);
            this.lblStat.TabIndex = 5;
            this.lblStat.Text = "On-Schedule";
            this.lblStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerTicker
            // 
            this.timerTicker.Enabled = true;
            this.timerTicker.Interval = 5000;
            this.timerTicker.Tick += new System.EventHandler(this.timerTicker_Tick);
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Projects";
            this.Size = new System.Drawing.Size(864, 413);
            this.Load += new System.EventHandler(this.Projects_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblProjName;
        private System.Windows.Forms.ListView listViewDeliverables;
        private System.Windows.Forms.ColumnHeader Deliverables;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader d;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Timer timerTicker;

    }
}
