using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPZ_2._1
{
    public class Order
    {
        private int orderNumber { get; set; }
        public event Taxi TaxiOrder;
        private RichTextBox richTextBox;

        public Order(RichTextBox richTextBox)
        {
            Random random = new Random();
            this.orderNumber = random.Next(1, 200);
            this.richTextBox = richTextBox;
        }

        public void OnProcessCompleted()
        {
            TaxiOrder?.Invoke(richTextBox);
        }
    }
}
