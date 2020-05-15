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
        
        public ImagesProperties()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charges and displays iamge properties
        /// </summary>
        public void initialization()
        {
            using (FileStream fs = new FileStream(Photo.FullPath, FileMode.Open, FileAccess.Read))
            using (Image image = Image.FromStream(fs, false, false))
            {
                lbFilename.Text = photo.Name;
                try
                {
                    // Prise de vue : 0x0132 
                    lbDate.Text = Encoding.UTF8.GetString(image.GetPropertyItem(0x0132).Value);
                }
                catch (ArgumentException e)
                {
                    lbDate.Text = File.GetCreationTime(photo.FullPath).ToString();
                }
                lbDimensions.Text = image.Width + "x" + image.Height;
                Folder folder = SQLRequests.selectParentFolder(photo);

                FileInfo fi = new FileInfo(photo.FullPath);
                lbSize.Text = Math.Round(fi.Length / 1048576.0, 2).ToString() + " MB";
                lbPlace.Text = folder.Place;
                this.Show();
            }
        }
    }
}
