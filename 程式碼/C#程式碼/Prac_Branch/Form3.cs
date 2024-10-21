using System;
using System.Windows.Forms;

namespace Prac_Branch
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sDelivery;
            sDelivery = textBox1.Text.ToUpper();
            switch (sDelivery)
            {
                case "A":
                    label3.Text = "宅配到家";
                    break;
                case "B":
                    label3.Text = "超商取貨";
                    break;
                case "C":
                    label3.Text = "店到店";
                    break;
                default:
                    label3.Text = "您輸入的代碼錯誤";
                    break;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
