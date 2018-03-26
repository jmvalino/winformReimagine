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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnnoucements = new System.Windows.Forms.Button();
            this.btnMeta = new System.Windows.Forms.Button();
            this.btnBanners = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.llPlay = new System.Windows.Forms.LinkLabel();
            this.dbconfig = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.29696F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.19685F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.29696F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.98425F));
            this.tableLayoutPanel1.Controls.Add(this.btnAnnoucements, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMeta, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnBanners, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfig, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.llPlay, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dbconfig, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.4321F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.39506F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.14815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.6087F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 324);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAnnoucements
            // 
            this.btnAnnoucements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.btnAnnoucements.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnoucements.BackgroundImage")));
            this.btnAnnoucements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnoucements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnnoucements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnoucements.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnoucements.ForeColor = System.Drawing.Color.White;
            this.btnAnnoucements.Image = global::VSBoard.Properties.Resources.message_outline;
            this.btnAnnoucements.Location = new System.Drawing.Point(219, 53);
            this.btnAnnoucements.Name = "btnAnnoucements";
            this.btnAnnoucements.Size = new System.Drawing.Size(218, 86);
            this.btnAnnoucements.TabIndex = 0;
            this.btnAnnoucements.Text = "Announcements";
            this.btnAnnoucements.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnnoucements.UseVisualStyleBackColor = false;
            this.btnAnnoucements.Click += new System.EventHandler(this.btnAnnoucements_Click);
            // 
            // btnMeta
            // 
            this.btnMeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMeta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMeta.BackgroundImage")));
            this.btnMeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeta.ForeColor = System.Drawing.Color.White;
            this.btnMeta.Image = global::VSBoard.Properties.Resources.information;
            this.btnMeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeta.Location = new System.Drawing.Point(219, 145);
            this.btnMeta.Name = "btnMeta";
            this.btnMeta.Size = new System.Drawing.Size(218, 69);
            this.btnMeta.TabIndex = 1;
            this.btnMeta.Text = "Meta";
            this.btnMeta.UseVisualStyleBackColor = false;
            this.btnMeta.Click += new System.EventHandler(this.btnMeta_Click);
            // 
            // btnBanners
            // 
            this.btnBanners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.btnBanners.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBanners.BackgroundImage")));
            this.btnBanners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBanners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBanners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanners.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanners.ForeColor = System.Drawing.Color.White;
            this.btnBanners.Image = global::VSBoard.Properties.Resources.image_multiple;
            this.btnBanners.Location = new System.Drawing.Point(443, 53);
            this.btnBanners.Name = "btnBanners";
            this.btnBanners.Size = new System.Drawing.Size(210, 86);
            this.btnBanners.TabIndex = 2;
            this.btnBanners.Text = "Banners";
            this.btnBanners.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanners.UseVisualStyleBackColor = false;
            this.btnBanners.Click += new System.EventHandler(this.btnBanners_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfig.BackgroundImage")));
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = global::VSBoard.Properties.Resources.settings_outline;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(443, 145);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(210, 69);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Flash Configuration";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // llPlay
            // 
            this.llPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llPlay.AutoSize = true;
            this.llPlay.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPlay.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.llPlay.Location = new System.Drawing.Point(668, 257);
            this.llPlay.Name = "llPlay";
            this.llPlay.Size = new System.Drawing.Size(208, 27);
            this.llPlay.TabIndex = 4;
            this.llPlay.TabStop = true;
            this.llPlay.Text = "PLAY DDG BOARD >";
            this.llPlay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPlay_LinkClicked);
            // 
            // dbconfig
            // 
            this.dbconfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbconfig.AutoSize = true;
            this.dbconfig.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbconfig.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dbconfig.Location = new System.Drawing.Point(30, 263);
            this.dbconfig.Name = "dbconfig";
            this.dbconfig.Size = new System.Drawing.Size(156, 15);
            this.dbconfig.TabIndex = 5;
            this.dbconfig.TabStop = true;
            this.dbconfig.Text = "DATABASE CONFIGURATION";
            this.dbconfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dbconfig_LinkClicked);
            // 
            // Maintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::VSBoard.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(889, 324);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Maintain";
            this.Text = "Maintain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Maintain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAnnoucements;
        private System.Windows.Forms.Button btnMeta;
        private System.Windows.Forms.Button btnBanners;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.LinkLabel llPlay;
        private System.Windows.Forms.LinkLabel dbconfig;

    }
}