using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            buttonInfoLabel.Text = "Button 1 selected";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            buttonInfoLabel.Text = "Button 2 selected";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            buttonInfoLabel.Text = "Button 3 selected";
        }
    }
}
