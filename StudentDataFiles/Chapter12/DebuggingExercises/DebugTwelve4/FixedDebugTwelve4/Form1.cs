using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugTwelve4
{
    public partial class Form1 : Form
    {
        int total = 0;
        int basePrice = 180000;
        int beds = 2;
        int baths = 2;
        int garage = 1;
        int bedsPrice = 0;
        int bathsPrice = 0;
        int garagePrice = 0;
        const int THREE_BEDROOMS = 8000;
        const int FOUR_BEDROOMS = 14000;
        const int THIRD_BATH = 9000;
        const int SECOND_GARAGE = 5500;
        bool firstColor = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                bedsPrice = 0;
                beds = 2;
                DisplayTotal();
            }
            
        }
        private void DisplayTotal()
        {
            if (firstColor)
            {
                outputLabel.ForeColor = Color.Red;
                firstColor = false;
            }
            else
            {
                outputLabel.ForeColor = Color.Blue;
                firstColor = true;
            }

           outputLabel.Text = "Total : $ + (basePrice + bedsPrice + bathsPrice + garagePrice)
                + "\n" + beds + " bedrooms, "  baths + " baths, " + garage + "-car garage";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                bedsPrice = THREE_BEDROOMS;
                beds = 3;
                DisplayTotal();
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                bedsPrice = FOUR_BEDROOM;
                beds = 4;
                DisplayTotal();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Text += " (" + THREE_BEDROOMS + " premium)";
            radioButton3.Text += " (" + FOURBEDROOMS + " premium)";
            radioButton4.Checked = true;
            radioButton5.Text += " (" + THIRD_BATH + " premium)";
            radioButton6.Checked = true; 
            radioButton7.Text += " (" + SECOND_GARAGE + " premium)";
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                bathsPrice = 0;
                baths = 2;
                DisplayTotal;
            }
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                bathsPrice = THIRD_BATH;
                baths = 3;
                DisplayTotal();
            }
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                garagePrice = 0;
                garage = 1;
                DisplayTotal();
            }
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                garagePrice = SECOND_GARAGE;
                garage = 2;
                DisplayTotal();
            }
        }
    }
}
