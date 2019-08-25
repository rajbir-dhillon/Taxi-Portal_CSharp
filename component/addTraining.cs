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
    public partial class addTraining : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb");
        public addTraining()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO training_type (training_type) VALUES (@type)";
            cmd.Parameters.AddWithValue("@type", textBox1.Text);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            this.Close();
        }
    }
}
