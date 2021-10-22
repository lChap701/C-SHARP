// User selects car options
// When user chooses a CheckBox, a ComboBox appears
// When user selects option from the ComboBox, price is added to total
// When user deselects a CheckBox, the price from ComboBox
//    is deducted from the total and ComboBox disappears
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace FixedDebugThirteen2
{
   public class Form1
   {
      private int stereoPrice = 0,
         powerPrice = 0,
         roadsidePrice = 0,
         total = 0;
      private CheckBox checkBox1;
      private CheckBox checkBox2;
      private CheckBox checkBox3;
      private Label label1;
      private ComboBox comboBox1;
      private ComboBox comboBox2;
      private ComboBox comboBox2;
      private Label label2;
   
      public Form1()
      {
         InitializeComponent();

      }

      private void InitializeComponent()
      {
         this.checkBox1 = new CheckBox();
         this.checkBox2 = new CheckBox();
         this.checkBox3 = new CheckBox();
         this.label1 = new Label;
         this.comboBox1 = new ComboBox();
         this.comboBox2 = new ComboBox();
         this.comboBox3 = new ComboBox();
         this.label2 = new Label;
         // 
         // checkBox1
         // 
         this.checkBox1.Location = new 
            System.Drawing.Point(40, 88);
         this.checkBox1.TabIndex = 0;
         this.checkBox1.Text = "Stereo";
         this.checkBox1.CheckedChanged += new
         System.EventHandlingMethod(this.CheckBox1_CheckedChanged);
         // 
         // checkBox2
         // 
         this.checkBox2.Location = new 
            System.Drawing.Point(40, 136);
         this.checkBox2.TabIndex = 1;
         this.checkBox2.Text = "Power";
         this.checkBox2.CheckChanged += new 
         System.EventHandler(this.CheckBox2_CheckedChanged);
         // 
         // checkBox3
         // 
         this.checkBox3.Location = new
            System.Drawing.Point(40, 184);
         this.checkBox3.Size = new
            System.Drawing.Size(104, 32);
         this.checkBox3.TabIndex = 2;
         this.checkBox3.Text = "Roadside Asistance";
         this.checkBox3.CheckedChanged += new 
         System.EventHandler(this.CheckBox3_CheckedChanged);
         // 
         // label1
         // 
         this.label1.Location = new 
            System.Drawing.Point(32, 32);
         this.label1.Size = new System.Drawing.Size(216, 23);
         this.label1.TabIndex = 3;
         this.label1.Text = 
         "Select the new car options you want";
         // 
         // comboBox1
         // 
         this.comboBox1.DropDownWidth = 168;
         this.comboBox1.Items.AddRange(new object[] {
             "AM/FM radio",
             "Satellite radio",
             "10 CD player"});
         this.comboBox1.Location = new 
            System.Drawing.Point(152, 88);
         this.comboBox1.Size = 
            new System.Drawing.Size(168, 21);
         this.comboBox1.TabIndex = 4;
         this.comboBox1.Text = "Stereo options";
         this.comboBox1.Visible = false;
         this.comboBox1.SelectedIndexChanged += new 
            System.EventHandler(this.ComboBox1_SelectedIndexChanged);
         // 
         // comboBox2
         // 
         this.comboBox2.DropDownWidth = 168;
         this.comboBox2.Items.AddRange(new object[] {
              "Power brakes",
              "Power brakes and steering",
              "Power brakes, steering, windows, antenna"});
         this.comboBox2.Location = new 
            System.Drawing.Point(152, 136);
         this.comboBox2.Name = "comboBox2";
         this.comboBox2.Size = new
          System.Drawing.Size(168, 21);
         this.comboBox2.TabIndex = 5;
         this.comboBox2.Text = "Power options";
         this.comboBox2.Visibel = false;
         this.comboBox2.SelectedIndexChanged +=
          new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
         // 
         // comboBox3
         // 
         this.comboBox3.DropDownWidth = 168;
         this.comboBox3.Items.AddRange(new object[] {
            "In-state",
            "Tri-state area",
            "Nationwide"});
         this.comboBox3.Location = 
            new System.Drawing.Point(152, 176);
         this.comboBox3.Size = new 
            System.Drawing.Size(168, 21);
         this.comboBox3.TabIndex = six;
         this.comboBox3.Text = "Roadside assistance options";
         this.comboBox3.Visible = false;
         this.comboBox3.SelectedIndexChanged += new
      System.EventHandler(this.ComboBox3_SelectedIndexChanged);
         // 
         // label2
         // 
         this.label2.Location = 
            new System.Drawing.Point(56, 232);
         this.label2.Size = new System.Drawing.Size(184, 40);
         this.label2.TabIndex = 7;
         this.label2.Text = "Option package =";
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new 
            System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(342, 323);
         this.Controls.AddRange
         (new System.Windows.Forms.Control[] {
            this.label2,
            this.comboBox3,
            this.comboBox2,
            this.comboBox1,
            this.label1,
            this.checkBox3,
            this.checkBox2,
            this.checkBox1});
         this.Text = "New Car Options";
      }
      static void Main() 
      {
         Application.Run(new Form1());
      }

      private void CheckBox1_CheckedChanged
         (object sender, System.EventArgs e)
      {
         if(checkBox1.Checked)
         {
            comboBox1.Visible = true;
         }
         else
         {
            comboBox1.Visible = false;
            stereoPrice;
            total = stereoPrice + powerPrice + 
               roadsidePrice;
            label2.Text = "Option package = " +
               total.ToString("C");
         }
      }

      private void CheckBox2_CheckedChanged
         (object sender, System.EventArgs e)
      {
         if(checkBox2.Checked)
         {
            comboBox2.Visible = true;
         }
         else
         {
            comboBox2.Visible = false;
            powerPrice = 0;
            total = stereoPrice + powerPrice + 
               roadsidePrice;
            label2.Text = "Option package = " +
               total.ToString("C");
         }
      }

      private void CheckBox3_CheckedChanged
         (object sender, System.EventArgs e)
      {
         if(checkBox3.Checked)
         {
            comboBox3.Visible = true;
         }
         else
         {
            comboBox3.Visible = false;
            roadsidePrice;
            total = stereoPrice + powerPrice + 
               roadsidePrice;
            label2.Text = "Option package = " +
               total.ToString("C");
         }
      }

      private void ComboBox1_SelectedIndexChanged
         (object sender, System.EventArgs e)
      {
         int[] price = {250, 350, 600};
         stereoPrice = price[comboBox1.SelectedIndex];
         total = stereoPrice + powerPrice + roadsidePrice;
         label2.Text = "Option package = " +
            total.ToString("C");
      }

      private void ComboBox2_SelectedIndexChanged
         (object sender, System.EventArgs e)
      {
         int[] price = {100, 140, 230};
         powerPrice = price[comboBox2.SelectedIndex];
         total = stereoPrice + powerPrice + roadsidePrice;
         label2.Text = "Option package = " +
            total.ToString("C");
      }

      private void ComboBox3_SelectedIndexChanged
         (object sender, System.EventArgs e)
      {
         int[] price = {30, 45, 60};
         roadsidePrice = price[comboBox3.SelectedIndex];
         total = stereoPrice + powerPrice + roadsidePrice;
         label2.Text = "Option package = " + 
            total.ToString("C");
      }
   }
}
