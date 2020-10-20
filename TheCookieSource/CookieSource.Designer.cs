namespace TheCookieSource
{
    partial class CookieSource
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
        {
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.RadioButton();
            this.c = new System.Windows.Forms.RadioButton();
            this.s = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.Location = new System.Drawing.Point(63, 351);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(220, 69);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit Order";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(115, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(119, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(271, 26);
            this.name.TabIndex = 2;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(427, 76);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(273, 26);
            this.phoneNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(423, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(115, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cookie Type ";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.o.Location = new System.Drawing.Point(167, 197);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(46, 24);
            this.o.TabIndex = 6;
            this.o.TabStop = true;
            this.o.Text = "O";
            this.o.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c.Location = new System.Drawing.Point(116, 197);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(45, 24);
            this.c.TabIndex = 7;
            this.c.TabStop = true;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Cursor = System.Windows.Forms.Cursors.Hand;
            this.s.Location = new System.Drawing.Point(219, 197);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(45, 24);
            this.s.TabIndex = 8;
            this.s.TabStop = true;
            this.s.Text = "S";
            this.s.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Location = new System.Drawing.Point(113, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quantity (In Dozens)";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(119, 293);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(273, 26);
            this.quantity.TabIndex = 10;
            // 
            // deliveryDate
            // 
            this.deliveryDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deliveryDate.Location = new System.Drawing.Point(420, 293);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Size = new System.Drawing.Size(273, 26);
            this.deliveryDate.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Location = new System.Drawing.Point(416, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Delivery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(114, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "C - Cookie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(202, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "O - Oatmeal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "S - Sugar";
            // 
            // display
            // 
            this.display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.display.Location = new System.Drawing.Point(299, 351);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(220, 69);
            this.display.TabIndex = 18;
            this.display.Text = "Display Orders";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.Display_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(534, 351);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(220, 69);
            this.exit.TabIndex = 19;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CookieSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.display);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deliveryDate);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.s);
            this.Controls.Add(this.c);
            this.Controls.Add(this.o);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "CookieSource";
            this.Text = "The Cookie Source";
            this.Load += new System.EventHandler(this.CookieSource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.Button submit;
        System.Windows.Forms.Label label1;
        System.Windows.Forms.TextBox name;
        System.Windows.Forms.TextBox phoneNumber;
        System.Windows.Forms.Label label2;
        System.Windows.Forms.Label label3;
        System.Windows.Forms.RadioButton o;
        System.Windows.Forms.RadioButton c;
        System.Windows.Forms.RadioButton s;
        System.Windows.Forms.Label label8;
        System.Windows.Forms.TextBox quantity;
        System.Windows.Forms.DateTimePicker deliveryDate;
        System.Windows.Forms.Label label9;
        System.Windows.Forms.Label label4;
        System.Windows.Forms.Label label6;
        System.Windows.Forms.Label label7;
        System.Windows.Forms.Button exit;
        System.Windows.Forms.Button display;
    }
}