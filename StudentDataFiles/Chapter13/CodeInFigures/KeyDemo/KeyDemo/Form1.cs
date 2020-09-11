using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text += "Key Code " + e.KeyCode;
            label1.Text += "\nAlt " + e.Alt;
            label1.Text += "\nShift " + e.Shift;
            label1.Text += "\nControl " + e.Control;
            label1.Text += "\nKey Data " + e.KeyData;
            label1.Text += "\nKey Value " + e.KeyValue + "\n\n";

        }
    }
}
