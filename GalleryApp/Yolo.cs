using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alturos.Yolo;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace GalleryApp
{
    public class Yolo
    {
        YoloWrapper yoloWrapper;
        private Photos photo;

        public Photos Photo
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

        public Yolo()
        {
            yoloWrapper = new YoloWrapper("yolov3.cfg", "yolov3.weights", "obj.names", 0, false);
        }

        public void detect(Photos photo)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Photo = photo;
            System.Collections.Generic.IEnumerable<Alturos.Yolo.Model.YoloItem> items;
            items = yoloWrapper.Detect(this.Photo.FullPath);
            HashSet<string> hs = new HashSet<string>();
            foreach (Alturos.Yolo.Model.YoloItem it in items)
            {
                if (it.Confidence>0.25)
                    hs.Add(it.Type+" "+it.Confidence);
            }
            sw.Stop();
            foreach (string type in hs)
            {
                MessageBox.Show(type);
            }
            MessageBox.Show(sw.ElapsedMilliseconds.ToString());
        }
    }
}
