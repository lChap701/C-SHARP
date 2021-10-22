using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneButtonTwoEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Button was clicked";
            label1.BackColor = Color.CornflowerBlue;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Go ahead";
            button1.BackColor = Color.Red;
        }
    }
}
