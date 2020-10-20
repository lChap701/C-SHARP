namespace TheCookieSource
{
    partial class DisplayOrders
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
            this.orders = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orders
            // 
            this.orders.AutoSize = true;
            this.orders.Location = new System.Drawing.Point(246, 26);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(0, 20);
            this.orders.TabIndex = 0;
            // 
            // Return
            // 
            this.Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return.Location = new System.Drawing.Point(183, 908);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(418, 64);
            this.Return.TabIndex = 1;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // DisplayOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1013);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.orders);
            this.Name = "DisplayOrders";
            this.Text = "Display Orders";
            this.Load += new System.EventHandler(this.DisplayOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orders;
        private System.Windows.Forms.Button Return;
    }
}