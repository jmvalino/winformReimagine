namespace VSBoard
{
    partial class MainAPP
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
            this.backgroundWorkerMainAPP = new System.ComponentModel.BackgroundWorker();
            this.timerWorker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerWorker
            // 
            this.timerWorker.Enabled = true;
            this.timerWorker.Interval = 2000;
            this.timerWorker.Tick += new System.EventHandler(this.timerWorker_Tick);
            // 
            // MainAPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 304);
            this.Name = "MainAPP";
            this.Text = "MainAPP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorkerMainAPP;
        private System.Windows.Forms.Timer timerWorker;
    }
}