using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Initialize DataGridView
            InitializeDataGridView();
        }

        DataGridView data;

        private void InitializeDataGridView()
        {
            data = this.data_results;
            //Create 3 Columns for Filename, Path, and Size
            data.ColumnCount = 3;
            data.Columns[0].Name = "Filename";
            data.Columns[1].Name = "Path";
            data.Columns[2].Name = "Size";
            //Disallow User to add Rows
            data.AllowUserToAddRows = false;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Event listener for 'Browse' button
        private void btn_result_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            this.f_path.Text = folderPath;
        }

        //Event listener for 'Search' button
        private void btn_search_Click(object sender, EventArgs e)
        {
            //Get folder path and keyword
            string folderPath = this.f_path.Text;
            string keyword = this.txt_keyword.Text;

            //Clear DataGridView
            do
            {
                foreach (DataGridViewRow row in data.Rows)
                {
                    try
                    {
                        data.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (data.Rows.Count > 0);

            //Find all files with matching Keyword and Insert to DataGridView
            try
            {
                string[] dirs = Directory.GetFiles(folderPath, keyword, SearchOption.AllDirectories);

                foreach (string dir in dirs)
                {
                    //Get Filename and its Size
                    string filename = Path.GetFileName(dir);
                    string length = getSize(dir);
                    //Add to DataGridView
                    string[] row = new string[] { filename, dir, length };
                    data.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
        }

        //Function to get readable filesize
        string[] sizes = { "B", "KB", "MB", "GB" };
        private string getSize(string dir)
        {
            long len = new System.IO.FileInfo(dir).Length;

            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }
        
    }
}
