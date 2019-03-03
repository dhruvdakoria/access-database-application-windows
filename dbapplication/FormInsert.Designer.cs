namespace labproject
{
    partial class FormInsert
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox4Insert = new System.Windows.Forms.TextBox();
            this.textBox3Insert = new System.Windows.Forms.TextBox();
            this.textBox2Insert = new System.Windows.Forms.TextBox();
            this.textBox1Insert = new System.Windows.Forms.TextBox();
            this.label4Insert = new System.Windows.Forms.Label();
            this.label3Insert = new System.Windows.Forms.Label();
            this.label2Insert = new System.Windows.Forms.Label();
            this.label1Insert = new System.Windows.Forms.Label();
            this.groupBoxTableInsert = new System.Windows.Forms.GroupBox();
            this.RBCourse = new System.Windows.Forms.RadioButton();
            this.RBSchool = new System.Windows.Forms.RadioButton();
            this.groupBoxTableInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(310, 208);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(310, 179);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(310, 133);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox4Insert
            // 
            this.textBox4Insert.Location = new System.Drawing.Point(120, 205);
            this.textBox4Insert.Name = "textBox4Insert";
            this.textBox4Insert.Size = new System.Drawing.Size(173, 20);
            this.textBox4Insert.TabIndex = 25;
            // 
            // textBox3Insert
            // 
            this.textBox3Insert.Location = new System.Drawing.Point(120, 181);
            this.textBox3Insert.Name = "textBox3Insert";
            this.textBox3Insert.Size = new System.Drawing.Size(173, 20);
            this.textBox3Insert.TabIndex = 24;
            // 
            // textBox2Insert
            // 
            this.textBox2Insert.Location = new System.Drawing.Point(120, 158);
            this.textBox2Insert.Name = "textBox2Insert";
            this.textBox2Insert.Size = new System.Drawing.Size(173, 20);
            this.textBox2Insert.TabIndex = 23;
            // 
            // textBox1Insert
            // 
            this.textBox1Insert.Location = new System.Drawing.Point(120, 136);
            this.textBox1Insert.Name = "textBox1Insert";
            this.textBox1Insert.Size = new System.Drawing.Size(173, 20);
            this.textBox1Insert.TabIndex = 22;
            // 
            // label4Insert
            // 
            this.label4Insert.Location = new System.Drawing.Point(23, 205);
            this.label4Insert.Name = "label4Insert";
            this.label4Insert.Size = new System.Drawing.Size(99, 22);
            this.label4Insert.TabIndex = 20;
            this.label4Insert.Text = "Course ID";
            // 
            // label3Insert
            // 
            this.label3Insert.Location = new System.Drawing.Point(23, 184);
            this.label3Insert.Name = "label3Insert";
            this.label3Insert.Size = new System.Drawing.Size(99, 22);
            this.label3Insert.TabIndex = 19;
            this.label3Insert.Text = "School Phone";
            // 
            // label2Insert
            // 
            this.label2Insert.Location = new System.Drawing.Point(23, 161);
            this.label2Insert.Name = "label2Insert";
            this.label2Insert.Size = new System.Drawing.Size(99, 22);
            this.label2Insert.TabIndex = 18;
            this.label2Insert.Text = "School Address";
            // 
            // label1Insert
            // 
            this.label1Insert.Location = new System.Drawing.Point(23, 139);
            this.label1Insert.Name = "label1Insert";
            this.label1Insert.Size = new System.Drawing.Size(99, 17);
            this.label1Insert.TabIndex = 17;
            this.label1Insert.Text = "School Name";
            // 
            // groupBoxTableInsert
            // 
            this.groupBoxTableInsert.Controls.Add(this.RBCourse);
            this.groupBoxTableInsert.Controls.Add(this.RBSchool);
            this.groupBoxTableInsert.Location = new System.Drawing.Point(41, 26);
            this.groupBoxTableInsert.Name = "groupBoxTableInsert";
            this.groupBoxTableInsert.Size = new System.Drawing.Size(256, 51);
            this.groupBoxTableInsert.TabIndex = 15;
            this.groupBoxTableInsert.TabStop = false;
            this.groupBoxTableInsert.Text = "Table";
            // 
            // RBCourse
            // 
            this.RBCourse.AutoSize = true;
            this.RBCourse.Location = new System.Drawing.Point(135, 20);
            this.RBCourse.Name = "RBCourse";
            this.RBCourse.Size = new System.Drawing.Size(58, 17);
            this.RBCourse.TabIndex = 1;
            this.RBCourse.TabStop = true;
            this.RBCourse.Text = "Course";
            this.RBCourse.UseVisualStyleBackColor = true;
            this.RBCourse.CheckedChanged += new System.EventHandler(this.RBCourse_CheckedChanged);
            // 
            // RBSchool
            // 
            this.RBSchool.AutoSize = true;
            this.RBSchool.Location = new System.Drawing.Point(23, 20);
            this.RBSchool.Name = "RBSchool";
            this.RBSchool.Size = new System.Drawing.Size(58, 17);
            this.RBSchool.TabIndex = 0;
            this.RBSchool.TabStop = true;
            this.RBSchool.Text = "School";
            this.RBSchool.UseVisualStyleBackColor = true;
            this.RBSchool.CheckedChanged += new System.EventHandler(this.RBSchool_CheckedChanged);
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 283);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBox4Insert);
            this.Controls.Add(this.textBox3Insert);
            this.Controls.Add(this.textBox2Insert);
            this.Controls.Add(this.textBox1Insert);
            this.Controls.Add(this.label4Insert);
            this.Controls.Add(this.label3Insert);
            this.Controls.Add(this.label2Insert);
            this.Controls.Add(this.label1Insert);
            this.Controls.Add(this.groupBoxTableInsert);
            this.Name = "FormInsert";
            this.Text = "Insert";
            this.groupBoxTableInsert.ResumeLayout(false);
            this.groupBoxTableInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox4Insert;
        private System.Windows.Forms.TextBox textBox3Insert;
        private System.Windows.Forms.TextBox textBox2Insert;
        private System.Windows.Forms.TextBox textBox1Insert;
        private System.Windows.Forms.Label label4Insert;
        private System.Windows.Forms.Label label3Insert;
        private System.Windows.Forms.Label label2Insert;
        private System.Windows.Forms.Label label1Insert;
        private System.Windows.Forms.GroupBox groupBoxTableInsert;
        private System.Windows.Forms.RadioButton RBCourse;
        private System.Windows.Forms.RadioButton RBSchool;
    }
}