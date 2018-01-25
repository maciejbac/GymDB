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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

            comboBox1.Items.Add("Display Customers");
            comboBox1.Items.Add("Add Customer");
            comboBox1.Items.Add("Update Customer");
            comboBox1.Items.Add("Delete Customer");
            comboBox1.SelectedItem = "Display Customers";

            CustomerView dfrm = new CustomerView();
            dfrm.TopLevel = false;
            dfrm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(dfrm);
            dfrm.Visible = true;

        }

        OleDbConnection myConn = new OleDbConnection();

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Add Customer")
            {
                label3.Text = "Add Customer";
                         
                CustomerAdd frm = new CustomerAdd();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(frm);
                frm.Visible = true;

            }

            if (comboBox1.SelectedItem == "Update Customer")
            {
                label3.Text = "Update Customer";

                CustomerUpdate frm = new CustomerUpdate();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(frm);
                frm.Visible = true;

            }

            if (comboBox1.SelectedItem == "Delete Customer")
            {
                label3.Text = "Delete Customer";

                CustomerDelete frm = new CustomerDelete();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(frm);
                frm.Visible = true;
            }

            if (comboBox1.SelectedItem == "Display Customers")
            {
                label3.Text = "Display Customers";

                CustomerView dfrm = new CustomerView();
                dfrm.TopLevel = false;
                dfrm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(dfrm);
                dfrm.Visible = true;
            }
        }


    }
}