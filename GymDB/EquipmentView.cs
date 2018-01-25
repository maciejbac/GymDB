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
    public partial class EquipmentView : Form
    {
        public EquipmentView()
        {
            InitializeComponent();

            OleDbConnection myConn = new OleDbConnection();
            myConn.ConnectionString = connectionDetails.dbsource;

            string sql = "SELECT EquipmentID, TypeOfEquipment FROM Equipment";

            OleDbDataAdapter myDA = new OleDbDataAdapter(sql, myConn);
            DataTable dtClass = new DataTable();
            myDA.Fill(dtClass);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dtClass;

        }

    }
}