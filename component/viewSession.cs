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
    public partial class viewSession : Form
    {
        String selectedID;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public viewSession(String ID)
        {
            InitializeComponent();
            label1.Text = ID;
            selectedID = ID;

            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From  sessions Where ID = " + selectedID + "";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label3.Text = dr[1].ToString();
                label5.Text = dr[2].ToString();
                label7.Text = dr[3].ToString();
                
            }
            dr.Close();
            con.Close();
            updateList();
        }

        public void updateList()
        {
            driverSessionList.Items.Clear();
            OleDbCommand cmd1 = new OleDbCommand();
            con.Open();
            cmd1.Connection = con;
            cmd1.CommandText = "Select * From  booking Where sessionID = @ID AND [status] = 'in-progress'";
            cmd1.Parameters.AddWithValue("@ID", selectedID);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {

                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "Select * From drivers where ID = @DID";
                cmd2.Parameters.AddWithValue("@DID", dr1[2].ToString());
                OleDbDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.HasRows)
                {
                    driverSessionList.DisplayMember = "getText";
                    driverSessionList.ValueMember = "getSessionID";
                    while (dr2.Read())
                    {

                        driverSessionList.Items.Add(new item(dr2[0].ToString(), dr2[1].ToString() + " " + dr2[2].ToString()));
                        dr2.Read();
                    }
                }
                dr2.Close();
            }
            dr1.Close();
            con.Close();
        }

        public class item
        {
            private String _text;
            private String _sessionID;

            public item(String sessionID, String text)
            {
                _sessionID = sessionID;
                _text = text;
            }

            public string getText
            {
                get { return _text; }
            }

            public string getSessionID
            {
                get { return _sessionID; }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            item a = (item)driverSessionList.SelectedItem;
            
            OleDbCommand cmd2 = new OleDbCommand();
            con.Open();
            cmd2.Connection = con;
            cmd2.CommandText = "DELETE * FROM booking where driverID = @DID AND sessionID = @SID";
            cmd2.Parameters.AddWithValue("@DID", a.getSessionID);
            cmd2.Parameters.AddWithValue("@SID", selectedID);
            cmd2.ExecuteNonQuery();
            con.Close();
            updateList();
            MessageBox.Show("Booking Deleted");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            item a = (item)driverSessionList.SelectedItem;
            //MessageBox.Show(selectedID + " " + a.getSessionID);
            var updateSession = new updateSession(selectedID, a.getSessionID);
            updateSession.Show();
        }
    }
}