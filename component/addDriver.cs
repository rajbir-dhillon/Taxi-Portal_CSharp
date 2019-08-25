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
    public partial class addDriver : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb");
        public addDriver()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO drivers (fName, lName, [number], license, cLondon, nLondon, wLondon, eLondon, sLondon) VALUES (@fName,@lName,@number,@license, @cLondon, @nLondon, @wLondon, @eLondon, @sLondon)";
                cmd.Parameters.AddWithValue("@fName", fnameTextBox.Text);
                cmd.Parameters.AddWithValue("@lName", lnameTextBox.Text);
                cmd.Parameters.AddWithValue("@number", numberTextBox.Text);
                cmd.Parameters.AddWithValue("@license", "true");
                cmd.Connection = con;
                if (!licenseBox.Checked)
                {
                    MessageBox.Show("Driver must have a Driving license");
                } else
                {
                    if (nBox.Checked || cBox.Checked || wbox.Checked || eBox.Checked || sBox.Checked)
                    {
                        if (nBox.Checked)
                        {
                            cmd.Parameters.AddWithValue("@nLondon", "true");
                        } else
                        {
                            cmd.Parameters.AddWithValue("@nLondon", "false");
                        }

                        if (cBox.Checked)
                        {
                            cmd.Parameters.AddWithValue("@cLondon", "true");
                        } else
                        {
                            cmd.Parameters.AddWithValue("@cLondon", "false");
                        }

                        if (wbox.Checked)
                        {
                            cmd.Parameters.AddWithValue("@wLondon", "true");
                        } else
                        {
                            cmd.Parameters.AddWithValue("@wLondon", "false");
                        }

                        if (eBox.Checked)
                        {
                            cmd.Parameters.AddWithValue("@eLondon", "true");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@eLondon", "false");
                        }

                        if (sBox.Checked)
                        {
                            cmd.Parameters.AddWithValue("@sLondon", "true");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@sLondon", "false");
                        }
                        cmd.ExecuteNonQuery();
                        this.Close();
                    } else
                    {
                        MessageBox.Show("Driver must complete atleast one geographical test");
                    }
                }
                
                con.Close();
                
            }
            catch (Exception ex)
            {
                numberTextBox.Text = ex.ToString();
               
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void licenseBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}