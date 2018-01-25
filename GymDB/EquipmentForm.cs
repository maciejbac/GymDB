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
    public partial class EquipmentForm : Form
    {
        public EquipmentForm()
        {
            InitializeComponent();

            EquipmentView dfrm = new EquipmentView();
            dfrm.TopLevel = false;
            dfrm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(dfrm);
            dfrm.Visible = true;

            comboBox1.Items.Add("Display Equipment");
            comboBox1.Items.Add("Rent Equipment");
            comboBox1.Items.Add("Return Equipment");
            comboBox1.SelectedItem = "Display Equipment";
        }

        OleDbConnection myConn = new OleDbConnection();

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Rent Equipment")
            {
                label3.Text = "Rent Equipment";
                EquipmentRent dfrm = new EquipmentRent();
                dfrm.TopLevel = false;
                dfrm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(dfrm);
                dfrm.Visible = true;

            }
            
            if (comboBox1.SelectedItem == "Return Equipment")
            {
                label3.Text = "Return Equipment";

                EquipmentReturn dfrm = new EquipmentReturn();
                dfrm.TopLevel = false;
                dfrm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(dfrm);
                dfrm.Visible = true;
            }

            if (comboBox1.SelectedItem == "Display Equipment")
            {
                label3.Text = "Equipment List";

                EquipmentView dfrm = new EquipmentView();
                dfrm.TopLevel = false;
                dfrm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(dfrm);
                dfrm.Visible = true;
            }

        }
    }
}