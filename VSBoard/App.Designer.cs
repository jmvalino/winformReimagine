namespace VSBoard
{
    partial class App
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
            this.timerTicker = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.timerForClock = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.panelCrawl = new System.Windows.Forms.Panel();
            this.lblCrawl = new System.Windows.Forms.Label();
            this.timerForCrawler = new System.Windows.Forms.Timer(this.components);
            this.panelButtom = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manhoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelCrawl.SuspendLayout();
            this.panelButtom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTicker
            // 
            this.timerTicker.Enabled = true;
            this.timerTicker.Interval = 2000;
            this.timerTicker.Tick += new System.EventHandler(this.timerTicker_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.Location = new System.Drawing.Point(0, 0);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(200, 100);
            this.metroTabPage4.TabIndex = 0;
            this.metroTabPage4.Text = "Events && Reminders";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(340, 114);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(333, 262);
            this.miniToolStrip.TabIndex = 0;
            // 
            // timerForClock
            // 
            this.timerForClock.Enabled = true;
            this.timerForClock.Interval = 1000;
            this.timerForClock.Tick += new System.EventHandler(this.timerForClock_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panelHolder, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 74);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1070, 421);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panelHolder
            // 
            this.panelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHolder.Location = new System.Drawing.Point(3, 3);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(1064, 415);
            this.panelHolder.TabIndex = 0;
            // 
            // panelCrawl
            // 
            this.panelCrawl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCrawl.Controls.Add(this.lblCrawl);
            this.panelCrawl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCrawl.Location = new System.Drawing.Point(0, 449);
            this.panelCrawl.Name = "panelCrawl";
            this.panelCrawl.Size = new System.Drawing.Size(1070, 46);
            this.panelCrawl.TabIndex = 3;
            // 
            // lblCrawl
            // 
            this.lblCrawl.AutoEllipsis = true;
            this.lblCrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrawl.ForeColor = System.Drawing.Color.White;
            this.lblCrawl.Location = new System.Drawing.Point(154, 11);
            this.lblCrawl.Name = "lblCrawl";
            this.lblCrawl.Size = new System.Drawing.Size(1067, 23);
            this.lblCrawl.TabIndex = 0;
            this.lblCrawl.Text = "News && Announcements";
            // 
            // timerForCrawler
            // 
            this.timerForCrawler.Enabled = true;
            this.timerForCrawler.Interval = 200;
            this.timerForCrawler.Tick += new System.EventHandler(this.timerForCrawler_Tick);
            // 
            // panelButtom
            // 
            this.panelButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.panelButtom.BackgroundImage = global::VSBoard.Properties.Resources.pattern;
            this.panelButtom.Controls.Add(this.tableLayoutPanel1);
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtom.Location = new System.Drawing.Point(0, 0);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(1070, 74);
            this.panelButtom.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.BackgroundImage = global::VSBoard.Properties.Resources.pattern;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.76119F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.23881F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1044, 85);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jToolStripMenuItem,
            this.manhoursToolStripMenuItem,
            this.projectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(399, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 85);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jToolStripMenuItem
            // 
            this.jToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.jToolStripMenuItem.Image = global::VSBoard.Properties.Resources.message;
            this.jToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.jToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.jToolStripMenuItem.Name = "jToolStripMenuItem";
            this.jToolStripMenuItem.ShowShortcutKeys = false;
            this.jToolStripMenuItem.Size = new System.Drawing.Size(201, 81);
            this.jToolStripMenuItem.Text = "Events && Announcements";
            this.jToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.jToolStripMenuItem.Click += new System.EventHandler(this.jToolStripMenuItem_Click_1);
            // 
            // manhoursToolStripMenuItem
            // 
            this.manhoursToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manhoursToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manhoursToolStripMenuItem.Image = global::VSBoard.Properties.Resources.human;
            this.manhoursToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manhoursToolStripMenuItem.Name = "manhoursToolStripMenuItem";
            this.manhoursToolStripMenuItem.Size = new System.Drawing.Size(93, 81);
            this.manhoursToolStripMenuItem.Text = "Manhours";
            this.manhoursToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.manhoursToolStripMenuItem.Click += new System.EventHandler(this.manhoursToolStripMenuItem_Click_1);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.projectsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.projectsToolStripMenuItem.Image = global::VSBoard.Properties.Resources.cube_outline;
            this.projectsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(77, 81);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click_1);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(3, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(184, 66);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "#DDG";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 495);
            this.Controls.Add(this.panelCrawl);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panelButtom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.miniToolStrip;
            this.Name = "App";
            this.ShowInTaskbar = false;
            this.Text = "Design && Development Group";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelCrawl.ResumeLayout(false);
            this.panelButtom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerTicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.Panel panelButtom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manhoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.Timer timerForClock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelHolder;
        private System.Windows.Forms.Panel panelCrawl;
        private System.Windows.Forms.Label lblCrawl;
        private System.Windows.Forms.Timer timerForCrawler;
    }
}

