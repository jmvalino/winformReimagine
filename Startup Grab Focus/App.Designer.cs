namespace Startup_Grab_Focus
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
            this.msTopNav = new System.Windows.Forms.MenuStrip();
            this.tsmiHome = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.subNavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subNavToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.msAccount = new System.Windows.Forms.MenuStrip();
            this.usernamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panelViewContainer = new System.Windows.Forms.Panel();
            this.msTopNav.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.msAccount.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTopNav
            // 
            this.msTopNav.BackColor = System.Drawing.Color.White;
            this.msTopNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msTopNav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTopNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHome,
            this.toolStripMenuItem2,
            this.tsmiHelp});
            this.msTopNav.Location = new System.Drawing.Point(0, 0);
            this.msTopNav.Name = "msTopNav";
            this.msTopNav.Size = new System.Drawing.Size(231, 35);
            this.msTopNav.TabIndex = 2;
            this.msTopNav.Text = "menuStrip1";
            // 
            // tsmiHome
            // 
            this.tsmiHome.Name = "tsmiHome";
            this.tsmiHome.Size = new System.Drawing.Size(62, 31);
            this.tsmiHome.Text = "Menu";
            this.tsmiHome.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subNavToolStripMenuItem,
            this.subNavToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(62, 31);
            this.toolStripMenuItem2.Text = "Menu";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // subNavToolStripMenuItem
            // 
            this.subNavToolStripMenuItem.Name = "subNavToolStripMenuItem";
            this.subNavToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.subNavToolStripMenuItem.Text = "sub nav";
            // 
            // subNavToolStripMenuItem1
            // 
            this.subNavToolStripMenuItem1.Name = "subNavToolStripMenuItem1";
            this.subNavToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.subNavToolStripMenuItem1.Text = "sub nav";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(54, 31);
            this.tsmiHelp.Text = "Help";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.71065F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.28936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.msTopNav, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 35);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(736, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Search..";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.29844F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.70156F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.msAccount, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(890, 31);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // msAccount
            // 
            this.msAccount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.msAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.msAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernamToolStripMenuItem});
            this.msAccount.Location = new System.Drawing.Point(753, 0);
            this.msAccount.Name = "msAccount";
            this.msAccount.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msAccount.Size = new System.Drawing.Size(116, 31);
            this.msAccount.TabIndex = 0;
            this.msAccount.Text = "menuStrip1";
            // 
            // usernamToolStripMenuItem
            // 
            this.usernamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privacyToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.usernamToolStripMenuItem.Name = "usernamToolStripMenuItem";
            this.usernamToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.usernamToolStripMenuItem.Text = " ~ username";
            // 
            // privacyToolStripMenuItem
            // 
            this.privacyToolStripMenuItem.Name = "privacyToolStripMenuItem";
            this.privacyToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.privacyToolStripMenuItem.Text = "privacy";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.logoutToolStripMenuItem.Text = "logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9205984F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.0794F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.panelViewContainer, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 66);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.088803F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.91119F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(890, 305);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // panelViewContainer
            // 
            this.panelViewContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelViewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewContainer.Location = new System.Drawing.Point(11, 12);
            this.panelViewContainer.Name = "panelViewContainer";
            this.panelViewContainer.Size = new System.Drawing.Size(855, 281);
            this.panelViewContainer.TabIndex = 0;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 371);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.msTopNav;
            this.Name = "App";
            this.Text = "WinForm UI";
            this.Load += new System.EventHandler(this.Exec_Load);
            this.msTopNav.ResumeLayout(false);
            this.msTopNav.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.msAccount.ResumeLayout(false);
            this.msAccount.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTopNav;
        private System.Windows.Forms.ToolStripMenuItem tsmiHome;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem subNavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subNavToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip msAccount;
        private System.Windows.Forms.ToolStripMenuItem usernamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panelViewContainer;
    }
}

