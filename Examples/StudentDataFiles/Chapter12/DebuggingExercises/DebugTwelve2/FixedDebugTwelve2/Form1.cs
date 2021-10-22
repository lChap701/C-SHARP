using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugTwelve2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Check == true)
            {
                Form2 meetingForm = new Form2();
                meetingForm.showDialog();
                checkBox1.CheckedState = CheckState.Unchecked;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Form3 duesForm = new Form3();
                duesForm.ShowDialog();
                checkBox2.CheckState = Checkstate.Unchecked;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked = true)
            {
                Form4 officersForm = new Form4();
                officersForm.ShowDialog();
                checkBox3.CheckState = CheckState.Unchecked;
            }
        }
    }
}
