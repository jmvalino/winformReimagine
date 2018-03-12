namespace VSBoard.Views
{
    partial class Manhours
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Javer Valino",
            "SMART PLUG",
            "ONLINE",
            "45"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Elton Reformado",
            "Apollo 2",
            "ONLINE",
            "250"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Benedict",
            "Regrow Helmet",
            "ONLINE",
            "130"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Jerome",
            "SMART PLUG",
            "ONLINE",
            "180"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Karl",
            "RX-BOX",
            "ONLINE",
            "150"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manhours));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.n = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.s = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.imageListOnlineStat = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.604651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.39535F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n,
            this.p,
            this.s,
            this.t});
            this.tableLayoutPanel1.SetColumnSpan(this.listView1, 5);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(3, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1010, 387);
            this.listView1.SmallImageList = this.imageListOnlineStat;
            this.listView1.StateImageList = this.imageListOnlineStat;
            this.listView1.TabIndex = 2;
            this.listView1.TileSize = new System.Drawing.Size(400, 150);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // n
            // 
            this.n.Text = "Name";
            this.n.Width = 290;
            // 
            // p
            // 
            this.p.Text = "Project";
            this.p.Width = 306;
            // 
            // s
            // 
            this.s.Text = "Status";
            this.s.Width = 327;
            // 
            // t
            // 
            this.t.Text = "Total MH";
            this.t.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t.Width = 282;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manhour Tracker";
            // 
            // imageListOnlineStat
            // 
            this.imageListOnlineStat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListOnlineStat.ImageStream")));
            this.imageListOnlineStat.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListOnlineStat.Images.SetKeyName(0, "circuit-board.png");
            this.imageListOnlineStat.Images.SetKeyName(1, "message.png");
            // 
            // Manhours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Manhours";
            this.Size = new System.Drawing.Size(1016, 430);
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader n;
        private System.Windows.Forms.ColumnHeader p;
        private System.Windows.Forms.ColumnHeader s;
        private System.Windows.Forms.ColumnHeader t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageListOnlineStat;
    }
}
