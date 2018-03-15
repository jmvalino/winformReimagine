namespace VSBoard.Maintainance.Views
{
    partial class Meta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoardname = new System.Windows.Forms.TextBox();
            this.txtBoarddesc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Board Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Board Description";
            // 
            // txtBoardname
            // 
            this.txtBoardname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoardname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoardname.Location = new System.Drawing.Point(154, 12);
            this.txtBoardname.Name = "txtBoardname";
            this.txtBoardname.Size = new System.Drawing.Size(258, 22);
            this.txtBoardname.TabIndex = 2;
            this.txtBoardname.TextChanged += new System.EventHandler(this.txtBoardname_TextChanged);
            this.txtBoardname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoardname_KeyPress);
            // 
            // txtBoarddesc
            // 
            this.txtBoarddesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoarddesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoarddesc.Location = new System.Drawing.Point(154, 59);
            this.txtBoarddesc.Name = "txtBoarddesc";
            this.txtBoarddesc.Size = new System.Drawing.Size(258, 84);
            this.txtBoarddesc.TabIndex = 3;
            this.txtBoarddesc.Text = "";
            this.txtBoarddesc.TextChanged += new System.EventHandler(this.txtBoarddesc_TextChanged);
            // 
            // Meta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::VSBoard.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(441, 165);
            this.Controls.Add(this.txtBoarddesc);
            this.Controls.Add(this.txtBoardname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Meta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Meta_FormClosing);
            this.Load += new System.EventHandler(this.Meta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoardname;
        private System.Windows.Forms.RichTextBox txtBoarddesc;
    }
}