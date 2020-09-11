namespace ListBoxDemo
{
    partial class Majors
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
            this.majorListBox = new System.Windows.Forms.ListBox();
            this.majorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // majorListBox
            // 
            this.majorListBox.FormattingEnabled = true;
            this.majorListBox.ItemHeight = 16;
            this.majorListBox.Items.AddRange(new object[] {
            "Accounting",
            "Biology",
            "Business",
            "Chemistry",
            "English",
            "History",
            "Mathematics",
            "Physics",
            "Psychology",
            "Sociology"});
            this.majorListBox.Location = new System.Drawing.Point(12, 33);
            this.majorListBox.MultiColumn = true;
            this.majorListBox.Name = "majorListBox";
            this.majorListBox.Size = new System.Drawing.Size(258, 116);
            this.majorListBox.TabIndex = 0;
            this.majorListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(61, 192);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(0, 17);
            this.majorLabel.TabIndex = 1;
            // 
            // Majors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.majorListBox);
            this.Name = "Majors";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox majorListBox;
        private System.Windows.Forms.Label majorLabel;
    }
}

