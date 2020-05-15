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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpImageButtons = new System.Windows.Forms.TableLayoutPanel();
            this.bPreviousPhoto = new System.Windows.Forms.Button();
            this.bNextPhoto = new System.Windows.Forms.Button();
            this.tlpImage = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBackGround = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSaturation = new System.Windows.Forms.TableLayoutPanel();
            this.bSaturationMinus = new System.Windows.Forms.Button();
            this.bSaturationPlus = new System.Windows.Forms.Button();
            this.tlpSaturationLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lbSaturationValue = new System.Windows.Forms.Label();
            this.lbSaturation = new System.Windows.Forms.Label();
            this.tlpBrightness = new System.Windows.Forms.TableLayoutPanel();
            this.bBrightnessMinus = new System.Windows.Forms.Button();
            this.bBrightnessPlus = new System.Windows.Forms.Button();
            this.tlpBrightnessLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lbBrightnessValue = new System.Windows.Forms.Label();
            this.lbBrightness = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bRotateLeft = new System.Windows.Forms.Button();
            this.bRotateRight = new System.Windows.Forms.Button();
            this.lbRotate = new System.Windows.Forms.Label();
            this.tlpAuto = new System.Windows.Forms.TableLayoutPanel();
            this.lbAutoContrast = new System.Windows.Forms.Label();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.tlpFlip = new System.Windows.Forms.TableLayoutPanel();
            this.lbFlip = new System.Windows.Forms.Label();
            this.bHorizontalFlip = new System.Windows.Forms.Button();
            this.bVerticalFlip = new System.Windows.Forms.Button();
            this.tlpResize = new System.Windows.Forms.TableLayoutPanel();
            this.lbResize = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.bResizeOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bBackWhite = new System.Windows.Forms.Button();
            this.bGray = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.bSave = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.tlpImageButtons.SuspendLayout();
            this.tlpImage.SuspendLayout();
            this.tlpBackGround.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.tlpSaturation.SuspendLayout();
            this.tlpSaturationLabels.SuspendLayout();
            this.tlpBrightness.SuspendLayout();
            this.tlpBrightnessLabels.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tlpAuto.SuspendLayout();
            this.tlpFlip.SuspendLayout();
            this.tlpResize.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.bPreviousPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPreviousPhoto.ForeColor = System.Drawing.SystemColors.Control;
            this.bPreviousPhoto.Image = ((System.Drawing.Image)(resources.GetObject("bPreviousPhoto.Image")));
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
            this.bNextPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNextPhoto.ForeColor = System.Drawing.SystemColors.Control;
            this.bNextPhoto.Image = ((System.Drawing.Image)(resources.GetObject("bNextPhoto.Image")));
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
            this.tableLayoutPanel1.Controls.Add(this.tlpMenu, 0, 1);
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
            // tlpMenu
            // 
            this.tlpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tlpMenu.ColumnCount = 1;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Controls.Add(this.tlpSaturation, 0, 1);
            this.tlpMenu.Controls.Add(this.tlpBrightness, 0, 0);
            this.tlpMenu.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tlpMenu.Controls.Add(this.tlpAuto, 0, 2);
            this.tlpMenu.Controls.Add(this.tlpFlip, 0, 4);
            this.tlpMenu.Controls.Add(this.tlpResize, 0, 5);
            this.tlpMenu.Controls.Add(this.tableLayoutPanel3, 0, 6);
            this.tlpMenu.Controls.Add(this.tableLayoutPanel5, 0, 11);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(3, 39);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 12;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335418F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.327084F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.327084F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.327084F));
            this.tlpMenu.Size = new System.Drawing.Size(247, 690);
            this.tlpMenu.TabIndex = 1;
            // 
            // tlpSaturation
            // 
            this.tlpSaturation.ColumnCount = 3;
            this.tlpSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSaturation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSaturation.Controls.Add(this.bSaturationMinus, 1, 0);
            this.tlpSaturation.Controls.Add(this.bSaturationPlus, 2, 0);
            this.tlpSaturation.Controls.Add(this.tlpSaturationLabels, 0, 0);
            this.tlpSaturation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSaturation.Location = new System.Drawing.Point(3, 60);
            this.tlpSaturation.Name = "tlpSaturation";
            this.tlpSaturation.RowCount = 1;
            this.tlpSaturation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSaturation.Size = new System.Drawing.Size(241, 51);
            this.tlpSaturation.TabIndex = 8;
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
            this.bSaturationMinus.TabStop = false;
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
            this.bSaturationPlus.TabStop = false;
            this.bSaturationPlus.Text = "+";
            this.bSaturationPlus.UseVisualStyleBackColor = false;
            this.bSaturationPlus.Click += new System.EventHandler(this.bSaturationPlus_Click);
            // 
            // tlpSaturationLabels
            // 
            this.tlpSaturationLabels.ColumnCount = 1;
            this.tlpSaturationLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSaturationLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSaturationLabels.Controls.Add(this.lbSaturationValue, 0, 1);
            this.tlpSaturationLabels.Controls.Add(this.lbSaturation, 0, 0);
            this.tlpSaturationLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSaturationLabels.Location = new System.Drawing.Point(3, 3);
            this.tlpSaturationLabels.Name = "tlpSaturationLabels";
            this.tlpSaturationLabels.RowCount = 2;
            this.tlpSaturationLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSaturationLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSaturationLabels.Size = new System.Drawing.Size(114, 45);
            this.tlpSaturationLabels.TabIndex = 3;
            // 
            // lbSaturationValue
            // 
            this.lbSaturationValue.AutoSize = true;
            this.lbSaturationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSaturationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSaturationValue.ForeColor = System.Drawing.Color.White;
            this.lbSaturationValue.Location = new System.Drawing.Point(3, 22);
            this.lbSaturationValue.Name = "lbSaturationValue";
            this.lbSaturationValue.Size = new System.Drawing.Size(108, 23);
            this.lbSaturationValue.TabIndex = 4;
            this.lbSaturationValue.Text = "0%";
            this.lbSaturationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSaturation
            // 
            this.lbSaturation.AutoSize = true;
            this.lbSaturation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaturation.ForeColor = System.Drawing.Color.White;
            this.lbSaturation.Location = new System.Drawing.Point(0, 0);
            this.lbSaturation.Margin = new System.Windows.Forms.Padding(0);
            this.lbSaturation.Name = "lbSaturation";
            this.lbSaturation.Size = new System.Drawing.Size(114, 22);
            this.lbSaturation.TabIndex = 3;
            this.lbSaturation.Text = "Saturation";
            this.lbSaturation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpBrightness
            // 
            this.tlpBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tlpBrightness.ColumnCount = 3;
            this.tlpBrightness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBrightness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBrightness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBrightness.Controls.Add(this.bBrightnessMinus, 1, 0);
            this.tlpBrightness.Controls.Add(this.bBrightnessPlus, 2, 0);
            this.tlpBrightness.Controls.Add(this.tlpBrightnessLabels, 0, 0);
            this.tlpBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBrightness.Location = new System.Drawing.Point(3, 3);
            this.tlpBrightness.Name = "tlpBrightness";
            this.tlpBrightness.RowCount = 1;
            this.tlpBrightness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBrightness.Size = new System.Drawing.Size(241, 51);
            this.tlpBrightness.TabIndex = 7;
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
            this.bBrightnessMinus.TabStop = false;
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
            this.bBrightnessPlus.TabStop = false;
            this.bBrightnessPlus.Text = "+";
            this.bBrightnessPlus.UseVisualStyleBackColor = false;
            this.bBrightnessPlus.Click += new System.EventHandler(this.bBrightnessPlus_Click);
            // 
            // tlpBrightnessLabels
            // 
            this.tlpBrightnessLabels.ColumnCount = 1;
            this.tlpBrightnessLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBrightnessLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBrightnessLabels.Controls.Add(this.lbBrightnessValue, 0, 1);
            this.tlpBrightnessLabels.Controls.Add(this.lbBrightness, 0, 0);
            this.tlpBrightnessLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBrightnessLabels.Location = new System.Drawing.Point(3, 3);
            this.tlpBrightnessLabels.Name = "tlpBrightnessLabels";
            this.tlpBrightnessLabels.RowCount = 2;
            this.tlpBrightnessLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBrightnessLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBrightnessLabels.Size = new System.Drawing.Size(114, 45);
            this.tlpBrightnessLabels.TabIndex = 3;
            // 
            // lbBrightnessValue
            // 
            this.lbBrightnessValue.AutoSize = true;
            this.lbBrightnessValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBrightnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbBrightnessValue.ForeColor = System.Drawing.Color.White;
            this.lbBrightnessValue.Location = new System.Drawing.Point(3, 22);
            this.lbBrightnessValue.Name = "lbBrightnessValue";
            this.lbBrightnessValue.Size = new System.Drawing.Size(108, 23);
            this.lbBrightnessValue.TabIndex = 4;
            this.lbBrightnessValue.Text = "0%";
            this.lbBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBrightness
            // 
            this.lbBrightness.AutoSize = true;
            this.lbBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrightness.ForeColor = System.Drawing.Color.White;
            this.lbBrightness.Location = new System.Drawing.Point(0, 0);
            this.lbBrightness.Margin = new System.Windows.Forms.Padding(0);
            this.lbBrightness.Name = "lbBrightness";
            this.lbBrightness.Size = new System.Drawing.Size(114, 22);
            this.lbBrightness.TabIndex = 3;
            this.lbBrightness.Text = "Brightness";
            this.lbBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.bRotateLeft, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.bRotateRight, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbRotate, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 174);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(241, 51);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // bRotateLeft
            // 
            this.bRotateLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bRotateLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRotateLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.bRotateLeft.Image = global::GalleryApp.Properties.Resources.rotateLeft;
            this.bRotateLeft.Location = new System.Drawing.Point(123, 3);
            this.bRotateLeft.Name = "bRotateLeft";
            this.bRotateLeft.Size = new System.Drawing.Size(54, 45);
            this.bRotateLeft.TabIndex = 0;
            this.bRotateLeft.TabStop = false;
            this.bRotateLeft.UseVisualStyleBackColor = false;
            this.bRotateLeft.Click += new System.EventHandler(this.bRotateLeft_Click);
            // 
            // bRotateRight
            // 
            this.bRotateRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bRotateRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRotateRight.ForeColor = System.Drawing.SystemColors.Control;
            this.bRotateRight.Image = global::GalleryApp.Properties.Resources.rotateRight;
            this.bRotateRight.Location = new System.Drawing.Point(183, 3);
            this.bRotateRight.Name = "bRotateRight";
            this.bRotateRight.Size = new System.Drawing.Size(55, 45);
            this.bRotateRight.TabIndex = 1;
            this.bRotateRight.TabStop = false;
            this.bRotateRight.UseVisualStyleBackColor = false;
            this.bRotateRight.Click += new System.EventHandler(this.bRotateRight_Click);
            // 
            // lbRotate
            // 
            this.lbRotate.AutoSize = true;
            this.lbRotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRotate.ForeColor = System.Drawing.Color.White;
            this.lbRotate.Location = new System.Drawing.Point(3, 0);
            this.lbRotate.Name = "lbRotate";
            this.lbRotate.Size = new System.Drawing.Size(114, 51);
            this.lbRotate.TabIndex = 2;
            this.lbRotate.Text = "Rotate";
            this.lbRotate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpAuto
            // 
            this.tlpAuto.ColumnCount = 2;
            this.tlpAuto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAuto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAuto.Controls.Add(this.lbAutoContrast, 0, 0);
            this.tlpAuto.Controls.Add(this.cbAuto, 1, 0);
            this.tlpAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAuto.Location = new System.Drawing.Point(3, 117);
            this.tlpAuto.Name = "tlpAuto";
            this.tlpAuto.RowCount = 1;
            this.tlpAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpAuto.Size = new System.Drawing.Size(241, 51);
            this.tlpAuto.TabIndex = 11;
            // 
            // lbAutoContrast
            // 
            this.lbAutoContrast.AutoSize = true;
            this.lbAutoContrast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAutoContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutoContrast.ForeColor = System.Drawing.Color.White;
            this.lbAutoContrast.Location = new System.Drawing.Point(3, 0);
            this.lbAutoContrast.Name = "lbAutoContrast";
            this.lbAutoContrast.Size = new System.Drawing.Size(114, 51);
            this.lbAutoContrast.TabIndex = 1;
            this.lbAutoContrast.Text = "Auto Contrast";
            this.lbAutoContrast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAuto
            // 
            this.cbAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(171, 17);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(18, 17);
            this.cbAuto.TabIndex = 5;
            this.cbAuto.TabStop = false;
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tlpFlip
            // 
            this.tlpFlip.ColumnCount = 3;
            this.tlpFlip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFlip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFlip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFlip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFlip.Controls.Add(this.lbFlip, 0, 0);
            this.tlpFlip.Controls.Add(this.bHorizontalFlip, 1, 0);
            this.tlpFlip.Controls.Add(this.bVerticalFlip, 2, 0);
            this.tlpFlip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFlip.Location = new System.Drawing.Point(3, 231);
            this.tlpFlip.Name = "tlpFlip";
            this.tlpFlip.RowCount = 1;
            this.tlpFlip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFlip.Size = new System.Drawing.Size(241, 51);
            this.tlpFlip.TabIndex = 12;
            // 
            // lbFlip
            // 
            this.lbFlip.AutoSize = true;
            this.lbFlip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlip.ForeColor = System.Drawing.Color.White;
            this.lbFlip.Location = new System.Drawing.Point(3, 0);
            this.lbFlip.Name = "lbFlip";
            this.lbFlip.Size = new System.Drawing.Size(114, 51);
            this.lbFlip.TabIndex = 0;
            this.lbFlip.Text = "Flip";
            this.lbFlip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bHorizontalFlip
            // 
            this.bHorizontalFlip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHorizontalFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHorizontalFlip.ForeColor = System.Drawing.SystemColors.Control;
            this.bHorizontalFlip.Image = ((System.Drawing.Image)(resources.GetObject("bHorizontalFlip.Image")));
            this.bHorizontalFlip.Location = new System.Drawing.Point(123, 3);
            this.bHorizontalFlip.Name = "bHorizontalFlip";
            this.bHorizontalFlip.Size = new System.Drawing.Size(54, 45);
            this.bHorizontalFlip.TabIndex = 1;
            this.bHorizontalFlip.TabStop = false;
            this.bHorizontalFlip.UseVisualStyleBackColor = true;
            this.bHorizontalFlip.Click += new System.EventHandler(this.bHorizontalFlip_Click);
            // 
            // bVerticalFlip
            // 
            this.bVerticalFlip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bVerticalFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVerticalFlip.ForeColor = System.Drawing.SystemColors.Control;
            this.bVerticalFlip.Image = global::GalleryApp.Properties.Resources.flipHorizontal;
            this.bVerticalFlip.Location = new System.Drawing.Point(183, 3);
            this.bVerticalFlip.Name = "bVerticalFlip";
            this.bVerticalFlip.Size = new System.Drawing.Size(55, 45);
            this.bVerticalFlip.TabIndex = 2;
            this.bVerticalFlip.TabStop = false;
            this.bVerticalFlip.UseVisualStyleBackColor = true;
            this.bVerticalFlip.Click += new System.EventHandler(this.bVerticalFlip_Click);
            // 
            // tlpResize
            // 
            this.tlpResize.ColumnCount = 4;
            this.tlpResize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tlpResize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpResize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpResize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpResize.Controls.Add(this.lbResize, 0, 0);
            this.tlpResize.Controls.Add(this.tbWidth, 1, 0);
            this.tlpResize.Controls.Add(this.tbHeight, 2, 0);
            this.tlpResize.Controls.Add(this.bResizeOK, 3, 0);
            this.tlpResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResize.Location = new System.Drawing.Point(3, 288);
            this.tlpResize.Name = "tlpResize";
            this.tlpResize.RowCount = 1;
            this.tlpResize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResize.Size = new System.Drawing.Size(241, 51);
            this.tlpResize.TabIndex = 13;
            // 
            // lbResize
            // 
            this.lbResize.AutoSize = true;
            this.lbResize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResize.ForeColor = System.Drawing.Color.White;
            this.lbResize.Location = new System.Drawing.Point(0, 0);
            this.lbResize.Margin = new System.Windows.Forms.Padding(0);
            this.lbResize.Name = "lbResize";
            this.lbResize.Size = new System.Drawing.Size(103, 51);
            this.lbResize.TabIndex = 0;
            this.lbResize.Text = "Resize \r\nWidth Height";
            this.lbResize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbWidth
            // 
            this.tbWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWidth.Location = new System.Drawing.Point(103, 13);
            this.tbWidth.Margin = new System.Windows.Forms.Padding(0);
            this.tbWidth.MaxLength = 6;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(50, 24);
            this.tbWidth.TabIndex = 0;
            this.tbWidth.Text = "Width";
            this.tbWidth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbWidth_MouseClick);
            // 
            // tbHeight
            // 
            this.tbHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeight.Location = new System.Drawing.Point(153, 13);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(0);
            this.tbHeight.MaxLength = 6;
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(50, 24);
            this.tbHeight.TabIndex = 1;
            this.tbHeight.Text = "Height";
            this.tbHeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbHeight_MouseClick);
            // 
            // bResizeOK
            // 
            this.bResizeOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bResizeOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bResizeOK.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResizeOK.ForeColor = System.Drawing.SystemColors.Control;
            this.bResizeOK.Location = new System.Drawing.Point(203, 0);
            this.bResizeOK.Margin = new System.Windows.Forms.Padding(0);
            this.bResizeOK.Name = "bResizeOK";
            this.bResizeOK.Size = new System.Drawing.Size(38, 51);
            this.bResizeOK.TabIndex = 3;
            this.bResizeOK.TabStop = false;
            this.bResizeOK.Text = "OK";
            this.bResizeOK.UseVisualStyleBackColor = true;
            this.bResizeOK.Click += new System.EventHandler(this.bResizeOK_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.bBackWhite, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bGray, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 345);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(241, 51);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // bBackWhite
            // 
            this.bBackWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBackWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBackWhite.ForeColor = System.Drawing.SystemColors.Control;
            this.bBackWhite.Location = new System.Drawing.Point(120, 0);
            this.bBackWhite.Margin = new System.Windows.Forms.Padding(0);
            this.bBackWhite.Name = "bBackWhite";
            this.bBackWhite.Size = new System.Drawing.Size(121, 51);
            this.bBackWhite.TabIndex = 0;
            this.bBackWhite.TabStop = false;
            this.bBackWhite.Text = "Black/White";
            this.bBackWhite.UseVisualStyleBackColor = true;
            this.bBackWhite.Click += new System.EventHandler(this.bBackWhite_Click);
            // 
            // bGray
            // 
            this.bGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGray.ForeColor = System.Drawing.SystemColors.Control;
            this.bGray.Location = new System.Drawing.Point(0, 0);
            this.bGray.Margin = new System.Windows.Forms.Padding(0);
            this.bGray.Name = "bGray";
            this.bGray.Size = new System.Drawing.Size(120, 51);
            this.bGray.TabIndex = 1;
            this.bGray.TabStop = false;
            this.bGray.Text = "Gray Scale";
            this.bGray.UseVisualStyleBackColor = true;
            this.bGray.Click += new System.EventHandler(this.bGray_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.bSave, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.bReset, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 630);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(241, 57);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // bSave
            // 
            this.bSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.SystemColors.Control;
            this.bSave.Location = new System.Drawing.Point(0, 0);
            this.bSave.Margin = new System.Windows.Forms.Padding(0);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(120, 57);
            this.bSave.TabIndex = 9;
            this.bSave.TabStop = false;
            this.bSave.Text = "Save changes";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bReset
            // 
            this.bReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.ForeColor = System.Drawing.SystemColors.Control;
            this.bReset.Location = new System.Drawing.Point(120, 0);
            this.bReset.Margin = new System.Windows.Forms.Padding(0);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(121, 57);
            this.bReset.TabIndex = 15;
            this.bReset.TabStop = false;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-7, -3);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tlpMenu.ResumeLayout(false);
            this.tlpSaturation.ResumeLayout(false);
            this.tlpSaturationLabels.ResumeLayout(false);
            this.tlpSaturationLabels.PerformLayout();
            this.tlpBrightness.ResumeLayout(false);
            this.tlpBrightnessLabels.ResumeLayout(false);
            this.tlpBrightnessLabels.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tlpAuto.ResumeLayout(false);
            this.tlpAuto.PerformLayout();
            this.tlpFlip.ResumeLayout(false);
            this.tlpFlip.PerformLayout();
            this.tlpResize.ResumeLayout(false);
            this.tlpResize.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Label lbAutoContrast;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.TableLayoutPanel tlpBrightness;
        private System.Windows.Forms.Label lbBrightnessValue;
        private System.Windows.Forms.Label lbBrightness;
        private System.Windows.Forms.Button bBrightnessMinus;
        private System.Windows.Forms.Button bBrightnessPlus;
        private System.Windows.Forms.TableLayoutPanel tlpSaturation;
        private System.Windows.Forms.Label lbSaturationValue;
        private System.Windows.Forms.Label lbSaturation;
        private System.Windows.Forms.Button bSaturationMinus;
        private System.Windows.Forms.Button bSaturationPlus;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button bRotateLeft;
        private System.Windows.Forms.Button bRotateRight;
        private System.Windows.Forms.Label lbRotate;
        private System.Windows.Forms.TableLayoutPanel tlpAuto;
        private System.Windows.Forms.TableLayoutPanel tlpFlip;
        private System.Windows.Forms.Label lbFlip;
        private System.Windows.Forms.Button bHorizontalFlip;
        private System.Windows.Forms.Button bVerticalFlip;
        private System.Windows.Forms.TableLayoutPanel tlpSaturationLabels;
        private System.Windows.Forms.TableLayoutPanel tlpBrightnessLabels;
        private System.Windows.Forms.TableLayoutPanel tlpResize;
        private System.Windows.Forms.Label lbResize;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Button bResizeOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bBackWhite;
        private System.Windows.Forms.Button bGray;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button bReset;
    }
}