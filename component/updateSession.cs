using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace component
{
    public partial class updateSession : Form
    {
        String selectedID;
        String driverID;
        
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb");
        OleDbDataReader dr;
        OleDbCommand cmd;
        public updateSession(String SID, String DID)
        {
            InitializeComponent();
            selectedID = SID;
            driverID = DID;
            label1.Text = selectedID;
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From drivers Where ID = " + driverID + "";
            dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    label1.Text = dr[1].ToString() + " " + dr[2].ToString() + " " + selectedID + " " + driverID;
                }
            }
            con.Close();
        }

        private void passBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            String delQuery = "UPDATE booking SET [status] = 'pass', [expiry] = @expiry  WHERE [sessionID]= @sessionID AND driverID = @driverID";
            cmd = new OleDbCommand();
            cmd.CommandText = delQuery;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@expiry", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@sessionID", selectedID);
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
