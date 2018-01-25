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
    public partial class CustomerUpdate : Form
    {
        public CustomerUpdate()
        {
            InitializeComponent();

            OleDbConnection myConn = new OleDbConnection();
            myConn.ConnectionString = connectionDetails.dbsource;

            string sql = "Select CustomerID, ContactNo From Customer";

            OleDbDataAdapter myDA = new OleDbDataAdapter(sql, myConn);
            DataTable dtCustomers = new DataTable();
            myDA.Fill(dtCustomers);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dtCustomers;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Enter all the required details please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection myConn = new OleDbConnection();
                myConn.ConnectionString = connectionDetails.dbsource;
                OleDbCommand myCmd = myConn.CreateCommand();

                myCmd.CommandText =
                "Update Customer Set ContactNo = " + textBox2.Text +
                " Where CustomerID = " + textBox1.Text;

                myConn.Open();
                int rowsChanged = myCmd.ExecuteNonQuery();
                myConn.Close();


                System.Windows.Forms.MessageBox.Show("Customer " + textBox1.Text + " has been updated.");
                textBox1.Text = String.Empty;
            }
        }
    }
}