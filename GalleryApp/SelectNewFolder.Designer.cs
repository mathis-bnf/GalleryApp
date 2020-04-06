namespace GalleryApp
{
    partial class SelectNewFolder
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
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.bFolder = new System.Windows.Forms.Button();
            this.lYear = new System.Windows.Forms.Label();
            this.lPlace = new System.Windows.Forms.Label();
            this.lRequiredFields = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPlace
            // 
            this.tbPlace.Location = new System.Drawing.Point(12, 156);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(168, 22);
            this.tbPlace.TabIndex = 0;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(12, 94);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(168, 22);
            this.tbYear.TabIndex = 1;
            // 
            // bFolder
            // 
            this.bFolder.ForeColor = System.Drawing.Color.Black;
            this.bFolder.Location = new System.Drawing.Point(12, 34);
            this.bFolder.Name = "bFolder";
            this.bFolder.Size = new System.Drawing.Size(168, 23);
            this.bFolder.TabIndex = 2;
            this.bFolder.Text = "Search for a folder*";
            this.bFolder.UseVisualStyleBackColor = true;
            this.bFolder.Click += new System.EventHandler(this.bFolder_Click);
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.ForeColor = System.Drawing.SystemColors.Window;
            this.lYear.Location = new System.Drawing.Point(12, 74);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(43, 17);
            this.lYear.TabIndex = 3;
            this.lYear.Text = "Year*";
            // 
            // lPlace
            // 
            this.lPlace.AutoSize = true;
            this.lPlace.ForeColor = System.Drawing.SystemColors.Window;
            this.lPlace.Location = new System.Drawing.Point(12, 133);
            this.lPlace.Name = "lPlace";
            this.lPlace.Size = new System.Drawing.Size(43, 17);
            this.lPlace.TabIndex = 4;
            this.lPlace.Text = "Place";
            // 
            // lRequiredFields
            // 
            this.lRequiredFields.AutoSize = true;
            this.lRequiredFields.ForeColor = System.Drawing.SystemColors.Window;
            this.lRequiredFields.Location = new System.Drawing.Point(12, 193);
            this.lRequiredFields.Name = "lRequiredFields";
            this.lRequiredFields.Size = new System.Drawing.Size(108, 17);
            this.lRequiredFields.TabIndex = 5;
            this.lRequiredFields.Text = "*Required fields";
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(12, 223);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(168, 32);
            this.bOK.TabIndex = 6;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // SelectNewFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(208, 269);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.lRequiredFields);
            this.Controls.Add(this.lPlace);
            this.Controls.Add(this.lYear);
            this.Controls.Add(this.bFolder);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbPlace);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(226, 316);
            this.MinimumSize = new System.Drawing.Size(226, 316);
            this.Name = "SelectNewFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Button bFolder;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lPlace;
        private System.Windows.Forms.Label lRequiredFields;
        private System.Windows.Forms.Button bOK;
    }
}