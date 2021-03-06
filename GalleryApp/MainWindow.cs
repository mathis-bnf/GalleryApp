﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GalleryApp
{
    public partial class MainWindow : Form
    {
        ProgressDialog progressDialog;
        BackgroundWorker bgw1 = new BackgroundWorker();

        #region BackGroundWorker methods

        /// <summary>
        /// BackgroundWorker used to charge images in the ListView
        /// </summary>
        private void bgw1_DoWork(object sender, DoWorkEventArgs e)
        {
            displayImages();
        }

        /// <summary>
        /// Update Progress bar
        /// </summary>
        private void bgw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressDialog.updateProgress(e.ProgressPercentage);
        }

        /// <summary>
        /// Close progress bar
        /// </summary>
        private void bgw1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressDialog.Dispose();
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            if (!Directory.Exists(@".\Cache"))
            {
                DirectoryInfo di = new DirectoryInfo(@".\Cache");
                di.Create();
                di.Attributes |= FileAttributes.Hidden;
            }
            updateTreeViewNodes();
            searchForNewPhotos();
            //cbOrderBy.SelectedItem = cbOrderBy.Items[0];            
        }

        public void searchForNewPhotos()
        {
            TreeNodeCollection years = tvFolders.Nodes;
            foreach (TreeNode year in years)
            {
                TreeNodeCollection folders = year.Nodes;
                foreach (TreeNode folder in folders)
                {
                    String fullPath = SQLRequests.selectFolderFullPath(folder.Text, Int32.Parse(year.Text));
                    SQLRequests.addNewPhotos(fullPath);
                }
            }
        }
        
        /// <summary>
        /// Updates the MainWindow's TreeView with data from DB
        /// </summary>
        public void updateTreeViewNodes()
        {
            tvFolders.Nodes.Clear();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<YearFolder> years = SQLRequests.selectAllFromYearFolder();
            for (int i = 0; i < years.Count; i++)
            {
                tvFolders.Nodes.Add(String.Format("{0}", years[i].Year));
                dic.Add(i, (int)years[i].Year);

                string path = @".\Cache\" + years[i].Year;
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            List<String> names = new List<String>();
            string queryStringFolders = "SELECT *  FROM Folder";
            string connectionString = @"Server=localhost;Database=GalleryDB;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commandFolders = new SqlCommand(queryStringFolders, connection);
                connection.Open();
                SqlDataReader readerFolders = commandFolders.ExecuteReader();
                int count = 0;
                try
                {
                    while (readerFolders.Read())
                    {
                        for (int ind = 0; ind < dic.Count; ind++)
                        {
                            if ((int)readerFolders["Year"] == dic[ind])
                            {
                                names.Add(String.Format("{0}", readerFolders["Name"]));
                                tvFolders.Nodes[ind].Nodes.Add(String.Format("{0}", names[count]));


                                string path = @".\Cache\" + dic[ind] + @"\" + names[count];
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);
                            }
                        }
                        count++;
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    readerFolders.Close();
                }
                connection.Close();
            }
        }
        
        /// <summary>
        /// Opens new folder dialog and insert it into DB
        /// </summary>
        private void bNewAlbum_Click(object sender, EventArgs e)
        {
            SelectNewFolder f = new GalleryApp.SelectNewFolder();
            f.ShowDialog();
            String fullPath = f.getFolderPath();
            int year = f.getYear();
            String place = f.getPlace();
            if (fullPath != null && year != -1)
            {
                if (!SQLRequests.isFolderExisting(fullPath))
                {
                    SQLRequests.insertNewFolder(fullPath, year, place);
                    updateTreeViewNodes();
                }
                else
                {
                    MessageBox.Show("This album already exists");
                }            
            }
        }

        private List<Photos> orderPhotoList(List<Photos> files)
        {
            if (cbOrderBy.SelectedItem == cbOrderBy.Items[0])
                files.Sort((x, y) => string.Compare(x.Name, y.Name));
            else if (cbOrderBy.SelectedItem == cbOrderBy.Items[1])
            {
                files.Sort((x, y) => string.Compare(x.Name, y.Name));
                files.Reverse();
            }
            else if (cbOrderBy.SelectedItem == cbOrderBy.Items[2])
                files.Sort((x, y) => DateTime.Compare(x.GetDate(), y.GetDate()));
            else if (cbOrderBy.SelectedItem == cbOrderBy.Items[3])
            {
                files.Sort((x, y) => DateTime.Compare(x.GetDate(), y.GetDate()));
                files.Reverse();
            }
            return files;
        }

        /// <summary>
        /// Displays all images in ListView from TreeView selected folder
        /// </summary>
        public void displayImages()
        {
            imageList.Images.Clear();
            lvImages.Clear();
            List<Photos> files = new List<Photos>();            
            files = SQLRequests.selectImagesFromFolder(tvFolders.SelectedNode.Text, Int32.Parse(tvFolders.SelectedNode.Parent.Text));
            orderPhotoList(files);
            Size s = new Size(100, 75);
            byte[] bytes = { };
            MemoryStream ms;
            for (int indPhoto = 0; indPhoto < files.Count; indPhoto++)
            {
                string path = @".\Cache\" + tvFolders.SelectedNode.Parent.Text + @"\" + tvFolders.SelectedNode.Text + @"\";
                if (String.IsNullOrEmpty(files[indPhoto].Alias))
                {
                    if (File.Exists(files[indPhoto].FullPath))
                    {
                        FileInfo fileInfo = new FileInfo(files[indPhoto].FullPath);
                        Bitmap img = new Bitmap(files[indPhoto].FullPath);
                        double ratioWH = img.Size.Width / (double)img.Size.Height;
                        Bitmap png = new Bitmap(100, 75);
                        if (ratioWH >= 1)
                        {
                            img = new Bitmap(img, 100, (int)(100 / ratioWH));
                            using (Graphics G = Graphics.FromImage(png))
                                G.DrawImage(img, 0, png.Height / 2 - img.Height / 2);
                        }
                        else
                        {
                            img = new Bitmap(img, (int)(75 * ratioWH), 75);
                            using (Graphics G = Graphics.FromImage(png))
                                G.DrawImage(img, png.Width / 2 - img.Width / 2, 0);
                        }

                        Icon ic = Icon.FromHandle(png.GetHicon());

                        imageList.Images.Add(ic);
                        lvImages.Items.Add(fileInfo.Name, indPhoto);
                        if (bgw1.IsBusy)
                            bgw1.ReportProgress(100 * (indPhoto + 1) / files.Count);

                        path += files[indPhoto].Name;
                        int resultUpdate = SQLRequests.updatePhotoAlias(path, files[indPhoto].FullPath);
                        if (resultUpdate >= 0)
                            img.Save(path);
                    }
                    else
                    {
                        SQLRequests.deletePhoto(files[indPhoto].FullPath);
                    }
                }
                else
                {
                    path += files[indPhoto].Name;
                    FileInfo fileInfo = new FileInfo(path);

                    bytes = File.ReadAllBytes(path);
                    ms = new MemoryStream(bytes);
                    Bitmap img = new Bitmap(Image.FromStream(ms));
                    double ratioWH = img.Size.Width / (double)img.Size.Height;
                    Bitmap png = new Bitmap(100, 75);
                    if (ratioWH >= 1)
                    {
                        img = new Bitmap(img, 100, (int)(100 / ratioWH));
                        using (Graphics G = Graphics.FromImage(png))
                            G.DrawImage(img, 0, png.Height / 2 - img.Height / 2);
                    }
                    else
                    {
                        img = new Bitmap(img, (int)(75 * ratioWH), 75);
                        using (Graphics G = Graphics.FromImage(png))
                            G.DrawImage(img, png.Width / 2 - img.Width / 2, 0);
                    }

                    Icon ic = Icon.FromHandle(png.GetHicon());

                    imageList.Images.Add(ic);
                    lvImages.Items.Add(fileInfo.Name, indPhoto);
                    if (bgw1.IsBusy)
                        bgw1.ReportProgress(100 * (indPhoto + 1) / files.Count);
                }
            }
        }

        /// <summary>
        /// Selects clicked image and charge it into new image Viewer
        /// </summary>
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Viewer viewer = new Viewer(this);
            viewer.Photo = SQLRequests.selectOneImage(tvFolders.SelectedNode.Text, lvImages.SelectedItems[0].Text);
            viewer.PhotoList = SQLRequests.selectImagesFromFolder(tvFolders.SelectedNode.Text, Int32.Parse(tvFolders.SelectedNode.Parent.Text));
            viewer.initializePictureBoxImage();
            viewer.Show();
            viewer.Focus();
        }

        /// <summary>
        /// Deletes cached data
        /// </summary>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SQLRequests.deletePhotoAlias() >= 0)
            {
                Directory.Delete(@".\Cache", true);
            }
        }

        /// <summary>
        /// Calls the method to display images in the ListView and display a progress bar
        /// </summary>
        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!bgw1.IsBusy)
            {
                bgw1 = new BackgroundWorker();
                bgw1.DoWork += new DoWorkEventHandler(bgw1_DoWork);
                bgw1.ProgressChanged += new ProgressChangedEventHandler(bgw1_ProgressChanged);
                bgw1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw1_RunWorkerCompleted);
                bgw1.WorkerReportsProgress = true;

                progressDialog = new ProgressDialog();
                progressDialog.Show();
                progressDialog.TopMost = true;

                bgw1.RunWorkerAsync();
                bgw1.Dispose();
            }
        }

        /// <summary>
        /// Calls the method to delete an album
        /// </summary>
        private void bDeleteAlbum_Click(object sender, EventArgs e)
        {
            albumDeletion();                  
        }

        /// <summary>
        /// Deletes the selected folder in the TreeView
        /// </summary>
        private void albumDeletion()
        {
            if (tvFolders.Nodes.Count > 0)
            {
                if (tvFolders.SelectedNode != null && tvFolders.SelectedNode.Parent != null)
                {
                    if (SQLRequests.isFolderExisting(tvFolders.SelectedNode.Text, Int32.Parse(tvFolders.SelectedNode.Parent.Text)))
                    {
                        DialogResult dialogResult = MessageBox.Show("Do you really want to delete this album ?", "Album delete", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            int res = SQLRequests.deleteFolder(tvFolders.SelectedNode.Text, Int32.Parse(tvFolders.SelectedNode.Parent.Text));
                            Directory.Delete(@".\Cache\" + tvFolders.SelectedNode.Parent.Text + @"\" + tvFolders.SelectedNode.Text, true);
                            updateTreeViewNodes();
                            imageList.Images.Clear();
                            lvImages.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid folder");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid folder");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid folder");
            }
        }

        private void cbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.imageList.Images.Count > 0)
            {
                if (!bgw1.IsBusy)
                {
                    bgw1 = new BackgroundWorker();
                    bgw1.DoWork += new DoWorkEventHandler(bgw1_DoWork);
                    bgw1.ProgressChanged += new ProgressChangedEventHandler(bgw1_ProgressChanged);
                    bgw1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw1_RunWorkerCompleted);
                    bgw1.WorkerReportsProgress = true;

                    progressDialog = new ProgressDialog();
                    progressDialog.Show();
                    progressDialog.TopMost = true;

                    bgw1.RunWorkerAsync();
                    bgw1.Dispose();
                }
            }
                //displayImages();            
            this.ActiveControl = lvImages;
        }
    }
}
