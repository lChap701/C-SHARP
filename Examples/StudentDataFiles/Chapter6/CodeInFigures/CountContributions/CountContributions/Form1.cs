using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountContributions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] total = { 0, 0, 0, 0 };
        private void OkButton_Click(object sender, EventArgs e)
        {
            int dept;
            double contribution;
            dept = Convert.ToInt32(deptTextbox.Text);
            contribution = Convert.ToDouble(contributionTextbox.Text);
            --dept;
            total[dept] += contribution;
            deptTextbox.Text = "";
            contributionTextbox.Text = "";
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Dept    Total";
            for (int x = 0; x < total.Length; ++x)
                outputLabel.Text += String.Format("\n   {0}{1, 10}", x + 1, total[x].ToString("C"));
        }
    }
}
