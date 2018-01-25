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
    public partial class EquipmentRent : Form
    {
        public EquipmentRent()
        {
            InitializeComponent();

            OleDbConnection myConn = new OleDbConnection();
            myConn.ConnectionString = connectionDetails.dbsource;

            string sql = "Select CustomerID, CustomerName From Customer";

            OleDbDataAdapter myDA = new OleDbDataAdapter(sql, myConn);
            DataTable dtCustomers = new DataTable();
            myDA.Fill(dtCustomers);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dtCustomers;


            string sql2 = "Select EquipmentID, TypeOfEquipment From Equipment";
            OleDbDataAdapter myDA2 = new OleDbDataAdapter(sql2, myConn);
            DataTable dtEquipment = new DataTable();
            myDA2.Fill(dtEquipment);
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = dtEquipment;

            comboBox1.Items.Add("E0000001");
            comboBox1.Items.Add("E0000002");
            comboBox1.Items.Add("E0000003");
            comboBox1.Items.Add("E0000004");
            comboBox1.Items.Add("E0000005");
            comboBox1.Items.Add("E0000006");
            comboBox1.Items.Add("E0000007");
            comboBox1.Items.Add("E0000008");
            comboBox1.Items.Add("E0000009");
            comboBox1.Items.Add("E0000010");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection myConn = new OleDbConnection();

                myConn.ConnectionString = connectionDetails.dbsource;
                OleDbCommand myCmd = myConn.CreateCommand();

                myCmd.CommandText =
                "UPDATE Customer SET EquipmentID = @eID WHERE CustomerID = @cID";

                myCmd.Parameters.AddWithValue("eID", comboBox1.Text);
                myCmd.Parameters.AddWithValue("cID", textBox1.Text);


                myConn.Open();
                int rowsChanged = myCmd.ExecuteNonQuery();
                myConn.Close();


                System.Windows.Forms.MessageBox.Show("Customer " + textBox1.Text + " has rented " + comboBox1.Text + ".");
                textBox1.Text = String.Empty;
                comboBox1.Text = String.Empty;

            }
        }
    }
}