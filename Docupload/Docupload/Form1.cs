using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Docupload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;
                                                Initial Catalog=datafile;
                                                Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select file to be upload.";
            //which type file format you want to upload in database. just add them.
            openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html)|*.pdf; *.docx; *.xlsx; *.html";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        label1.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid document.");
                }
                else
                {
                    //we already define our connection globaly. We are just calling the object of connection.
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into doc (document)values('\\Document\\" + filename + "')", con);
                    string path = Application.StartupPath + "\\Document\\";
                    if (Directory.Exists(path) == false)
                    {
                        Directory.CreateDirectory(path);
                    }

                    System.IO.File.Copy(openFileDialog1.FileName, path + filename);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Document uploaded.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}