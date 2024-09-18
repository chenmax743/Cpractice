using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_OOP
{
    internal class SmartPhone
    {
        public string Manufacturer { set; get; }
        public string Model { set; get; }
        public double ScreenSize { set; get; }

        public void TurnOn() { }
        public void TurnOff() { }
        public void Charge() { }

        public event EventHandler On_SMS_Recieved;

       
        


    }
}
