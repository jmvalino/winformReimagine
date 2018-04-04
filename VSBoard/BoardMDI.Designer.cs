namespace VSBoard
{
    partial class BoardMDI
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
            this.lblSection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSection
            // 
            this.lblSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSection.Location = new System.Drawing.Point(599, 292);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(214, 73);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "#DDG";
            this.lblSection.Click += new System.EventHandler(this.lblSection_Click);
            // 
            // BoardMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::VSBoard.Properties.Resources.internet_of_things_graphic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(872, 363);
            this.Controls.Add(this.lblSection);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoardMDI";
            this.ShowIcon = false;
            this.Text = "Board Playing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoardMDI_FormClosing);
            this.Load += new System.EventHandler(this.BoardMDI_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSection;


    }
}