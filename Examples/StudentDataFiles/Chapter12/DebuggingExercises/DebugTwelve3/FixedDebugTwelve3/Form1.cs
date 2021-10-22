using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugTwelve3
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Checked(sender);
        }
        private void Checked(object sender)
        {
            CheckBox box = new CheckBox();
            box = (CheckBox)sender;
            if (box.Checked == false)
                ++count;
            else --count;
            outputLabel.Text = "Item count is " + count;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Checked(sender);
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            Checked();
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            checked(sender);
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            Checked(sender);
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            Checked(sender)
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            Checked(sender);
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheCked(sender);
        }
    }
}
