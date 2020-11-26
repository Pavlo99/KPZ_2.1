using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPZ_2._1
{
    public class Passanger
    {

        private string Name { get; set; }
        private string LastName { get; set; }
        public StatePassanger State { get; set; } // ????????????????????????????????


        public Passanger(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            State = StatePassanger.Ready;
        }

        public void Subscribe(Order order)
        {
            order.TaxiOrder += TakeTaxi;
            order.TaxiOrder += WaitForDriver;
        }

        public void WaitForDriver(RichTextBox richTextBox)
        {
            State = StatePassanger.Wait;
            richTextBox.Text += $"\n{Name} Passanger state - Wait. The passanger is waiting for a taxi.";
        }

        public void TakeTaxi(RichTextBox richTextBox)
        {
            State = StatePassanger.Ready;
            richTextBox.Text += $"\n{Name} Passanger state - Ready. The passanger is taking a taxi.";
        }
        public void GoingToArrivalLocation(RichTextBox richTextBox)
        {
            State = StatePassanger.InDrive;
            richTextBox.Text += $"\n{Name} Passanger state - In drive. The passanger is going to arrival location.";
        }

        public void FinishTrip(RichTextBox richTextBox)
        {
            State = StatePassanger.AtPlace;
            richTextBox.Text += $"\n{Name} Passanger state - At Place. The passenger was brought to the arrival place";
        }

    }
    public enum StatePassanger
    {
        Ready,
        Wait,
        InDrive,
        AtPlace
    }
}
