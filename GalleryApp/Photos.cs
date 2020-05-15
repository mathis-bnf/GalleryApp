using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GalleryApp
{
    class Photos
    {
        private String folder;
        private String name;
        private String fullPath;
        private String alias;

        public string Folder
        {
            get
            {
                return folder;
            }

            set
            {
                folder = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string FullPath
        {
            get
            {
                return fullPath;
            }

            set
            {
                fullPath = value;
            }
        }

        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
            }
        }

        public DateTime GetDate()
        {
            try
            {
                using (FileStream fs = new FileStream(FullPath, FileMode.Open, FileAccess.Read))
                using (Image im = Image.FromStream(fs, false, false))
                {
                    String[] date = Encoding.UTF8.GetString(im.GetPropertyItem(0x0132).Value).Split(':');
                    String[] dayHour = date[2].Split(' ');
                    return new DateTime(Int32.Parse(date[0]), Int32.Parse(date[1]), Int32.Parse(dayHour[0]), Int32.Parse(dayHour[1]), Int32.Parse(date[3]), Int32.Parse(date[4]));
                }
            
            }
            catch (ArgumentException e)
            {
                return File.GetCreationTime(FullPath);
            }
        }
    }
}
