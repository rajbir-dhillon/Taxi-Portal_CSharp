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
    public partial class login : Form
    {
        //private string connectionString;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public login()
        {
            InitializeComponent();

            loginContent.Location = new Point(
                this.ClientSize.Width / 2 - loginContent.Size.Width / 2,
                this.ClientSize.Height / 2 - loginContent.Size.Height / 2);
            loginContent.Anchor = AnchorStyles.None;
        }

        private void loginContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From  Users Where userName = '" + userTextBox.Text + "' AND passWord = '" + passTextBox.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.Hide();
                var dashboard = new dashboard();
                dashboard.Closed += (s, args) => this.Close();
                dashboard.Show();
            } else
            {
                MessageBox.Show("Username or password is incorrect");
            }
            con.Close();




            //this.Hide();
            //var dashboard = new dashboard();
            //dashboard.Closed += (s, args) => this.Close();
            //dashboard.Show();
        }
    }
}
