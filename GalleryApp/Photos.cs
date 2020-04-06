using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
