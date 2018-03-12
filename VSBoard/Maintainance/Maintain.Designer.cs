namespace VSBoard.Maintainance
{
    partial class Maintain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelHolder = new MetroFramework.Controls.MetroPanel();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manhoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.announcementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.announcements1 = new VSBoard.Maintainance.Views.Interstitial();
            this.menuStrip1.SuspendLayout();
            this.panelHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.manhoursToolStripMenuItem,
            this.announcementsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(258, 311);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelHolder
            // 
            this.panelHolder.Controls.Add(this.announcements1);
            this.panelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHolder.HorizontalScrollbarBarColor = true;
            this.panelHolder.HorizontalScrollbarHighlightOnWheel = false;
            this.panelHolder.HorizontalScrollbarSize = 10;
            this.panelHolder.Location = new System.Drawing.Point(278, 60);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(531, 311);
            this.panelHolder.TabIndex = 1;
            this.panelHolder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelHolder.VerticalScrollbarBarColor = true;
            this.panelHolder.VerticalScrollbarHighlightOnWheel = false;
            this.panelHolder.VerticalScrollbarSize = 10;
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.projectsToolStripMenuItem.Image = global::VSBoard.Properties.Resources.cube_outline;
            this.projectsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(245, 54);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // manhoursToolStripMenuItem
            // 
            this.manhoursToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manhoursToolStripMenuItem.Image = global::VSBoard.Properties.Resources.human;
            this.manhoursToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manhoursToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manhoursToolStripMenuItem.Name = "manhoursToolStripMenuItem";
            this.manhoursToolStripMenuItem.Size = new System.Drawing.Size(245, 54);
            this.manhoursToolStripMenuItem.Text = "Manhours";
            this.manhoursToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // announcementsToolStripMenuItem
            // 
            this.announcementsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.announcementsToolStripMenuItem.Image = global::VSBoard.Properties.Resources.message;
            this.announcementsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.announcementsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.announcementsToolStripMenuItem.Name = "announcementsToolStripMenuItem";
            this.announcementsToolStripMenuItem.Size = new System.Drawing.Size(245, 54);
            this.announcementsToolStripMenuItem.Text = "Announcements";
            this.announcementsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // announcements1
            // 
            this.announcements1.Location = new System.Drawing.Point(166, 108);
            this.announcements1.Name = "announcements1";
            this.announcements1.Size = new System.Drawing.Size(150, 150);
            this.announcements1.TabIndex = 2;
            // 
            // Maintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 391);
            this.Controls.Add(this.panelHolder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Maintain";
            this.Text = "Maintain";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manhoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem announcementsToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel panelHolder;
        private Views.Interstitial announcements1;
    }
}