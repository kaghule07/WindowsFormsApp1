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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult result = fd.ShowDialog();
            if(DialogResult.OK==result)
            {
                richTextBox1.SelectionFont = fd.Font;   
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fd = new ColorDialog();
            DialogResult result = fd.ShowDialog();
            if (DialogResult.OK == result)
            {
                richTextBox1.SelectionColor = fd.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Exit ?", "Warning",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = ".txt";
            sf.Filter = "Text doc(.txt)|*.txt|Word Doc(.docx)|*.docx|Pdf file(.pdf)|*.pdf";
            DialogResult res = sf.ShowDialog();
            if(res==DialogResult.OK)
            {
                StreamWriter sw=new StreamWriter(sf.FileName);  
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Text doc(.txt)|*.txt|Word Doc(.docx)|*.docx|Pdf file(.pdf)|*.pdf|All Files|*.*";
            DialogResult result = od.ShowDialog();  
            if(result==DialogResult.OK)
            {
                StreamReader sr=new StreamReader(od.FileName);
                richTextBox1.Text=sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
