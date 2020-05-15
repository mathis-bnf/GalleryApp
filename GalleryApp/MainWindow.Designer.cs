namespace GalleryApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvImages = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tvFolders = new System.Windows.Forms.TreeView();
            this.bDeleteAlbum = new System.Windows.Forms.Button();
            this.bNewAlbum = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbOrderBy = new System.Windows.Forms.Label();
            this.cbOrderBy = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvImages
            // 
            this.lvImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lvImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvImages.ForeColor = System.Drawing.SystemColors.Window;
            this.lvImages.LargeImageList = this.imageList;
            this.lvImages.Location = new System.Drawing.Point(383, 3);
            this.lvImages.Name = "lvImages";
            this.lvImages.Size = new System.Drawing.Size(1516, 1027);
            this.lvImages.TabIndex = 1;
            this.lvImages.TabStop = false;
            this.lvImages.UseCompatibleStateImageBehavior = false;
            this.lvImages.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(100, 75);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tvFolders, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bNewAlbum, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bDeleteAlbum, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 1027);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tvFolders
            // 
            this.tvFolders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tvFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFolders.ForeColor = System.Drawing.SystemColors.Window;
            this.tvFolders.Location = new System.Drawing.Point(3, 156);
            this.tvFolders.Name = "tvFolders";
            this.tvFolders.Size = new System.Drawing.Size(368, 868);
            this.tvFolders.TabIndex = 2;
            this.tvFolders.TabStop = false;
            this.tvFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // bDeleteAlbum
            // 
            this.bDeleteAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bDeleteAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteAlbum.ForeColor = System.Drawing.SystemColors.Control;
            this.bDeleteAlbum.Location = new System.Drawing.Point(117, 59);
            this.bDeleteAlbum.Name = "bDeleteAlbum";
            this.bDeleteAlbum.Size = new System.Drawing.Size(140, 35);
            this.bDeleteAlbum.TabIndex = 1;
            this.bDeleteAlbum.Text = "Delete Album";
            this.bDeleteAlbum.UseVisualStyleBackColor = true;
            this.bDeleteAlbum.Click += new System.EventHandler(this.bDeleteAlbum_Click);
            // 
            // bNewAlbum
            // 
            this.bNewAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bNewAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNewAlbum.ForeColor = System.Drawing.SystemColors.Control;
            this.bNewAlbum.Location = new System.Drawing.Point(117, 8);
            this.bNewAlbum.Name = "bNewAlbum";
            this.bNewAlbum.Size = new System.Drawing.Size(140, 35);
            this.bNewAlbum.TabIndex = 0;
            this.bNewAlbum.Text = "New Album";
            this.bNewAlbum.UseVisualStyleBackColor = true;
            this.bNewAlbum.Click += new System.EventHandler(this.bNewAlbum_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lvImages, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1902, 1033);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Controls.Add(this.cbOrderBy, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbOrderBy, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 105);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(368, 45);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lbOrderBy
            // 
            this.lbOrderBy.AutoSize = true;
            this.lbOrderBy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderBy.ForeColor = System.Drawing.SystemColors.Control;
            this.lbOrderBy.Location = new System.Drawing.Point(32, 0);
            this.lbOrderBy.Name = "lbOrderBy";
            this.lbOrderBy.Size = new System.Drawing.Size(87, 45);
            this.lbOrderBy.TabIndex = 6;
            this.lbOrderBy.Text = "Order By :";
            this.lbOrderBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrderBy.ForeColor = System.Drawing.SystemColors.Control;
            this.cbOrderBy.FormattingEnabled = true;
            this.cbOrderBy.Items.AddRange(new object[] {
            "Name ascending order",
            "Name descending order",
            "Date ascending order",
            "Date descending order"});
            this.cbOrderBy.Location = new System.Drawing.Point(125, 10);
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(204, 26);
            this.cbOrderBy.TabIndex = 5;
            this.cbOrderBy.TabStop = false;
            this.cbOrderBy.SelectedIndexChanged += new System.EventHandler(this.cbOrderBy_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.tableLayoutPanel4);
            this.MaximumSize = new System.Drawing.Size(3840, 2160);
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Name = "MainWindow";
            this.Text = "GalleryApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvImages;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bNewAlbum;
        private System.Windows.Forms.TreeView tvFolders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button bDeleteAlbum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbOrderBy;
        private System.Windows.Forms.Label lbOrderBy;
    }
}

