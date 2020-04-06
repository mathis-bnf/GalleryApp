using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleryApp
{
    public partial class SelectNewFolder : Form
    {
        private String folderPath;
        private int year = -1;
        private String place;

        public SelectNewFolder()
        {
            InitializeComponent();            
        }

        private void bFolder_Click(object sender, EventArgs e)
        {
            bFolder.ForeColor = Color.Black;
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    folderPath = folderBrowserDialog.SelectedPath;
                    bFolder.Text = new DirectoryInfo(folderPath).Name;                 
                }
            }            
        }

        public String getFolderPath()
        {
            return folderPath;
        }

        public int getYear()
        {
            return year;
        }

        public String getPlace()
        {
            return place;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            lYear.ForeColor = Color.Black;
            if (tbYear.Text != "" && !String.IsNullOrEmpty(folderPath))
            {
                year = Int32.Parse(tbYear.Text);
                place = tbPlace.Text;
                this.Close();
            }            
            else
            {
                if(tbYear.Text=="")
                    lYear.ForeColor = Color.Red;
                if(String.IsNullOrEmpty(folderPath))
                    bFolder.ForeColor = Color.Red;
                lRequiredFields.ForeColor = Color.Red;
            }
        }
    }
}
