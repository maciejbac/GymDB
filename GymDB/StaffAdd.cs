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

namespace GymDB
{
    public partial class StaffAdd : Form
    {
        public StaffAdd()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) ||
                String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) ||
                String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection myConn = new OleDbConnection();

                myConn.ConnectionString = connectionDetails.dbsource;


                OleDbCommand myCmd = myConn.CreateCommand();

                myCmd.CommandText =
                "Insert Into Staff (StaffID, StaffName, Certification, Age, StaffPhone)" +
                " Values (@staffID, @staffN, @staffC, @staffAge, @staffPhone)";

                myCmd.Parameters.AddWithValue("staffID", textBox1.Text);
                myCmd.Parameters.AddWithValue("staffN", textBox2.Text);
                myCmd.Parameters.AddWithValue("staffC", textBox3.Text);
                myCmd.Parameters.AddWithValue("staffAge", textBox4.Text);
                myCmd.Parameters.AddWithValue("staffPhone", textBox5.Text);

                myConn.Open();
                int rowsChanged = myCmd.ExecuteNonQuery();
                myConn.Close();


                System.Windows.Forms.MessageBox.Show("Staff member " + textBox1.Text + " has been added.");
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                textBox3.Text = String.Empty;
                textBox4.Text = String.Empty;
                textBox5.Text = String.Empty;
            }
        }

       
    }
}