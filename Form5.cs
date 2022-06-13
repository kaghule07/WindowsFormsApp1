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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn1Save_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\FILEIO1\Test.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            int id = Convert.ToInt32(textBox1ID.Text);
            string name = textBox2Name.Text;
            string fees = textBox3Fees.Text;
            bw.Write(id);
            bw.Write(name);
            bw.Write(fees);
            bw.Close();
            fs.Close();
            
        }

        private void btn2Read_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\FILEIO1\Test.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int id = br.ReadInt32();
            string name = br.ReadString();
            string fees = br.ReadString();
            textBox1ID.Text = id.ToString();
            textBox2Name.Text = name;
            textBox3Fees.Text = fees;
            br.Close();
            fs.Close();
        }
    }
}
