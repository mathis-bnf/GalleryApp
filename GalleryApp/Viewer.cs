using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace GalleryApp
{
    public partial class Viewer : Form
    {
        private Photos photo;
        private List<Photos> photoList;
        private int imageIndex;
        private Cyotek.Windows.Forms.ImageBox imb = new Cyotek.Windows.Forms.ImageBox();

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
                    }
                    else if (style.Width == 15)
                    {
                        style.SizeType = SizeType.Percent;
                        style.Width = 2;
                    }
                }
                
                i++;
            }
        }

        private void tbBrightness_Scroll(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                int value = 10 * (tbBrightness.Value - 10);
                if (value > 0)
                    lbBrightnessValue.Text = "+" + (value).ToString() + "%";
                else
                    lbBrightnessValue.Text = (value).ToString() + "%";

                Image<Rgb, Byte> image = new Image<Rgb, byte>(new Bitmap(photo.FullPath));
                image = image.Mul(1 + (value / 100f));
                imb.Image = image.Bitmap;
                imb.ZoomIn(true);
                imb.ZoomToFit();
            }
            else
            {
                int value = 10 * (tbBrightness.Value - 10);
                if (value > 0)
                    lbBrightnessValue.Text = "+" + (value).ToString() + "%";
                else
                    lbBrightnessValue.Text = (value).ToString() + "%";

                Image<Rgb, Byte> image = new Image<Rgb, byte>(new Bitmap(imb.Image));
                image = image.Mul(1 + (value / 100f));
                imb.Image = image.Bitmap;
                imb.ZoomIn(true);
                imb.ZoomToFit();
            }
        }
        private void HistEq()
        {
            Image<Rgb, Byte> inputImage = new Image<Rgb, byte>(new Bitmap(photo.FullPath));
            inputImage._EqualizeHist();
            imb.Image = inputImage.Bitmap;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                HistEq();
            }
            else
            {
                Image<Rgb, Byte> inputImage = new Image<Rgb, byte>(new Bitmap(photo.FullPath));
                imb.Image = inputImage.Bitmap;
            }

        }
    }
}
