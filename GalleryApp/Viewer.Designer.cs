namespace GalleryApp
{
    partial class Viewer
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpImageButtons = new System.Windows.Forms.TableLayoutPanel();
            this.bPreviousPhoto = new System.Windows.Forms.Button();
            this.bNextPhoto = new System.Windows.Forms.Button();
            this.tlpImage = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBackGround = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSaturationValue = new System.Windows.Forms.Label();
            this.lbSaturation = new System.Windows.Forms.Label();
            this.bSaturationMinus = new System.Windows.Forms.Button();
            this.bSaturationPlus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAutoContrast = new System.Windows.Forms.Label();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.tlpBrightness = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbBrightnessValue = new System.Windows.Forms.Label();
            this.lbBrightness = new System.Windows.Forms.Label();
            this.bBrightnessMinus = new System.Windows.Forms.Button();
            this.bBrightnessPlus = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.tlpImageButtons.SuspendLayout();
            this.tlpImage.SuspendLayout();
            this.tlpBackGround.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tlpBrightness.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 28);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // tlpImageButtons
            // 
            this.tlpImageButtons.ColumnCount = 3;
            this.tlpImageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpImageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpImageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpImageButtons.Controls.Add(this.bPreviousPhoto, 0, 0);
            this.tlpImageButtons.Controls.Add(this.bNextPhoto, 2, 0);
            this.tlpImageButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImageButtons.Location = new System.Drawing.Point(3, 676);
            this.tlpImageButtons.Name = "tlpImageButtons";
            this.tlpImageButtons.RowCount = 1;
            this.tlpImageButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImageButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpImageButtons.Size = new System.Drawing.Size(1021, 53);
            this.tlpImageButtons.TabIndex = 1;
            // 
            // bPreviousPhoto
            // 
            this.bPreviousPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bPreviousPhoto.Location = new System.Drawing.Point(130, 14);
            this.bPreviousPhoto.Name = "bPreviousPhoto";
            this.bPreviousPhoto.Size = new System.Drawing.Size(80, 25);
            this.bPreviousPhoto.TabIndex = 0;
            this.bPreviousPhoto.TabStop = false;
            this.bPreviousPhoto.UseVisualStyleBackColor = true;
            this.bPreviousPhoto.Click += new System.EventHandler(this.bPreviousPhoto_Click);
            // 
            // bNextPhoto
            // 
            this.bNextPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bNextPhoto.Location = new System.Drawing.Point(810, 14);
            this.bNextPhoto.Name = "bNextPhoto";
            this.bNextPhoto.Size = new System.Drawing.Size(80, 25);
            this.bNextPhoto.TabIndex = 1;
            this.bNextPhoto.TabStop = false;
            this.bNextPhoto.UseVisualStyleBackColor = true;
            this.bNextPhoto.Click += new System.EventHandler(this.bNextPhoto_Click);
            // 
            // tlpImage
            // 
            this.tlpImage.ColumnCount = 1;
            this.tlpImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpImage.Controls.Add(this.tlpImageButtons, 0, 1);
            this.tlpImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImage.Location = new System.Drawing.Point(3, 3);
            this.tlpImage.Name = "tlpImage";
            this.tlpImage.RowCount = 2;
            this.tlpImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tlpImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpImage.Size = new System.Drawing.Size(1027, 732);
            this.tlpImage.TabIndex = 0;
            // 
            // tlpBackGround
            // 
            this.tlpBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tlpBackGround.ColumnCount = 2;
            this.tlpBackGround.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpBackGround.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBackGround.Controls.Add(this.tlpImage, 0, 0);
            this.tlpBackGround.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlpBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBackGround.Location = new System.Drawing.Point(0, 0);
            this.tlpBackGround.Name = "tlpBackGround";
            this.tlpBackGround.RowCount = 1;
            this.tlpBackGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBackGround.Size = new System.Drawing.Size(1292, 738);
            this.tlpBackGround.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1036, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 732);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GalleryApp.Properties.Resources.menuLogo;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-7, -3);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tlpBrightness, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bSave, 0, 11);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.327084F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.327084F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.327084F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 690);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bSaturationMinus, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bSaturationPlus, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(241, 51);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSaturationValue);
            this.panel1.Controls.Add(this.lbSaturation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 45);
            this.panel1.TabIndex = 0;
            // 
            // lbSaturationValue
            // 
            this.lbSaturationValue.AutoSize = true;
            this.lbSaturationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaturationValue.ForeColor = System.Drawing.Color.White;
            this.lbSaturationValue.Location = new System.Drawing.Point(29, 25);
            this.lbSaturationValue.Name = "lbSaturationValue";
            this.lbSaturationValue.Size = new System.Drawing.Size(41, 25);
            this.lbSaturationValue.TabIndex = 4;
            this.lbSaturationValue.Text = "0%";
            this.lbSaturationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSaturation
            // 
            this.lbSaturation.AutoSize = true;
            this.lbSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaturation.ForeColor = System.Drawing.Color.White;
            this.lbSaturation.Location = new System.Drawing.Point(8, 3);
            this.lbSaturation.Margin = new System.Windows.Forms.Padding(0);
            this.lbSaturation.Name = "lbSaturation";
            this.lbSaturation.Size = new System.Drawing.Size(85, 20);
            this.lbSaturation.TabIndex = 3;
            this.lbSaturation.Text = "Saturation";
            // 
            // bSaturationMinus
            // 
            this.bSaturationMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bSaturationMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSaturationMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaturationMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSaturationMinus.ForeColor = System.Drawing.SystemColors.Control;
            this.bSaturationMinus.Location = new System.Drawing.Point(123, 3);
            this.bSaturationMinus.Name = "bSaturationMinus";
            this.bSaturationMinus.Size = new System.Drawing.Size(54, 45);
            this.bSaturationMinus.TabIndex = 1;
            this.bSaturationMinus.Text = "-";
            this.bSaturationMinus.UseVisualStyleBackColor = false;
            this.bSaturationMinus.Click += new System.EventHandler(this.bSaturationMinus_Click);
            // 
            // bSaturationPlus
            // 
            this.bSaturationPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bSaturationPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSaturationPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaturationPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSaturationPlus.ForeColor = System.Drawing.SystemColors.Control;
            this.bSaturationPlus.Location = new System.Drawing.Point(183, 3);
            this.bSaturationPlus.Name = "bSaturationPlus";
            this.bSaturationPlus.Size = new System.Drawing.Size(55, 45);
            this.bSaturationPlus.TabIndex = 2;
            this.bSaturationPlus.Text = "+";
            this.bSaturationPlus.UseVisualStyleBackColor = false;
            this.bSaturationPlus.Click += new System.EventHandler(this.bSaturationPlus_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbAutoContrast);
            this.panel2.Controls.Add(this.cbAuto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 51);
            this.panel2.TabIndex = 6;
            // 
            // lbAutoContrast
            // 
            this.lbAutoContrast.AutoSize = true;
            this.lbAutoContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutoContrast.ForeColor = System.Drawing.Color.White;
            this.lbAutoContrast.Location = new System.Drawing.Point(5, 15);
            this.lbAutoContrast.Name = "lbAutoContrast";
            this.lbAutoContrast.Size = new System.Drawing.Size(112, 20);
            this.lbAutoContrast.TabIndex = 1;
            this.lbAutoContrast.Text = "Auto Contrast";
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(173, 18);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(18, 17);
            this.cbAuto.TabIndex = 5;
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tlpBrightness
            // 
            this.tlpBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tlpBrightness.ColumnCount = 3;
            this.tlpBrightness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBrightness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBrightness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBrightness.Controls.Add(this.panel3, 0, 0);
            this.tlpBrightness.Controls.Add(this.bBrightnessMinus, 1, 0);
            this.tlpBrightness.Controls.Add(this.bBrightnessPlus, 2, 0);
            this.tlpBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBrightness.Location = new System.Drawing.Point(3, 3);
            this.tlpBrightness.Name = "tlpBrightness";
            this.tlpBrightness.RowCount = 1;
            this.tlpBrightness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBrightness.Size = new System.Drawing.Size(241, 51);
            this.tlpBrightness.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbBrightnessValue);
            this.panel3.Controls.Add(this.lbBrightness);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 45);
            this.panel3.TabIndex = 0;
            // 
            // lbBrightnessValue
            // 
            this.lbBrightnessValue.AutoSize = true;
            this.lbBrightnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrightnessValue.ForeColor = System.Drawing.Color.White;
            this.lbBrightnessValue.Location = new System.Drawing.Point(29, 25);
            this.lbBrightnessValue.Name = "lbBrightnessValue";
            this.lbBrightnessValue.Size = new System.Drawing.Size(41, 25);
            this.lbBrightnessValue.TabIndex = 4;
            this.lbBrightnessValue.Text = "0%";
            this.lbBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBrightness
            // 
            this.lbBrightness.AutoSize = true;
            this.lbBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrightness.ForeColor = System.Drawing.Color.White;
            this.lbBrightness.Location = new System.Drawing.Point(8, 3);
            this.lbBrightness.Margin = new System.Windows.Forms.Padding(0);
            this.lbBrightness.Name = "lbBrightness";
            this.lbBrightness.Size = new System.Drawing.Size(90, 20);
            this.lbBrightness.TabIndex = 3;
            this.lbBrightness.Text = "Brightness";
            // 
            // bBrightnessMinus
            // 
            this.bBrightnessMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bBrightnessMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBrightnessMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBrightnessMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrightnessMinus.ForeColor = System.Drawing.SystemColors.Control;
            this.bBrightnessMinus.Location = new System.Drawing.Point(123, 3);
            this.bBrightnessMinus.Name = "bBrightnessMinus";
            this.bBrightnessMinus.Size = new System.Drawing.Size(54, 45);
            this.bBrightnessMinus.TabIndex = 1;
            this.bBrightnessMinus.Text = "-";
            this.bBrightnessMinus.UseVisualStyleBackColor = false;
            this.bBrightnessMinus.Click += new System.EventHandler(this.bBrightnessMinus_Click);
            // 
            // bBrightnessPlus
            // 
            this.bBrightnessPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bBrightnessPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBrightnessPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBrightnessPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrightnessPlus.ForeColor = System.Drawing.SystemColors.Control;
            this.bBrightnessPlus.Location = new System.Drawing.Point(183, 3);
            this.bBrightnessPlus.Name = "bBrightnessPlus";
            this.bBrightnessPlus.Size = new System.Drawing.Size(55, 45);
            this.bBrightnessPlus.TabIndex = 2;
            this.bBrightnessPlus.Text = "+";
            this.bBrightnessPlus.UseVisualStyleBackColor = false;
            this.bBrightnessPlus.Click += new System.EventHandler(this.bBrightnessPlus_Click);
            // 
            // bSave
            // 
            this.bSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.SystemColors.Control;
            this.bSave.Location = new System.Drawing.Point(3, 630);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(241, 57);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Save changes";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 30);
            this.panel4.TabIndex = 10;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1292, 738);
            this.Controls.Add(this.tlpBackGround);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Viewer";
            this.Text = "GalleryApp - Viewer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Viewer_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tlpImageButtons.ResumeLayout(false);
            this.tlpImage.ResumeLayout(false);
            this.tlpBackGround.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tlpBrightness.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpImageButtons;
        private System.Windows.Forms.Button bPreviousPhoto;
        private System.Windows.Forms.Button bNextPhoto;
        private System.Windows.Forms.TableLayoutPanel tlpImage;
        private System.Windows.Forms.TableLayoutPanel tlpBackGround;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbAutoContrast;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.TableLayoutPanel tlpBrightness;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbBrightnessValue;
        private System.Windows.Forms.Label lbBrightness;
        private System.Windows.Forms.Button bBrightnessMinus;
        private System.Windows.Forms.Button bBrightnessPlus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSaturationValue;
        private System.Windows.Forms.Label lbSaturation;
        private System.Windows.Forms.Button bSaturationMinus;
        private System.Windows.Forms.Button bSaturationPlus;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel panel4;
    }
}