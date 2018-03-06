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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelHolder = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCtr = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.annToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelCtr.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTicker
            // 
            this.timerTicker.Enabled = true;
            this.timerTicker.Interval = 1000;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelHolder, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 495);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelHolder
            // 
            this.panelHolder.BackColor = System.Drawing.Color.Transparent;
            this.panelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHolder.HorizontalScrollbarBarColor = true;
            this.panelHolder.HorizontalScrollbarHighlightOnWheel = false;
            this.panelHolder.HorizontalScrollbarSize = 10;
            this.panelHolder.Location = new System.Drawing.Point(3, 3);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(889, 489);
            this.panelHolder.TabIndex = 2;
            this.panelHolder.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panelHolder.VerticalScrollbarBarColor = true;
            this.panelHolder.VerticalScrollbarHighlightOnWheel = false;
            this.panelHolder.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.panel1.BackgroundImage = global::VSBoard.Properties.Resources.pattern;
            this.panel1.Controls.Add(this.tableLayoutPanelCtr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 60);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanelCtr
            // 
            this.tableLayoutPanelCtr.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelCtr.ColumnCount = 2;
            this.tableLayoutPanelCtr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71508F));
            this.tableLayoutPanelCtr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.28492F));
            this.tableLayoutPanelCtr.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelCtr.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanelCtr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCtr.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCtr.Name = "tableLayoutPanelCtr";
            this.tableLayoutPanelCtr.RowCount = 1;
            this.tableLayoutPanelCtr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCtr.Size = new System.Drawing.Size(895, 60);
            this.tableLayoutPanelCtr.TabIndex = 0;
            this.tableLayoutPanelCtr.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "design && development group";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::VSBoard.Properties.Resources.pattern;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annToolStripMenuItem,
            this.manToolStripMenuItem,
            this.jToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(257, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // annToolStripMenuItem
            // 
            this.annToolStripMenuItem.Checked = true;
            this.annToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.annToolStripMenuItem.Image = global::VSBoard.Properties.Resources.message;
            this.annToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.annToolStripMenuItem.Name = "annToolStripMenuItem";
            this.annToolStripMenuItem.Size = new System.Drawing.Size(62, 54);
            // 
            // manToolStripMenuItem
            // 
            this.manToolStripMenuItem.Image = global::VSBoard.Properties.Resources.human;
            this.manToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manToolStripMenuItem.Name = "manToolStripMenuItem";
            this.manToolStripMenuItem.Size = new System.Drawing.Size(62, 54);
            // 
            // jToolStripMenuItem
            // 
            this.jToolStripMenuItem.Image = global::VSBoard.Properties.Resources.cube_outline;
            this.jToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.jToolStripMenuItem.Name = "jToolStripMenuItem";
            this.jToolStripMenuItem.Size = new System.Drawing.Size(62, 54);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 495);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanelCtr.ResumeLayout(false);
            this.tableLayoutPanelCtr.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerTicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel panelHolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem annToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jToolStripMenuItem;
    }
}

