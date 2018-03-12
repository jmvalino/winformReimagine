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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageListTile = new System.Windows.Forms.ImageList(this.components);
            this.listViewManhours = new System.Windows.Forms.ListView();
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.n = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ticker = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 75);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.622739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.37726F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Controls.Add(this.listViewManhours, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(795, 319);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // imageListTile
            // 
            this.imageListTile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTile.ImageStream")));
            this.imageListTile.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTile.Images.SetKeyName(0, "user_green.png");
            // 
            // listViewManhours
            // 
            this.listViewManhours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n,
            this.Task,
            this.columnHeader2});
            this.listViewManhours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewManhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewManhours.LargeImageList = this.imageListTile;
            this.listViewManhours.Location = new System.Drawing.Point(59, 34);
            this.listViewManhours.Name = "listViewManhours";
            this.listViewManhours.Size = new System.Drawing.Size(677, 249);
            this.listViewManhours.SmallImageList = this.imageListTile;
            this.listViewManhours.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewManhours.StateImageList = this.imageListTile;
            this.listViewManhours.TabIndex = 0;
            this.listViewManhours.TileSize = new System.Drawing.Size(400, 100);
            this.listViewManhours.UseCompatibleStateImageBehavior = false;
            this.listViewManhours.View = System.Windows.Forms.View.List;
            // 
            // Task
            // 
            this.Task.Text = "Active Task";
            this.Task.Width = 259;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Consumed Man Hours";
            this.columnHeader2.Width = 377;
            // 
            // n
            // 
            this.n.Text = "Name";
            this.n.Width = 400;
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
            this.ClientSize = new System.Drawing.Size(795, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManhours";
            this.Text = "frmManhours";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList imageListTile;
        private System.Windows.Forms.ListView listViewManhours;
        private System.Windows.Forms.ColumnHeader n;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer Ticker;
    }
}