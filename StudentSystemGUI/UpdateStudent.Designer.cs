namespace StudentSystemGUI
{
    partial class UpdateStudent
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
            this.contentContainer = new System.Windows.Forms.TableLayoutPanel();
            this.stuIdSection = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.stuId = new System.Windows.Forms.TextBox();
            this.nameSection = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.liveOnCampSection = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.liveOnCamp = new System.Windows.Forms.CheckBox();
            this.liveOffCamp = new System.Windows.Forms.CheckBox();
            this.dormSection = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.dorms = new System.Windows.Forms.ComboBox();
            this.mealPlanSection = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.radBtnsSection = new System.Windows.Forms.FlowLayoutPanel();
            this.basic = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.buttonContainer = new System.Windows.Forms.TableLayoutPanel();
            this.submitSection = new System.Windows.Forms.FlowLayoutPanel();
            this.search = new System.Windows.Forms.Button();
            this.updateSection = new System.Windows.Forms.FlowLayoutPanel();
            this.update = new System.Windows.Forms.Button();
            this.exitSection = new System.Windows.Forms.FlowLayoutPanel();
            this.goBack = new System.Windows.Forms.Button();
            high = new System.Windows.Forms.RadioButton();
            this.contentContainer.SuspendLayout();
            this.stuIdSection.SuspendLayout();
            this.nameSection.SuspendLayout();
            this.liveOnCampSection.SuspendLayout();
            this.dormSection.SuspendLayout();
            this.mealPlanSection.SuspendLayout();
            this.radBtnsSection.SuspendLayout();
            this.buttonContainer.SuspendLayout();
            this.submitSection.SuspendLayout();
            this.updateSection.SuspendLayout();
            this.exitSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentContainer
            // 
            this.contentContainer.ColumnCount = 3;
            this.contentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.49967F));
            this.contentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.00066F));
            this.contentContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.49967F));
            this.contentContainer.Controls.Add(this.stuIdSection, 0, 0);
            this.contentContainer.Controls.Add(this.nameSection, 2, 0);
            this.contentContainer.Controls.Add(this.liveOnCampSection, 0, 1);
            this.contentContainer.Controls.Add(this.dormSection, 0, 2);
            this.contentContainer.Controls.Add(this.mealPlanSection, 2, 2);
            this.contentContainer.Location = new System.Drawing.Point(1, 31);
            this.contentContainer.Name = "contentContainer";
            this.contentContainer.RowCount = 3;
            this.contentContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.24226F));
            this.contentContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.51549F));
            this.contentContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.24226F));
            this.contentContainer.Size = new System.Drawing.Size(800, 291);
            this.contentContainer.TabIndex = 2;
            // 
            // stuIdSection
            // 
            this.stuIdSection.Controls.Add(this.label1);
            this.stuIdSection.Controls.Add(this.stuId);
            this.stuIdSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stuIdSection.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.stuIdSection.Location = new System.Drawing.Point(3, 3);
            this.stuIdSection.Name = "stuIdSection";
            this.stuIdSection.Padding = new System.Windows.Forms.Padding(25);
            this.stuIdSection.Size = new System.Drawing.Size(373, 111);
            this.stuIdSection.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // stuId
            // 
            this.stuId.Location = new System.Drawing.Point(28, 48);
            this.stuId.Name = "stuId";
            this.stuId.Size = new System.Drawing.Size(335, 26);
            this.stuId.TabIndex = 1;
            // 
            // nameSection
            // 
            this.nameSection.Controls.Add(this.label2);
            this.nameSection.Controls.Add(this.name);
            this.nameSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameSection.Enabled = false;
            this.nameSection.Location = new System.Drawing.Point(422, 3);
            this.nameSection.Name = "nameSection";
            this.nameSection.Padding = new System.Windows.Forms.Padding(5, 25, 25, 25);
            this.nameSection.Size = new System.Drawing.Size(375, 111);
            this.nameSection.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(8, 48);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(335, 26);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // liveOnCampSection
            // 
            this.contentContainer.SetColumnSpan(this.liveOnCampSection, 3);
            this.liveOnCampSection.Controls.Add(this.label3);
            this.liveOnCampSection.Controls.Add(this.liveOnCamp);
            this.liveOnCampSection.Controls.Add(this.liveOffCamp);
            this.liveOnCampSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liveOnCampSection.Location = new System.Drawing.Point(3, 120);
            this.liveOnCampSection.Name = "liveOnCampSection";
            this.liveOnCampSection.Padding = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.liveOnCampSection.Size = new System.Drawing.Size(794, 50);
            this.liveOnCampSection.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Does this student live on campus?";
            // 
            // liveOnCamp
            // 
            this.liveOnCamp.AutoSize = true;
            this.liveOnCamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.liveOnCamp.Location = new System.Drawing.Point(285, 15);
            this.liveOnCamp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.liveOnCamp.Name = "liveOnCamp";
            this.liveOnCamp.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.liveOnCamp.Size = new System.Drawing.Size(88, 24);
            this.liveOnCamp.TabIndex = 1;
            this.liveOnCamp.Text = "Yes";
            this.liveOnCamp.UseVisualStyleBackColor = true;
            this.liveOnCamp.CheckedChanged += new System.EventHandler(this.LiveOnCamp_CheckedChanged);
            // 
            // liveOffCamp
            // 
            this.liveOffCamp.AutoSize = true;
            this.liveOffCamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.liveOffCamp.Location = new System.Drawing.Point(379, 15);
            this.liveOffCamp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.liveOffCamp.Name = "liveOffCamp";
            this.liveOffCamp.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.liveOffCamp.Size = new System.Drawing.Size(59, 24);
            this.liveOffCamp.TabIndex = 2;
            this.liveOffCamp.Text = "No";
            this.liveOffCamp.UseVisualStyleBackColor = true;
            this.liveOffCamp.CheckedChanged += new System.EventHandler(this.LiveOffCamp_CheckedChanged);
            // 
            // dormSection
            // 
            this.dormSection.Controls.Add(this.label4);
            this.dormSection.Controls.Add(this.dorms);
            this.dormSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dormSection.Enabled = false;
            this.dormSection.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.dormSection.Location = new System.Drawing.Point(3, 176);
            this.dormSection.Name = "dormSection";
            this.dormSection.Padding = new System.Windows.Forms.Padding(25);
            this.dormSection.Size = new System.Drawing.Size(373, 112);
            this.dormSection.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dorm";
            // 
            // dorms
            // 
            this.dorms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dorms.FormattingEnabled = true;
            this.dorms.Items.AddRange(new object[] {
            "Oak",
            "Trustee",
            "Wapello",
            "Appanoose",
            "Mahaska"});
            this.dorms.Location = new System.Drawing.Point(28, 48);
            this.dorms.Name = "dorms";
            this.dorms.Size = new System.Drawing.Size(335, 28);
            this.dorms.TabIndex = 2;
            // 
            // mealPlanSection
            // 
            this.mealPlanSection.Controls.Add(this.label5);
            this.mealPlanSection.Controls.Add(this.radBtnsSection);
            this.mealPlanSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mealPlanSection.Enabled = false;
            this.mealPlanSection.Location = new System.Drawing.Point(422, 176);
            this.mealPlanSection.Name = "mealPlanSection";
            this.mealPlanSection.Padding = new System.Windows.Forms.Padding(5, 25, 25, 25);
            this.mealPlanSection.Size = new System.Drawing.Size(375, 112);
            this.mealPlanSection.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Meal Plan";
            // 
            // radBtnsSection
            // 
            this.radBtnsSection.Controls.Add(this.basic);
            this.radBtnsSection.Controls.Add(this.medium);
            this.radBtnsSection.Controls.Add(high);
            this.radBtnsSection.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.radBtnsSection.Location = new System.Drawing.Point(8, 48);
            this.radBtnsSection.Name = "radBtnsSection";
            this.radBtnsSection.Size = new System.Drawing.Size(335, 28);
            this.radBtnsSection.TabIndex = 3;
            // 
            // basic
            // 
            this.basic.AutoSize = true;
            this.basic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.basic.Location = new System.Drawing.Point(3, 3);
            this.basic.Name = "basic";
            this.basic.Size = new System.Drawing.Size(97, 24);
            this.basic.TabIndex = 1;
            this.basic.TabStop = true;
            this.basic.Text = "B - Basic";
            this.basic.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medium.Location = new System.Drawing.Point(111, 3);
            this.medium.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(116, 24);
            this.medium.TabIndex = 2;
            this.medium.TabStop = true;
            this.medium.Text = "M - Medium";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // high
            // 
            high.AutoSize = true;
            high.Cursor = System.Windows.Forms.Cursors.Hand;
            high.Location = new System.Drawing.Point(238, 3);
            high.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            high.Name = "high";
            high.Size = new System.Drawing.Size(92, 24);
            high.TabIndex = 3;
            high.TabStop = true;
            high.Text = "H - High";
            high.UseVisualStyleBackColor = true;
            // 
            // buttonContainer
            // 
            this.buttonContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonContainer.ColumnCount = 3;
            this.buttonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44482F));
            this.buttonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44482F));
            this.buttonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.11037F));
            this.buttonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonContainer.Controls.Add(this.submitSection, 0, 0);
            this.buttonContainer.Controls.Add(this.updateSection, 1, 0);
            this.buttonContainer.Controls.Add(this.exitSection, 2, 0);
            this.buttonContainer.Location = new System.Drawing.Point(1, 328);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.RowCount = 1;
            this.buttonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonContainer.Size = new System.Drawing.Size(797, 112);
            this.buttonContainer.TabIndex = 6;
            // 
            // submitSection
            // 
            this.submitSection.Controls.Add(this.search);
            this.submitSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitSection.Location = new System.Drawing.Point(3, 3);
            this.submitSection.Name = "submitSection";
            this.submitSection.Padding = new System.Windows.Forms.Padding(15, 30, 15, 0);
            this.submitSection.Size = new System.Drawing.Size(260, 106);
            this.submitSection.TabIndex = 0;
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Location = new System.Drawing.Point(18, 33);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(228, 46);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // updateSection
            // 
            this.updateSection.Controls.Add(this.update);
            this.updateSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateSection.Location = new System.Drawing.Point(269, 3);
            this.updateSection.Name = "updateSection";
            this.updateSection.Padding = new System.Windows.Forms.Padding(15, 30, 15, 0);
            this.updateSection.Size = new System.Drawing.Size(260, 106);
            this.updateSection.TabIndex = 1;
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Enabled = false;
            this.update.Location = new System.Drawing.Point(18, 33);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(227, 46);
            this.update.TabIndex = 0;
            this.update.Text = "Update Student";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // exitSection
            // 
            this.exitSection.Controls.Add(this.goBack);
            this.exitSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitSection.Location = new System.Drawing.Point(535, 3);
            this.exitSection.Name = "exitSection";
            this.exitSection.Padding = new System.Windows.Forms.Padding(15, 30, 15, 0);
            this.exitSection.Size = new System.Drawing.Size(259, 106);
            this.exitSection.TabIndex = 3;
            // 
            // goBack
            // 
            this.goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBack.Location = new System.Drawing.Point(18, 33);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(220, 46);
            this.goBack.TabIndex = 0;
            this.goBack.Text = "Return";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonContainer);
            this.Controls.Add(this.contentContainer);
            this.Name = "UpdateStudent";
            this.Text = "Update Student";
            this.contentContainer.ResumeLayout(false);
            this.stuIdSection.ResumeLayout(false);
            this.stuIdSection.PerformLayout();
            this.nameSection.ResumeLayout(false);
            this.nameSection.PerformLayout();
            this.liveOnCampSection.ResumeLayout(false);
            this.liveOnCampSection.PerformLayout();
            this.dormSection.ResumeLayout(false);
            this.dormSection.PerformLayout();
            this.mealPlanSection.ResumeLayout(false);
            this.mealPlanSection.PerformLayout();
            this.radBtnsSection.ResumeLayout(false);
            this.radBtnsSection.PerformLayout();
            this.buttonContainer.ResumeLayout(false);
            this.submitSection.ResumeLayout(false);
            this.updateSection.ResumeLayout(false);
            this.exitSection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel contentContainer;
        private System.Windows.Forms.FlowLayoutPanel stuIdSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stuId;
        private System.Windows.Forms.FlowLayoutPanel nameSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.FlowLayoutPanel liveOnCampSection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox liveOnCamp;
        private System.Windows.Forms.CheckBox liveOffCamp;
        private System.Windows.Forms.FlowLayoutPanel dormSection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel mealPlanSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel buttonContainer;
        private System.Windows.Forms.FlowLayoutPanel submitSection;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.FlowLayoutPanel updateSection;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.FlowLayoutPanel exitSection;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.ComboBox dorms;
        private System.Windows.Forms.FlowLayoutPanel radBtnsSection;
        private System.Windows.Forms.RadioButton basic;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton high;
    }
}