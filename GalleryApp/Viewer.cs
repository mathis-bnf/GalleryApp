using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleryApp
{
    partial class Viewer : Form
    {
        private Photos photo;
        private List<Photos> photoList;
        private int imageIndex;
        private Cyotek.Windows.Forms.ImageBox imb;
        private Yolo detector;
        BackgroundWorker bgwYolo;

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

        internal Yolo Detector
        {
            get
            {
                return detector;
            }

            set
            {
                detector = value;
            }
        }

        public Viewer()
        {
            InitializeComponent();
            imb = new Cyotek.Windows.Forms.ImageBox();
            tableLayoutPanel1.Controls.Add(imb);
            imb.Dock = DockStyle.Fill;
            imb.GridColor = Color.FromArgb(10,10,10);
            imb.GridColorAlternate = Color.FromArgb(10,10,10);
            imb.Padding = new Padding(0);
            imb.BorderStyle = BorderStyle.FixedSingle;
            imb.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            imb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.imb_PreviewKeyDown);
            bgwYolo = new BackgroundWorker();
        }

        /// <summary>
        /// Charges image into pictureBox and get image index (in the image list)
        /// </summary>
        private void initializePictureBoxImage()
        {
            if (!String.IsNullOrEmpty(photo.Name))
            {
                getImageIndex();
                setPictureBoxImage();
            }
        }

        public void initialize()
        {
            initializePictureBoxImage();
        }

        public void initialize(Yolo objectDetector)
        {
            this.Detector = objectDetector;
            initializePictureBoxImage();
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
            detectObjects();
        }

        private void detectObjects()
        {
            if (!bgwYolo.IsBusy)
            {
                bgwYolo = new BackgroundWorker();
                bgwYolo.DoWork += new DoWorkEventHandler(bgwYolo_DoWork);

                bgwYolo.RunWorkerAsync();
                bgwYolo.Dispose();
            }
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
        
        /// <summary>
        /// Opens properties dialog when menu strip is clicked
        /// </summary>
        private void propertiesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ImagesProperties param = new ImagesProperties();
            param.Photo = photo;
            param.initialization();
        }

        #region BackGroundWorker methods
        /// <summary>
        /// BackgroundWorker used for YOLO to detect objects in photos
        /// </summary>
        private void bgwYolo_DoWork(object sender, DoWorkEventArgs e)
        {
            detector.detect(this.Photo);
        }
        #endregion
    }
}
