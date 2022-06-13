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


namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btn6CreateFolder_Click(object sender, EventArgs e)
        {
            /*string path = @"D:\FILEIO";
            if(Directory.Exists(path))
            {
                MessageBox.Show("Folder is already exist");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Folder is Created");
            }*/

            string path = @"D:\FILEIO1";
            DirectoryInfo di=new DirectoryInfo(path);   
            if(di.Exists)
            {
                MessageBox.Show("Folder is already exist");
            }
            else
            {
                di.Create();
                MessageBox.Show("Folder is created");
            }
               
        }

        private void btn7CreateFile_Click(object sender, EventArgs e)
        {
          /*  string path = @"D:\FILEIO\Test.txt";
            if (File.Exists(path))
            {
                MessageBox.Show("File already exists");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("File created");
            }*/
            string path = @"D:\FILEIO1\Test.txt";
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                MessageBox.Show("File already exists");
            }
            else
            {
                fi.Create();
                MessageBox.Show("File is created");

            }
        }

        private void btn4Write_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FILEIO1\Test.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                int id = Convert.ToInt32(textBox1ID.Text);
                string name = textBox2Name.Text;
                string location = textBox3Loc.Text;
                bw.Write(id);
                bw.Write(name);
                bw.Write(location);
                bw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn5Read_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FILEIO1\Test.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int id = br.ReadInt32();
                string name = br.ReadString();
                string location = br.ReadString();
                textBox1ID.Text = id.ToString();
                textBox2Name.Text = name;
                textBox3Loc.Text = location;
                br.Close();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
