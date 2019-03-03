using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace labproject
{
    public partial class FormInsert : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public FormInsert()
        {
            InitializeComponent();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\prg455\\labproject\\Project Database.accdb;Persist Security Info=False";
            conn.ConnectionString = constr;
        }

        public void clearfunc()
        {
            textBox1Insert.Text = "";
            textBox2Insert.Text = "";
            textBox3Insert.Text = "";
            textBox4Insert.Text = "";
        }

        private void RBCourse_CheckedChanged(object sender, EventArgs e)
        {
            clearfunc();
            label1Insert.Text = "Course Name";
            label2Insert.Text = "Course Code";
            label3Insert.Text = "Course Fee";
            label4Insert.Text = "Course Location";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearfunc();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                if (RBSchool.Checked == true)
                {
                    cmd.CommandText = "INSERT INTO School (`School Name`, `School Address`, `School Phone`, `Course`) VALUES (@schoolName,@schoolAdr, @schoolPhone, @courseID)";
                    cmd.Parameters.AddWithValue("@schoolName", textBox1Insert.Text);
                    cmd.Parameters.AddWithValue("@schoolAdr", textBox2Insert.Text);
                    cmd.Parameters.AddWithValue("@schoolPhone", textBox3Insert.Text);
                    cmd.Parameters.AddWithValue("@courseID", textBox4Insert.Text);
                    MessageBox.Show("School Information successfully saved!");
                }
                if (RBCourse.Checked == true)
                {
                    cmd.CommandText = "INSERT INTO Course (`Course name`, `Course code`, `Course fee`, `Course location`) VALUES (@courseName, @courseCode, @courseFee, @courseLocation)";
                    cmd.Parameters.AddWithValue("@courseName", textBox1Insert.Text);
                    cmd.Parameters.AddWithValue("@courseCode", textBox2Insert.Text);
                    cmd.Parameters.AddWithValue("@courseFee", textBox3Insert.Text);
                    cmd.Parameters.AddWithValue("@courseLocation", textBox4Insert.Text);
                    MessageBox.Show("Course Information successfully saved!");
                }
                cmd.ExecuteNonQuery();
                this.Close();
                Form1 form = new Form1();
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
        }

        private void RBSchool_CheckedChanged(object sender, EventArgs e)
        {
            if (RBSchool.Checked == true)
            {
                clearfunc();
                label1Insert.Text = "School Name";
                label2Insert.Text = "School Address";
                label3Insert.Text = "School Phone";
                label4Insert.Text = "Course ID";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 formc = new Form1();
            formc.Show();
        }
    }
}
