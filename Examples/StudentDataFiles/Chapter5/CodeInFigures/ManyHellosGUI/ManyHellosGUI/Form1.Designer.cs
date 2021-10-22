namespace ManyHellosGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.greetingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.greetingsTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greetingsButton
            // 
            this.greetingsButton.Location = new System.Drawing.Point(96, 74);
            this.greetingsButton.Name = "greetingsButton";
            this.greetingsButton.Size = new System.Drawing.Size(75, 23);
            this.greetingsButton.TabIndex = 0;
            this.greetingsButton.Text = "Click";
            this.greetingsButton.UseVisualStyleBackColor = true;
            this.greetingsButton.Click += new System.EventHandler(this.greetingsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many greetings do you want?";
            // 
            // greetingsTextBox
            // 
            this.greetingsTextBox.Location = new System.Drawing.Point(201, 33);
            this.greetingsTextBox.Name = "greetingsTextBox";
            this.greetingsTextBox.Size = new System.Drawing.Size(35, 20);
            this.greetingsTextBox.TabIndex = 2;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(115, 117);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.greetingsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greetingsButton);
            this.Name = "Form1";
            this.Text = "Greetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button greetingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox greetingsTextBox;
        private System.Windows.Forms.Label outputLabel;
    }
}

