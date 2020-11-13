using System;
using System.Windows.Forms;

namespace StudentSystemGUI
{
    partial class StudentAssignments
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
            this.dgvAssign = new System.Windows.Forms.DataGridView();
            this.Assignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointsEarned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointsPossible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.save = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.delete = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.exit = new System.Windows.Forms.Button();
            this.stuListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssign)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAssign
            // 
            this.dgvAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assignment,
            this.PointsEarned,
            this.PointsPossible});
            this.dgvAssign.Location = new System.Drawing.Point(239, 21);
            this.dgvAssign.Name = "dgvAssign";
            this.dgvAssign.RowHeadersWidth = 62;
            this.dgvAssign.RowTemplate.Height = 28;
            this.dgvAssign.Size = new System.Drawing.Size(514, 322);
            this.dgvAssign.TabIndex = 0;
            this.dgvAssign.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvAssign_KeyDown);
            this.dgvAssign.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAssign_CellValueChanged);
            this.dgvAssign.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DgvAssign_CellBeginEdit);
            // 
            // Assignment
            // 
            this.Assignment.HeaderText = "Assignment";
            this.Assignment.MinimumWidth = 8;
            this.Assignment.Name = "Assignment";
            this.Assignment.Width = 150;
            // 
            // PointsEarned
            // 
            this.PointsEarned.HeaderText = "Points Earned";
            this.PointsEarned.MinimumWidth = 8;
            this.PointsEarned.Name = "PointsEarned";
            this.PointsEarned.Width = 150;
            // 
            // PointsPossible
            // 
            this.PointsPossible.HeaderText = "Points Possible";
            this.PointsPossible.MinimumWidth = 8;
            this.PointsPossible.Name = "PointsPossible";
            this.PointsPossible.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 358);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 76);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.save);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(257, 70);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Location = new System.Drawing.Point(3, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(254, 67);
            this.save.TabIndex = 0;
            this.save.Text = "Save Changes";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.delete);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(266, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(257, 70);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Location = new System.Drawing.Point(3, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(254, 67);
            this.delete.TabIndex = 0;
            this.delete.Text = "Delete Assignment";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.exit);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(529, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(258, 70);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(3, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(255, 67);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // stuListBox
            // 
            this.stuListBox.FormattingEnabled = true;
            this.stuListBox.ItemHeight = 20;
            this.stuListBox.Location = new System.Drawing.Point(33, 21);
            this.stuListBox.Name = "stuListBox";
            this.stuListBox.Size = new System.Drawing.Size(120, 164);
            this.stuListBox.TabIndex = 2;
            this.stuListBox.SelectedIndexChanged += new System.EventHandler(this.StuListBox_SelectedIndexChanged);
            // 
            // StudentAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.stuListBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvAssign);
            this.Name = "StudentAssignments";
            this.Text = "Student Assignments";
            this.Load += new System.EventHandler(this.StudentAssignments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssign)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void DgvAssign_CellBeginEdit(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAssign;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointsEarned;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointsPossible;
        private System.Windows.Forms.ListBox stuListBox = new System.Windows.Forms.ListBox();
    }
}