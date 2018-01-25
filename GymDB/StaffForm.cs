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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();

            comboBox1.Items.Add("Display Staff");
            comboBox1.Items.Add("Add Staff");
            comboBox1.Items.Add("Update Staff");
            comboBox1.SelectedItem = "Display Staff";

            StaffView dfrm = new StaffView();
            dfrm.TopLevel = false;
            dfrm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(dfrm);
            dfrm.Visible = true;

        }

        OleDbConnection myConn = new OleDbConnection();

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Add Staff")
            {
                label3.Text = "Add Staff";
                         
                StaffAdd frm = new StaffAdd();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(frm);
                frm.Visible = true;

            }

            if (comboBox1.SelectedItem == "Update Staff")
            {
                label3.Text = "Update Staff";

                StaffUpdate frm = new StaffUpdate();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(frm);
                frm.Visible = true;

            }


            if (comboBox1.SelectedItem == "Display Staff")
            {
                label3.Text = "Display Staff";

                StaffView dfrm = new StaffView();
                dfrm.TopLevel = false;
                dfrm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(dfrm);
                dfrm.Visible = true;
            }
        }


    }
}