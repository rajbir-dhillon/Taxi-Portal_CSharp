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
    public partial class bookSession : Form
    {
        String selectedID;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public bookSession(String sID)
        {
            InitializeComponent();
            selectedID = sID;
            sessionListBox.Hide();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select training_type From training_type";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                trainingTypeBox.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        public class item {
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

        private void viewBtn_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From sessions WHERE Training_Type = @type";
            cmd.Parameters.AddWithValue("@type", trainingTypeBox.SelectedItem.ToString());
            dr = cmd.ExecuteReader();
            sessionListBox.Items.Clear();
            sessionListBox.DisplayMember = "getText";
            sessionListBox.ValueMember = "getSessionID";
            while (dr.Read())
            {
                
                sessionListBox.Items.Add(new item(dr[0].ToString(), dr[2].ToString() + " - " + dr[3].ToString()));
                //sessionListBox.Items.Add(dr[0].ToString() + " " + dr[2].ToString() + " - " + dr[3].ToString());
            }
            sessionListBox.Show();
            con.Close();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            item a = (item)sessionListBox.SelectedItem;
            label1.Text = a.getSessionID;
            MessageBox.Show(a.getSessionID);

            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO booking (sessionID, driverID, status) VALUES (@session,@driver, @status)";
            cmd.Parameters.AddWithValue("@session", a.getSessionID);
            cmd.Parameters.AddWithValue("@lName", selectedID);
            cmd.Parameters.AddWithValue("@status", "in-progress");
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
            this.Close();

        }
    }
}
