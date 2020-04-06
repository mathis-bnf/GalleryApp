namespace GalleryApp
{
    partial class ProgressDialog
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(331, 23);
            this.progressBar.TabIndex = 0;
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.ForeColor = System.Drawing.SystemColors.Window;
            this.lbProgress.Location = new System.Drawing.Point(147, 38);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(65, 17);
            this.lbProgress.TabIndex = 1;
            this.lbProgress.Text = "Progress";
            // 
            // ProgressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(355, 67);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.progressBar);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(373, 114);
            this.MinimumSize = new System.Drawing.Size(373, 114);
            this.Name = "ProgressDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images loading progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbProgress;
    }
}