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
    public partial class CustomerAdd : Form
    {
        public CustomerAdd()
        {
            InitializeComponent();

            comboBox1.Items.Add("A0000001");
            comboBox1.Items.Add("A0000002");
            comboBox1.Items.Add("A0000003");
            comboBox1.Items.Add("A0000004");



        }


        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection myConn = new OleDbConnection();

            myConn.ConnectionString = connectionDetails.dbsource;


            OleDbCommand myCmd = myConn.CreateCommand();

            string membershipID = comboBox1.Text;

            myCmd.CommandText =
            "Insert Into Customer (CustomerName, Age, ContactNo, MembershipID)" +
            " Values (@custName, @custAge, @contactNo, @membership)";

            myCmd.Parameters.AddWithValue("custName", textBox1.Text);
            myCmd.Parameters.AddWithValue("custAge", textBox2.Text);
            myCmd.Parameters.AddWithValue("contactNo", textBox3.Text);

            myCmd.Parameters.AddWithValue("membership", membershipID);

            myConn.Open();
            int rowsChanged = myCmd.ExecuteNonQuery();
            myConn.Close();


            System.Windows.Forms.MessageBox.Show("Customer " + textBox1.Text + " has been added.");
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            comboBox1.Text = String.Empty;
        }
    }
}