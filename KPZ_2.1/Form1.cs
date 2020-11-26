using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPZ_2._1
{
    public delegate void Taxi(RichTextBox richTextBox);
    public partial class Form1 : Form
    {
        private Order order;
        private Passanger passanger1;
        private Passanger passanger2;
        private Passanger passanger3;
        private Driver driver1;
        private Driver driver2;
        private Driver driver3;

        private Passanger currentPassanger;
        private Driver currentDriver;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Tom Smith");
            comboBox1.Items.Add("Pavlo Petrov");
            comboBox1.Items.Add("Peter Jackson");

            comboBox2.Items.Add("Ivan Ivanov");
            comboBox2.Items.Add("Bary Coper");
            comboBox2.Items.Add("Jack Alen");

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            richTextBox1.Text = "";

            order = new Order(richTextBox1);
            passanger1 = new Passanger("Tom", "Smith");
            passanger2 = new Passanger("Pavlo", "Petrov");
            passanger3 = new Passanger("Peter", "Jackson");
            driver1 = new Driver("Ivan", "Ivanov");
            driver2 = new Driver("Bary", "Coper");
            driver3 = new Driver("Jack", "Alen");
        }


        private void takeTaxi_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    currentPassanger = passanger2;
                    break;
                case 2:
                    currentPassanger = passanger3;
                    break;
                default:
                    currentPassanger = passanger1;
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 1:
                    currentDriver = driver2;
                    break;
                case 2:
                    currentDriver = driver3;
                    break;
                default:
                    currentDriver = driver1;
                    break;
            }
            richTextBox1.Text = "";
            currentPassanger.Subscribe(order);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    currentPassanger = passanger2;
                    break;
                case 2:
                    currentPassanger = passanger3;
                    break;
                default:
                    currentPassanger = passanger1;
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 1:
                    currentDriver = driver2;
                    break;
                case 2:
                    currentDriver = driver3;
                    break;
                default:
                    currentDriver = driver1;
                    break;
            }
            if (currentPassanger.State == StatePassanger.Wait)
            {
                currentDriver.Subscribe(order);

                order.TaxiOrder += currentPassanger.GoingToArrivalLocation;
                order.TaxiOrder += currentPassanger.FinishTrip;
                order.TaxiOrder += currentDriver.FinishTrip;
            }
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            order.OnProcessCompleted();
        }
    }
}
