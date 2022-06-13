using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"\n Employee Id: {EmpIdBox1.Text} "+
                $"\n Employee Name: {EmpNameBox2.Text}"+
                $"\n Salary:{EmpSalaryBox3.Text}"+
                $"\n Department Name:{EmpDepNameBox4.Text}");
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            EmpIdBox1.Clear();
            EmpNameBox2.Clear();
            EmpSalaryBox3.Clear();
            EmpDepNameBox4.Clear();
        }
    }
}
