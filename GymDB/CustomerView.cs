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
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();

            OleDbConnection myConn = new OleDbConnection();
            myConn.ConnectionString = connectionDetails.dbsource;

            string sql = "Select CustomerID, CustomerName, MembershipID, ContactNo From Customer";

            OleDbDataAdapter myDA = new OleDbDataAdapter(sql, myConn);
            DataTable dtCustomers = new DataTable();
            myDA.Fill(dtCustomers);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dtCustomers;

        }

    }
}