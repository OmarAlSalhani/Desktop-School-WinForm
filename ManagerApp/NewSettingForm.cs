using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ManagerApp
{
    public partial class NewSettingForm : Form
    {
        public NewSettingForm()
        {
            InitializeComponent();
        }
        private void Copy()
        {
            string fileName=null ;
            string sourcePath = @"C:\Users\Public\TestFolder";
            string targetPath = @"C:\Users\Public\TestFolder\SubDir";

            // Use Path class to manipulate file and directory paths.
            string sourceFile =Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder. 
            // If the directory already exists, this method does not create a new directory.
            System.IO.Directory.CreateDirectory(targetPath);

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }
        private void gunaGradientTileButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
