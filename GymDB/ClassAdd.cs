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
    public partial class ClassAdd : Form
    {
        public ClassAdd()
        {
            InitializeComponent();

            comboBox1.Items.Add("R0000001");
            comboBox1.Items.Add("R0000002");
            comboBox1.Items.Add("R0000003");

            comboBox2.Items.Add("S0000001");
            comboBox2.Items.Add("S0000002");
            comboBox2.Items.Add("S0000003");



        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) ||
                String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) ||
                String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection myConn = new OleDbConnection();
                myConn.ConnectionString = connectionDetails.dbsource;
                OleDbCommand myCmd = myConn.CreateCommand();

                string RoomID = comboBox1.Text;
                string staffID = comboBox2.Text;


                myCmd.CommandText =
                "INSERT INTO Class(ClassID, ClassSize, RoomNumber, StaffID, RunningDate, RunningTime) " +
                "VALUES (@cID, @cSize, @room, @staff, @rD, @rT)";

                myCmd.Parameters.AddWithValue("cID", textBox1.Text);
                myCmd.Parameters.AddWithValue("cSize", textBox2.Text);
                myCmd.Parameters.AddWithValue("room", RoomID);
                myCmd.Parameters.AddWithValue("staff", staffID);
                myCmd.Parameters.AddWithValue("rD", textBox3.Text);
                myCmd.Parameters.AddWithValue("rT", textBox4.Text);



                myConn.Open();
                int rowsChanged = myCmd.ExecuteNonQuery();
                myConn.Close();


                System.Windows.Forms.MessageBox.Show("Class " + textBox1.Text + " has been added.");
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                textBox3.Text = String.Empty;
                textBox4.Text = String.Empty;
                comboBox1.Text = String.Empty;
                comboBox2.Text = String.Empty;
            }
        }
    }
}