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
    public partial class ClassView : Form
    {
        public ClassView()
        {
            InitializeComponent();

            OleDbConnection myConn = new OleDbConnection();
            myConn.ConnectionString = connectionDetails.dbsource;

            string sql = "Select ClassID, RoomNumber, StaffID, RunningDate, RunningTime From Class";

            OleDbDataAdapter myDA = new OleDbDataAdapter(sql, myConn);
            DataTable dtClass = new DataTable();
            myDA.Fill(dtClass);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dtClass;

        }

    }
}