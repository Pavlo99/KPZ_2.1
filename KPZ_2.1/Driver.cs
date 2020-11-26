using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPZ_2._1
{
    public class Driver
    {

        private string Name { get; set; }
        private string LastName { get; set; }
        private StateDriver State { get; set; }

        public Driver(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            State = StateDriver.Free;
        }


        public void Subscribe(Order order)
        {
            order.TaxiOrder += TakeOrder;
            order.TaxiOrder += GoToPassanger;
        }

        public void GoToPassanger(RichTextBox richTextBox)
        {
            State = StateDriver.InDrive;
            richTextBox.Text += $"\n{Name} Driver state - in drive. The driver is going to the passenger.";
        }

        public void TakeOrder(RichTextBox richTextBox)
        {
            State = StateDriver.Busy;
            richTextBox.Text += $"\n{Name} Driver state - Busy. The car are ready to go.";
        }

        public void FinishTrip(RichTextBox richTextBox)
        {
            State = StateDriver.Free;
            richTextBox.Text += $"\n{Name} Driver state - Free. The car are ready to take order.";
        }
    }

    enum StateDriver
    {
        Busy,
        InDrive,
        Free
    }
}
