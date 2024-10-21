using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_Branch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iAmount;
            iAmount = int.Parse(textBox1.Text);
            int iFreigh;
            if (iAmount >= 1000)
            {
                iFreigh = 0;
            }
            else
            {
                iFreigh = 80;
            }

            label3.Text = iFreigh.ToString();
        }
    }
}
