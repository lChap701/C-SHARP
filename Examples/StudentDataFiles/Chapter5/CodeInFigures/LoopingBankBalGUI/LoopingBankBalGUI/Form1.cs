using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoopingBankBalGUI
{
    public partial class Form1 : Form
    {
        double bankBal = 1000;
        const double INT_RATE = 0.04;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text += String.Format("Bank balance is {0}\n", bankBal.ToString("C"));
            bankBal = bankBal + bankBal * INT_RATE;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
           outputLabel.Text = "Have a nice day!";
        }
   }
}

