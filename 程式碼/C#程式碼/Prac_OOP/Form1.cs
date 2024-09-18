using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmartPhone Phone1 = new SmartPhone();
            Phone1.Manufacturer = "ROG";
            Phone1.Model = "ROG Phone 8";
            Phone1.ScreenSize = 6.9;
            Phone1.TurnOn();

            SmartPhone Phone2 = new SmartPhone();
            Phone2.Manufacturer = "Apple Inc";
            Phone2.Model = "Iphone15";
            Phone2.ScreenSize = 6.7;
            Phone2.TurnOn();

            Claculator c = new Claculator();
            double r;
            r = c.AddTwoNumbers(123.45, 483.23);

        }
    }
}
