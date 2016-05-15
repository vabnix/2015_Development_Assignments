using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyAppSabre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnCleanFolder_Click(object sender, EventArgs e)
        {
            string delAppFolder = @"C:\Users\sg0949719\AppData\Roaming\Cross";
            string delLocalApp = @"C:\Users\sg0949719\AppData\Local\Apps\2.0";
            DelRoamingFolder(delAppFolder, true);
            DelRoamingFolder(delLocalApp, true);
        }

        public static void DelRoamingFolder(string path, bool recursive)
        {
            try
            {
                //delete all the files and sub folder
                if (recursive)
                {
                    var subfolder = Directory.GetDirectories(path);
                    foreach (var fol in subfolder)
                    {
                        DelRoamingFolder(fol, recursive);
                    }
                }

                var files = Directory.GetFiles(path);
                foreach (var mfile in files)
                {
                    var attr = File.GetAttributes(mfile);
                    if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {
                        File.SetAttributes(mfile, attr ^ FileAttributes.ReadOnly);
                    }

                    File.Delete(mfile);
                }
                Directory.Delete(path);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Folder does not exist !");
            }
           
        }

        private void _lockPath_CheckedChanged(object sender, EventArgs e)
        {
            if (_lockPath.Checked == true)
            {
                _txtPath.ReadOnly = true;
                _txtPath.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                _txtPath.ReadOnly = false;
            }
        }
    }
}
