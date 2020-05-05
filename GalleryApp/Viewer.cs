using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace GalleryApp
{
    public partial class Viewer : Form
    {
        private Photos photo;
        private List<Photos> photoList;
        private int imageIndex;
        private Cyotek.Windows.Forms.ImageBox imb = new Cyotek.Windows.Forms.ImageBox();
        private int brightnessPercent = 0;
        private int saturationPercent = 0;

        internal Photos Photo
        {
            get
            {
                return photo;
            }

            set
            {
                photo = value;
            }
        }

        internal List<Photos> PhotoList
        {
            get
            {
                return photoList;
            }

            set
            {
                photoList = value;
            }
        }

        internal int BrightnessPercent
        {
            get
            {
                return brightnessPercent;
            }

            set
            {
                brightnessPercent = value;
            }
        }

        internal int SaturationPercent
        {
            get
            {
                return saturationPercent;
            }

            set
            {
                saturationPercent = value;
            }
        }
        
        public Viewer()
        {
            InitializeComponent();
            tlpImage.Controls.Add(imb);
            imb.Dock = DockStyle.Fill;
            imb.GridColor = Color.FromArgb(10,10,10);
            imb.GridColorAlternate = Color.FromArgb(10,10,10);
            imb.Padding = new Padding(0);
            imb.BorderStyle = BorderStyle.FixedSingle;
            imb.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            imb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.imb_PreviewKeyDown);
            imb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            makeMenuTransparent();
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));                
            }
        }

        /// <summary>
        /// Charges image into pictureBox and get image index (in the image list)
        /// </summary>
        public void initializePictureBoxImage()
        {
            if (!String.IsNullOrEmpty(photo.Name))
            {
                getImageIndex();
                setPictureBoxImage();
            }
        }

        /// <summary>
        /// Gets image index (in the image list)
        /// </summary>
        private void getImageIndex()
        {
            if (photoList.Count > 0)
            {
                int index = 0;
                for (index = 0; index < photoList.Count; index++)
                {
                    if (photoList[index].Name == photo.Name)
                        break;
                }
                imageIndex = index;
            }
        }

        /// <summary>
        /// Sets picturebox image
        /// </summary>
        private void setPictureBoxImage()
        {
            Bitmap bmp = new Bitmap(photoList[imageIndex].FullPath);
            photo = photoList[imageIndex];
            imb.Image = bmp;
            imb.ZoomIn(true);
            imb.ZoomToFit();
        }

        /// <summary>
        /// Sets previous image (in the list) to the picturebox when left button is clicked
        /// </summary>
        private void bPreviousPhoto_Click(object sender, EventArgs e)
        {
            if (imageIndex > 0)
            {
                imageIndex--;
            }
            else
            {
                imageIndex = photoList.Count - 1;
            }
            this.setPictureBoxImage();
            this.ActiveControl = imb;
            BrightnessPercent = 0;
            SaturationPercent = 0;
            updateSaturationValueLabel();
            updateBrightlessValueLabel();
        }

        /// <summary>
        /// Sets next image (in the list) to the picturebox when right button is clicked
        /// </summary>
        private void bNextPhoto_Click(object sender, EventArgs e)
        {
            if (imageIndex < photoList.Count - 1)
            {
                imageIndex++;
            }
            else
            {
                imageIndex = 0;
            }
            this.setPictureBoxImage();
            this.ActiveControl = imb;
            BrightnessPercent = 0;
            SaturationPercent = 0;
            updateSaturationValueLabel();
            updateBrightlessValueLabel();
        }

        /// <summary>
        /// Sets previous or next image (in the list) to the picturebox when left or right keyboard ket is clicked
        /// </summary>
        private void imb_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    {
                        if (imageIndex < photoList.Count - 1)
                        {
                            imageIndex++;
                        }
                        else
                        {
                            imageIndex = 0;
                        }
                        setPictureBoxImage();
                    }
                    break;

                case Keys.Left:
                    {
                        if (imageIndex > 0)
                        {
                            imageIndex--;
                        }
                        else
                        {
                            imageIndex = photoList.Count - 1;
                        }
                        setPictureBoxImage();
                    }
                    break;

                default:
                    break;
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImagesProperties param = new ImagesProperties();
            param.Photo = photo;
            param.initialization();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableLayoutColumnStyleCollection styles = tlpBackGround.ColumnStyles;
            int i = 0;
            foreach (ColumnStyle style in styles)
            {
                if (i == 1 )
                {
                    if (style.Width == 2)
                    {
                        style.SizeType = SizeType.Percent;
                        style.Width = 15;
                        makeMenuVisible();
                    }
                    else if (style.Width == 15)
                    {
                        style.SizeType = SizeType.Percent;
                        style.Width = 2;
                        makeMenuTransparent();
                    }
                }                
                i++;
            }
            this.ActiveControl = imb;
        }      

        private Bitmap HistEq()
        {
            Image<Rgb, Byte> inputImage = new Image<Rgb, byte>(new Bitmap(photo.FullPath));
            inputImage._EqualizeHist();
            return inputImage.Bitmap;
        }

        private Bitmap changeBrightness(Bitmap bmp, int value)
        {
            Image<Rgb, Byte> image = new Image<Rgb, byte>(bmp);
            Image<Rgb, Byte> addImage = new Image<Rgb, byte>(image.Width, image.Height);
            
            if (value < 0)
            {
                addImage.SetValue(new Rgb(-value, -value, -value));
                image = image.Sub(addImage);
            }
            else
            {
                addImage.SetValue(new Rgb(value, value, value));
                image = image.Add(addImage);
            }
                
            return image.Bitmap;
        }

        private Bitmap changeSaturation(Bitmap bmp, int value)
        {
            Image<Hsv, byte> image = new Image<Hsv, byte>(bmp);

            if (value > 0)
            {
                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        if (image.Data[j, i, 1] >= 245)
                        {
                            image.Data[j, i, 1] += 255;
                        }
                        else if (image.Data[j, i, 1] < 245 && image.Data[j, i, 1] > 20)
                        {
                            image.Data[j, i, 1] += (byte)value;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        if (image.Data[j, i, 1] <= 10)
                        {
                            image.Data[j, i, 1] += 0;
                        }
                        else
                        {
                            image.Data[j, i, 1] += (byte)value;
                        }
                    }
                }
            }            
            return image.Bitmap;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAuto.Checked)
            {
                imb.Image = HistEq();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("All changes will be lost. Do you want to continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
                Image<Rgb, Byte> inputImage = new Image<Rgb, byte>(new Bitmap(photo.FullPath));                
                imb.Image = inputImage.Bitmap;
            }
            this.ActiveControl = imb;
        }

        private void bBrightnessMinus_Click(object sender, EventArgs e)
        {
            BrightnessPercent -= 10;
            updateBrightlessValueLabel();
            Bitmap image = changeBrightness(new Bitmap(imb.Image), -10);

            imb.Image = image;
            imb.ZoomIn(true);
            imb.ZoomToFit();
            this.ActiveControl = imb;
        }

        private void bBrightnessPlus_Click(object sender, EventArgs e)
        {
            BrightnessPercent += 10;
            updateBrightlessValueLabel();
            Bitmap image = changeBrightness(new Bitmap(imb.Image), 10);

            imb.Image = image;
            imb.ZoomIn(true);
            imb.ZoomToFit();
            this.ActiveControl = imb;
        }

        private void bSaturationPlus_Click(object sender, EventArgs e)
        {
            SaturationPercent += 10;
            updateSaturationValueLabel();
            imb.Image = changeSaturation(new Bitmap(imb.Image), 10);
            imb.ZoomIn(true);
            imb.ZoomToFit();
            this.ActiveControl = imb;
        }

        private void bSaturationMinus_Click(object sender, EventArgs e)
        {
            SaturationPercent -= 10;
            updateSaturationValueLabel();
            imb.Image = changeSaturation(new Bitmap(imb.Image), -10);
            imb.ZoomIn(true);
            imb.ZoomToFit();
            this.ActiveControl = imb;
        }

        private void makeMenuTransparent()
        {
            tableLayoutPanel2.Visible = false;
            this.ActiveControl = imb;
        }

        private void makeMenuVisible()
        {
            tableLayoutPanel2.Visible = true;
            this.ActiveControl = imb;
        }

        private void updateBrightlessValueLabel()
        {
            lbBrightnessValue.Text = BrightnessPercent.ToString() + " %";
        }

        private void updateSaturationValueLabel()
        {
            lbSaturationValue.Text = SaturationPercent.ToString() + " %";
        }
    }
}
