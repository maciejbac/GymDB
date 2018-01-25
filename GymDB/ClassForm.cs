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
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();

            comboBox1.Items.Add("Display Classes");
            comboBox1.Items.Add("Add Class");
            comboBox1.SelectedItem = "Display Classes";

            ClassView dfrm = new ClassView();
            dfrm.TopLevel = false;
            dfrm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(dfrm);
            dfrm.Visible = true;

        }

        OleDbConnection myConn = new OleDbConnection();

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Add Class")
            {
                label3.Text = "Add Class";
                ClassAdd dfrm = new ClassAdd();
                dfrm.TopLevel = false;
                dfrm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(dfrm);
                dfrm.Visible = true;

            }
            
            if (comboBox1.SelectedItem == "Display Classes")
            {
                label3.Text = "Display Classes";

                ClassView dfrm = new ClassView();
                dfrm.TopLevel = false;
                dfrm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(dfrm);
                dfrm.Visible = true;
            }
        }
    }
}