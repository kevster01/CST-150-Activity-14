using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activity14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Recorded age is under 15");
            }
            else if (checkBox2.Checked)
            {
                MessageBox.Show("Recorded age is under 25");
            }
            else if (checkBox3.Checked)
            {
                MessageBox.Show("Recorded age is under 50");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Yes_btn.Checked)
                MessageBox.Show("Please speak with the school health officer for further assistance.");
            if (No_btn.Checked)
                MessageBox.Show("Welcome back!");
        }

        private void Age_Click(object sender, EventArgs e)
        {

        }
    }
}
