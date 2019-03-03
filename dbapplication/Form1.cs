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
    public partial class Form1 : Form
    {
        DataTable vt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disconnectToolStripMenuItem.Enabled = false;
            runQueryToolStripMenuItem.ShortcutKeys = Keys.F5;
            insertRecordToolStripMenuItem.ShortcutKeys = Keys.F6;
            updateRecordToolStripMenuItem.ShortcutKeys = Keys.F7;
            deleteRecordToolStripMenuItem.ShortcutKeys = Keys.F8;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\prg455\\labproject\\Project Database.accdb;Persist Security Info=False";
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(constr);         // establishes connection to the database
            disconnectToolStripMenuItem.Enabled = true;
            connectToolStripMenuItem.Enabled = false;
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(constr);
            conn.Close();
            disconnectToolStripMenuItem.Enabled = false;
            connectToolStripMenuItem.Enabled = true;
        }

        private void runQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlstr = textBoxQuery.Text;
            if (connectToolStripMenuItem.Enabled == false)
            {
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
                    da.Fill(vt);
                    da.Dispose();
                    dataGridViewQuery.DataSource = null;
                    dataGridViewQuery.Refresh();
                    dataGridViewQuery.Rows.Clear();
                    dataGridViewQuery.DataSource = vt;
                }
                catch (Exception ar)
                {
                    MessageBox.Show(ar.Message);
                }
            }
            else
            {
                MessageBox.Show("Please connect to the database first!");
            }
        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectToolStripMenuItem.Enabled == false)
            {
                FormUpdate formupdate = new FormUpdate();
                formupdate.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please connect to the database first!");
            }
        }

        private void insertRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (connectToolStripMenuItem.Enabled == false)
            {
                FormInsert forminsert = new FormInsert();
                forminsert.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please connect to the database first!");
            }
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectToolStripMenuItem.Enabled == false)
            {
                FormDelete formdelete = new FormDelete();
                formdelete.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please connect to the database first!");
            }
        }
    }
}
