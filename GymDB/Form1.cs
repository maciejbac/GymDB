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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection myConn = new OleDbConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.ConnectionString = connectionDetails.dbsource;
                myConn.Open();
                label1.Text = "Connected";

                pictureBox1.Image = GymDB.Properties.Resources.EzGym2;
   
                button1.Enabled = false;
                button2.Enabled = true;
                CustomerOptions.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                myConn.Close();
                label1.Text = "Disconnected";
                pictureBox1.Image = GymDB.Properties.Resources.EzGym;
                button1.Enabled = true;
                button2.Enabled = false;

                CustomerOptions.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerOptions_Click(object sender, EventArgs e)
        {
            CustomerForm _CustomerForm = new CustomerForm();
            _CustomerForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClassForm _ClassForm = new ClassForm();
            _ClassForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EquipmentForm _EquipmentForm = new EquipmentForm();
            _EquipmentForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StaffForm _StaffForm = new StaffForm();
            _StaffForm.ShowDialog();
        }
    }
}
