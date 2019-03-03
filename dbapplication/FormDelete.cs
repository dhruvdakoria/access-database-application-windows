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
    public partial class FormDelete : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public FormDelete()
        {
            InitializeComponent();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\prg455\\labproject\\Project Database.accdb;Persist Security Info=False";
            conn.ConnectionString = constr;
        }
        public void clearfunc()
        {
            textBox1Delete.Clear();
            textBox2Delete.Clear();
            textBox3Delete.Clear();
            textBox4Delete.Clear();
            textBox5Delete.Clear();
        }
        private void RBSchoolDelete_CheckedChanged(object sender, EventArgs e)
        {
            clearfunc();
            if (RBSchool.Checked == true)
            {
                label1Delete.Text = "School ID";
                label2Delete.Text = "School Name";
                label3Delete.Text = "School Address";
                label4Delete.Text = "School Phone";
                label5Delete.Text = "Course ID";
            }
        }

        private void RBCourseDelete_CheckedChanged(object sender, EventArgs e)
        {
            clearfunc();
            if (RBCourse.Checked == true)
            {
                label1Delete.Text = "Course ID";
                label2Delete.Text = "Course Name";
                label3Delete.Text = "Course Code";
                label4Delete.Text = "Course Fee";
                label5Delete.Text = "Course Location";
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
            string queryStringSchool = "SELECT `School Name`, `School Address`, `School Phone`, `Course` FROM School WHERE `School ID Number`=" + textBox1Delete.Text + "";
            string queryStringCourse = "SELECT `Course name`, `Course code`, `Course fee`, `Course location` FROM Course WHERE `Course ID`=" + textBox1Delete.Text + "";
            if (RBSchool.Checked == true)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand(queryStringSchool, conn);
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox2Delete.Text = reader.GetString(0);
                            textBox3Delete.Text = reader.GetString(1);
                            textBox4Delete.Text = reader.GetString(2);
                            textBox5Delete.Text = reader.GetString(3);
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
                            textBox2Delete.Text = reader.GetString(0);
                            textBox3Delete.Text = reader.GetString(1);
                            textBox4Delete.Text = reader.GetString(2);
                            textBox5Delete.Text = reader.GetString(3);
                        }
                    }
                    cmdn.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                conn.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                if (RBSchool.Checked == true)
                {
                    cmd.CommandText = "DELETE * FROM School WHERE `School ID Number`=" + textBox1Delete.Text + "";
                }
                if (RBCourse.Checked == true)
                {
                    cmd.CommandText = "DELETE * FROM Course WHERE `Course ID`=" + textBox1Delete.Text + "";
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
