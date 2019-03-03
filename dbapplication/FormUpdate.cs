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
    public partial class FormUpdate : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public FormUpdate()
        {
            InitializeComponent();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\prg455\\labproject\\Project Database.accdb;Persist Security Info=False";
            conn.ConnectionString = constr;
        }

        public void clearfunc()
        {
            textBox1Update.Clear();
            textBox2Update.Clear();
            textBox3Update.Clear();
            textBox4Update.Clear();
            textBox5Update.Clear();
        }

        private void RBCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (RBCourse.Checked == true)
            {
                clearfunc();
                label1Update.Text = "Course ID";
                label2Update.Text = "Course Name";
                label3Update.Text = "Course Code";
                label4Update.Text = "Course Fee";
                label5Update.Text = "Course Location";
            }
        }

        private void RBSchool_CheckedChanged(object sender, EventArgs e)
        {
            if (RBSchool.Checked == true)
            {
                clearfunc();
                label1Update.Text = "School ID";
                label2Update.Text = "School Name";
                label3Update.Text = "School Address";
                label4Update.Text = "School Phone";
                label5Update.Text = "Course ID";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 formc = new Form1();
            formc.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearfunc();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string queryStringSchool = "SELECT `School Name`, `School Address`, `School Phone`, `Course` FROM School WHERE `School ID Number`=" + textBox1Update.Text + "";
            string queryStringCourse = "SELECT `Course name`, `Course code`, `Course fee`, `Course location` FROM Course WHERE `Course ID`=" + textBox1Update.Text + "";
            if (RBSchool.Checked==true)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand(queryStringSchool, conn);
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox2Update.Text = reader.GetString(0);
                            textBox3Update.Text = reader.GetString(1);
                            textBox4Update.Text = reader.GetString(2);
                            textBox5Update.Text = reader.GetString(3);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                conn.Close();
            }
            if (RBCourse.Checked == true)
            {
                try
                {
                    OleDbCommand cmdn = new OleDbCommand(queryStringCourse, conn);
                    conn.Open();
                    using (OleDbDataReader reader = cmdn.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox2Update.Text = reader.GetString(0);
                            textBox3Update.Text = reader.GetString(1);
                            textBox4Update.Text = reader.GetString(2);
                            textBox5Update.Text = reader.GetString(3);
                        }
                    }
                    cmdn.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                conn.Close();
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                if (RBSchool.Checked == true)
                {
                    cmd.CommandText = "UPDATE School SET `School Name`=@schoolName, `School Address`=@schoolAdr, `School Phone`=@schoolPhone, `Course`=@courseID WHERE `School ID Number`=" + textBox1Update.Text + "";
                    cmd.Parameters.AddWithValue("@schoolName", textBox2Update.Text);
                    cmd.Parameters.AddWithValue("@schoolAdr", textBox3Update.Text);
                    cmd.Parameters.AddWithValue("@schoolPhone", textBox4Update.Text);
                    cmd.Parameters.AddWithValue("@courseID", textBox5Update.Text);
                    MessageBox.Show("School Information successfully updated!");
                }
                if (RBCourse.Checked == true)
                {
                    cmd.CommandText = "UPDATE Course SET `Course name`=@courseName, `Course code`=@courseCode, `Course fee`=@courseFee, `Course location`=@courseLocation WHERE `Course ID`=" + textBox1Update.Text + "";
                    cmd.Parameters.AddWithValue("@courseName", textBox2Update.Text);
                    cmd.Parameters.AddWithValue("@courseCode", textBox3Update.Text);
                    cmd.Parameters.AddWithValue("@courseFee", textBox4Update.Text);
                    cmd.Parameters.AddWithValue("@courseLocation", textBox5Update.Text);
                    MessageBox.Show("Course Information successfully updated!");
                }
                cmd.ExecuteNonQuery();
             }
             catch (Exception ex) { MessageBox.Show(ex.Message); }
             conn.Close();
             this.Close();
             Form1 form = new Form1();
             form.Show();
        }
    }
}
