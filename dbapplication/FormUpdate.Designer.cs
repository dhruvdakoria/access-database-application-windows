namespace labproject
{
    partial class FormUpdate
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
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.RBCourse = new System.Windows.Forms.RadioButton();
            this.RBSchool = new System.Windows.Forms.RadioButton();
            this.label1Update = new System.Windows.Forms.Label();
            this.label2Update = new System.Windows.Forms.Label();
            this.label3Update = new System.Windows.Forms.Label();
            this.label4Update = new System.Windows.Forms.Label();
            this.label5Update = new System.Windows.Forms.Label();
            this.textBox1Update = new System.Windows.Forms.TextBox();
            this.textBox2Update = new System.Windows.Forms.TextBox();
            this.textBox3Update = new System.Windows.Forms.TextBox();
            this.textBox4Update = new System.Windows.Forms.TextBox();
            this.textBox5Update = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Controls.Add(this.RBCourse);
            this.groupBoxTable.Controls.Add(this.RBSchool);
            this.groupBoxTable.Location = new System.Drawing.Point(40, 28);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Size = new System.Drawing.Size(256, 51);
            this.groupBoxTable.TabIndex = 0;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "Table";
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
            // label1Update
            // 
            this.label1Update.Location = new System.Drawing.Point(12, 121);
            this.label1Update.Name = "label1Update";
            this.label1Update.Size = new System.Drawing.Size(90, 21);
            this.label1Update.TabIndex = 1;
            this.label1Update.Text = "School ID";
            // 
            // label2Update
            // 
            this.label2Update.Location = new System.Drawing.Point(12, 142);
            this.label2Update.Name = "label2Update";
            this.label2Update.Size = new System.Drawing.Size(99, 17);
            this.label2Update.TabIndex = 2;
            this.label2Update.Text = "School Name";
            // 
            // label3Update
            // 
            this.label3Update.Location = new System.Drawing.Point(12, 164);
            this.label3Update.Name = "label3Update";
            this.label3Update.Size = new System.Drawing.Size(99, 22);
            this.label3Update.TabIndex = 3;
            this.label3Update.Text = "School Address";
            // 
            // label4Update
            // 
            this.label4Update.Location = new System.Drawing.Point(12, 187);
            this.label4Update.Name = "label4Update";
            this.label4Update.Size = new System.Drawing.Size(99, 22);
            this.label4Update.TabIndex = 4;
            this.label4Update.Text = "School Phone";
            // 
            // label5Update
            // 
            this.label5Update.Location = new System.Drawing.Point(12, 208);
            this.label5Update.Name = "label5Update";
            this.label5Update.Size = new System.Drawing.Size(99, 22);
            this.label5Update.TabIndex = 5;
            this.label5Update.Text = "Course ID";
            // 
            // textBox1Update
            // 
            this.textBox1Update.Location = new System.Drawing.Point(109, 116);
            this.textBox1Update.Name = "textBox1Update";
            this.textBox1Update.Size = new System.Drawing.Size(173, 20);
            this.textBox1Update.TabIndex = 6;
            // 
            // textBox2Update
            // 
            this.textBox2Update.Location = new System.Drawing.Point(109, 139);
            this.textBox2Update.Name = "textBox2Update";
            this.textBox2Update.Size = new System.Drawing.Size(173, 20);
            this.textBox2Update.TabIndex = 7;
            // 
            // textBox3Update
            // 
            this.textBox3Update.Location = new System.Drawing.Point(109, 161);
            this.textBox3Update.Name = "textBox3Update";
            this.textBox3Update.Size = new System.Drawing.Size(173, 20);
            this.textBox3Update.TabIndex = 8;
            // 
            // textBox4Update
            // 
            this.textBox4Update.Location = new System.Drawing.Point(109, 184);
            this.textBox4Update.Name = "textBox4Update";
            this.textBox4Update.Size = new System.Drawing.Size(173, 20);
            this.textBox4Update.TabIndex = 9;
            // 
            // textBox5Update
            // 
            this.textBox5Update.Location = new System.Drawing.Point(109, 208);
            this.textBox5Update.Name = "textBox5Update";
            this.textBox5Update.Size = new System.Drawing.Size(173, 20);
            this.textBox5Update.TabIndex = 10;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(310, 113);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(310, 142);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(310, 187);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(310, 216);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 283);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBox5Update);
            this.Controls.Add(this.textBox4Update);
            this.Controls.Add(this.textBox3Update);
            this.Controls.Add(this.textBox2Update);
            this.Controls.Add(this.textBox1Update);
            this.Controls.Add(this.label5Update);
            this.Controls.Add(this.label4Update);
            this.Controls.Add(this.label3Update);
            this.Controls.Add(this.label2Update);
            this.Controls.Add(this.label1Update);
            this.Controls.Add(this.groupBoxTable);
            this.Name = "FormUpdate";
            this.Text = "Update";
            this.groupBoxTable.ResumeLayout(false);
            this.groupBoxTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.RadioButton RBCourse;
        private System.Windows.Forms.RadioButton RBSchool;
        private System.Windows.Forms.Label label1Update;
        private System.Windows.Forms.Label label2Update;
        private System.Windows.Forms.Label label3Update;
        private System.Windows.Forms.Label label4Update;
        private System.Windows.Forms.Label label5Update;
        private System.Windows.Forms.TextBox textBox1Update;
        private System.Windows.Forms.TextBox textBox2Update;
        private System.Windows.Forms.TextBox textBox3Update;
        private System.Windows.Forms.TextBox textBox4Update;
        private System.Windows.Forms.TextBox textBox5Update;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
    }
}