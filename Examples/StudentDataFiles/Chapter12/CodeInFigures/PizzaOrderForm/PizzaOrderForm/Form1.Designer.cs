namespace PizzaOrderForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.onionsCheckBox = new System.Windows.Forms.CheckBox();
            this.greenPepperCheckBox = new System.Windows.Forms.CheckBox();
            this.pepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.sausageCheckBox = new System.Windows.Forms.CheckBox();
            this.pickUpRadioButton = new System.Windows.Forms.RadioButton();
            this.deliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.dineInRadioButton = new System.Windows.Forms.RadioButton();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Order Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dining options";
            // 
            // onionsCheckBox
            // 
            this.onionsCheckBox.AutoSize = true;
            this.onionsCheckBox.Location = new System.Drawing.Point(30, 150);
            this.onionsCheckBox.Name = "onionsCheckBox";
            this.onionsCheckBox.Size = new System.Drawing.Size(75, 21);
            this.onionsCheckBox.TabIndex = 3;
            this.onionsCheckBox.Text = "Onions";
            this.onionsCheckBox.UseVisualStyleBackColor = true;
            this.onionsCheckBox.CheckedChanged += new System.EventHandler(this.OnionsCheckBox_CheckedChanged);
            // 
            // greenPepperCheckBox
            // 
            this.greenPepperCheckBox.AutoSize = true;
            this.greenPepperCheckBox.Location = new System.Drawing.Point(30, 175);
            this.greenPepperCheckBox.Name = "greenPepperCheckBox";
            this.greenPepperCheckBox.Size = new System.Drawing.Size(119, 21);
            this.greenPepperCheckBox.TabIndex = 4;
            this.greenPepperCheckBox.Text = "Green papper";
            this.greenPepperCheckBox.UseVisualStyleBackColor = true;
            this.greenPepperCheckBox.CheckedChanged += new System.EventHandler(this.GreenPepperCheckBox_CheckedChanged);
            // 
            // pepperoniCheckBox
            // 
            this.pepperoniCheckBox.AutoSize = true;
            this.pepperoniCheckBox.Location = new System.Drawing.Point(30, 200);
            this.pepperoniCheckBox.Name = "pepperoniCheckBox";
            this.pepperoniCheckBox.Size = new System.Drawing.Size(95, 21);
            this.pepperoniCheckBox.TabIndex = 5;
            this.pepperoniCheckBox.Text = "Pepperoni";
            this.pepperoniCheckBox.UseVisualStyleBackColor = true;
            this.pepperoniCheckBox.CheckedChanged += new System.EventHandler(this.PepperoniCheckBox_CheckedChanged);
            // 
            // sausageCheckBox
            // 
            this.sausageCheckBox.AutoSize = true;
            this.sausageCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sausageCheckBox.Location = new System.Drawing.Point(30, 225);
            this.sausageCheckBox.Name = "sausageCheckBox";
            this.sausageCheckBox.Size = new System.Drawing.Size(86, 21);
            this.sausageCheckBox.TabIndex = 6;
            this.sausageCheckBox.Text = "Sausage";
            this.sausageCheckBox.UseVisualStyleBackColor = true;
            this.sausageCheckBox.CheckedChanged += new System.EventHandler(this.SausageCheckBox_CheckedChanged);
            // 
            // pickUpRadioButton
            // 
            this.pickUpRadioButton.AutoSize = true;
            this.pickUpRadioButton.Location = new System.Drawing.Point(191, 150);
            this.pickUpRadioButton.Name = "pickUpRadioButton";
            this.pickUpRadioButton.Size = new System.Drawing.Size(75, 21);
            this.pickUpRadioButton.TabIndex = 7;
            this.pickUpRadioButton.TabStop = true;
            this.pickUpRadioButton.Text = "Pick up";
            this.pickUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // deliveryRadioButton
            // 
            this.deliveryRadioButton.AutoSize = true;
            this.deliveryRadioButton.Location = new System.Drawing.Point(191, 175);
            this.deliveryRadioButton.Name = "deliveryRadioButton";
            this.deliveryRadioButton.Size = new System.Drawing.Size(80, 21);
            this.deliveryRadioButton.TabIndex = 8;
            this.deliveryRadioButton.TabStop = true;
            this.deliveryRadioButton.Text = "Delivery";
            this.deliveryRadioButton.UseVisualStyleBackColor = true;
            this.deliveryRadioButton.CheckedChanged += new System.EventHandler(this.DeliveryRadioButton_CheckedChanged);
            // 
            // dineInRadioButton
            // 
            this.dineInRadioButton.AutoSize = true;
            this.dineInRadioButton.Location = new System.Drawing.Point(191, 199);
            this.dineInRadioButton.Name = "dineInRadioButton";
            this.dineInRadioButton.Size = new System.Drawing.Size(73, 21);
            this.dineInRadioButton.TabIndex = 9;
            this.dineInRadioButton.TabStop = true;
            this.dineInRadioButton.Text = "Dine in";
            this.dineInRadioButton.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(198, 252);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 17);
            this.outputLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 293);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.dineInRadioButton);
            this.Controls.Add(this.deliveryRadioButton);
            this.Controls.Add(this.pickUpRadioButton);
            this.Controls.Add(this.sausageCheckBox);
            this.Controls.Add(this.pepperoniCheckBox);
            this.Controls.Add(this.greenPepperCheckBox);
            this.Controls.Add(this.onionsCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox onionsCheckBox;
        private System.Windows.Forms.CheckBox greenPepperCheckBox;
        private System.Windows.Forms.CheckBox pepperoniCheckBox;
        private System.Windows.Forms.CheckBox sausageCheckBox;
        private System.Windows.Forms.RadioButton pickUpRadioButton;
        private System.Windows.Forms.RadioButton deliveryRadioButton;
        private System.Windows.Forms.RadioButton dineInRadioButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

