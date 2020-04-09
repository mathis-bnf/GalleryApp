using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GalleryApp
{
    public partial class ImagesProperties : Form
    {
        private Photos photo;
        private Image image;

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

        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public ImagesProperties()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charges and displays iamge properties
        /// </summary>
        public void initialization()
        {
            Image = System.Drawing.Image.FromFile(photo.FullPath);
            lbFilename.Text = photo.Name;
            // Date : 0x0132            
            lbDate.Text = Encoding.UTF8.GetString(Image.GetPropertyItem(0x0132).Value);
            lbDimensions.Text = Image.Width + "x" + Image.Height;
            Folder folder = SQLRequests.selectParentFolder(photo);

            FileInfo fi = new FileInfo(photo.FullPath);
            lbSize.Text = Math.Round(fi.Length/1048576.0, 2).ToString()+" MB";
            lbPlace.Text = folder.Place;
            this.Show();
        }
    }
}
