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
    public partial class reportPage : Form
    {
        String ID;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb");
        public reportPage(String driverID)
        {
            InitializeComponent();
            ID = driverID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO report (driverID, incident, notes) VALUES (@driverID, @incident, @notes)";
            cmd.Parameters.AddWithValue("@driverID", ID);
            cmd.Parameters.AddWithValue("@incident", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@number", textBox1.Text);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Report submitted");
            this.Close();
        }
    }
}
