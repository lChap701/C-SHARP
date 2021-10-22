using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const double BASE_PRICE = 12.00;
        private const double TOPPING_PRICE = 1.25;
        private double price = BASE_PRICE;
        private void SausageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sausageCheckBox.Checked)
                price += TOPPING_PRICE;
            else
                price -= TOPPING_PRICE;
            outputLabel.Text = "Total is " + price.ToString("C");
        }

        private void OnionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onionsCheckBox.Checked)
                price += TOPPING_PRICE;
            else
                price -= TOPPING_PRICE;
            outputLabel.Text = "Total is " + price.ToString("C");
        }

        private void GreenPepperCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (greenPepperCheckBox.Checked)
                price += TOPPING_PRICE;
            else
                price -= TOPPING_PRICE;
            outputLabel.Text = "Total is " + price.ToString("C");
        }

        private void PepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pepperoniCheckBox.Checked)
                price += TOPPING_PRICE;
            else
                price -= TOPPING_PRICE;
            outputLabel.Text = "Total is " + price.ToString("C");
        }

        private void DeliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            const double DELIVERY_CHARGE = 2.00;
            if (deliveryRadioButton.Checked)
                price += DELIVERY_CHARGE;
            else
                price -= DELIVERY_CHARGE;
            outputLabel.Text = "Total is " + price.ToString("C");

        }
    }
}
