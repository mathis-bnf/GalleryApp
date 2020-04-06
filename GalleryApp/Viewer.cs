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
    public partial class Viewer : Form
    {
        private Photos photo;
        private List<Photos> photoList;
        private int imageIndex;

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
        }

        public void initializePictureBoxImage()
        {
            if (!String.IsNullOrEmpty(photo.Name))
            {
                Image img = Image.FromFile(photo.FullPath);
                pictureBox1.Image = img;
                pictureBox1.Refresh();
                
            }
            getImageIndex();
            setPictureBoxImage();
        }
        
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

        private void setPictureBoxImage()
        {
            Bitmap bmp = new Bitmap(photoList[imageIndex].FullPath);
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void Viewer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {            
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        rightClickMenuStrip.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
                    }
                    break;
            }        
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImagesProperties param = new ImagesProperties();
            param.Photo = photo;
            param.initialization();
        }
    }
}
