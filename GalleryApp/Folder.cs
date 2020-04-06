using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryApp
{
    class Folder
    {
        private int year;
        private String name;
        private String fullPath;
        private String place;

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
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

        public string Place
        {
            get
            {
                return place;
            }

            set
            {
                place = value;
            }
        }
    }
}
