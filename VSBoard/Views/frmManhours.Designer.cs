namespace VSBoard.Views
{
    partial class frmManhours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManhours));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewManhoursActive = new System.Windows.Forms.ListView();
            this.n = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.listViewManhoursInactive = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ticker = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "REALTIME MANHOURS";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.521276F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.47872F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.listViewManhoursActive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewManhoursInactive, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.500613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.83858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.6608F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(795, 329);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // listViewManhoursActive
            // 
            this.listViewManhoursActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.listViewManhoursActive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewManhoursActive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n,
            this.Task,
            this.columnHeader2});
            this.listViewManhoursActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewManhoursActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewManhoursActive.LargeImageList = this.myImageList;
            this.listViewManhoursActive.Location = new System.Drawing.Point(37, 16);
            this.listViewManhoursActive.Name = "listViewManhoursActive";
            this.listViewManhoursActive.Size = new System.Drawing.Size(721, 160);
            this.listViewManhoursActive.SmallImageList = this.myImageList;
            this.listViewManhoursActive.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewManhoursActive.StateImageList = this.myImageList;
            this.listViewManhoursActive.TabIndex = 0;
            this.listViewManhoursActive.TileSize = new System.Drawing.Size(400, 100);
            this.listViewManhoursActive.UseCompatibleStateImageBehavior = false;
            this.listViewManhoursActive.View = System.Windows.Forms.View.Tile;
            // 
            // n
            // 
            this.n.Text = "Name";
            // 
            // Task
            // 
            this.Task.Text = "Active Task";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Consumed Man Hours";
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myImageList.Images.SetKeyName(0, "onlineICO.ico");
            this.myImageList.Images.SetKeyName(1, "offlineICO.ico");
            // 
            // listViewManhoursInactive
            // 
            this.listViewManhoursInactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(229)))));
            this.listViewManhoursInactive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewManhoursInactive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewManhoursInactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewManhoursInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewManhoursInactive.LargeImageList = this.myImageList;
            this.listViewManhoursInactive.Location = new System.Drawing.Point(37, 182);
            this.listViewManhoursInactive.Name = "listViewManhoursInactive";
            this.listViewManhoursInactive.Size = new System.Drawing.Size(721, 122);
            this.listViewManhoursInactive.SmallImageList = this.myImageList;
            this.listViewManhoursInactive.TabIndex = 1;
            this.listViewManhoursInactive.TileSize = new System.Drawing.Size(400, 100);
            this.listViewManhoursInactive.UseCompatibleStateImageBehavior = false;
            this.listViewManhoursInactive.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Project";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Task";
            // 
            // Ticker
            // 
            this.Ticker.Enabled = true;
            this.Ticker.Interval = 1000;
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // frmManhours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManhours";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmManhours";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList myImageList;
        private System.Windows.Forms.ListView listViewManhoursActive;
        private System.Windows.Forms.ColumnHeader n;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer Ticker;
        private System.Windows.Forms.ListView listViewManhoursInactive;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
    }
}