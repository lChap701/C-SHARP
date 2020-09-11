using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManyHellosGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greetingsButton_Click(object sender, EventArgs e)
        {
            int numGreetings = Convert.ToInt32(greetingsTextBox.Text);
            int count;
            for (count = 0; count < numGreetings; ++count)
                outputLabel.Text += "Hello\n";
        }
    }
}
