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
    public partial class view : Form
    {
        DataGridViewRow selectedRow;
        String selectedID;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public view(DataGridViewRow row)
        {
            InitializeComponent();
            selectedRow = row;
            selectedID = selectedRow.Cells[0].Value.ToString();
            view_load();

        }

        public void view_load()
        {
            idLabel.Text = selectedID;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From  drivers Where ID = " + selectedID + "";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                var datafName = dr[1].ToString();
                var datalName = dr[2].ToString();
                var dataNumber = dr[3].ToString();
                var dataLicense = dr[4].ToString();
                String datacLondon = dr[5].ToString();
                var datanLondon = dr[6].ToString();
                var datawLondon = dr[7].ToString();
                var dataeLondon = dr[8].ToString();
                var datasLondon = dr[9].ToString();

                fNameTextBox.Text = datafName;
                lNameTextBox.Text = datalName;
                numberTextBox.Text = dataNumber;
                licenseLabel.Text = dataLicense;
                cLabel.Text = datacLondon;
                nLabel.Text = datanLondon;
                wLabel.Text = datawLondon;
                eLabel.Text = dataeLondon;
                sLabel.Text = datasLondon;

                if (datacLondon == "true")
                {
                    cUpdate.Text = "Delete";
                }
                else
                {
                    cUpdate.Text = "Add";
                }

                if (datanLondon == "true")
                {
                    nUpdate.Text = "Delete";
                }
                else
                {
                    nUpdate.Text = "Add";
                }

                if (datawLondon == "true")
                {
                    wUpdate.Text = "Delete";
                }
                else
                {
                    wUpdate.Text = "Add";
                }

                if (datawLondon == "true")
                {
                    wUpdate.Text = "Delete";
                }
                else
                {
                    wUpdate.Text = "Add";
                }

                if (dataeLondon == "true")
                {
                    eUpdate.Text = "Delete";
                }
                else
                {
                    eUpdate.Text = "Add";
                }
                if (datasLondon == "true")
                {
                    sUpdate.Text = "Delete";
                }
                else
                {
                    sUpdate.Text = "Add";
                }
            }
            else
            {

            }
            con.Close();

            updateListBox();

        }
        private void updateListBox()
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select [sessions.Training_Type], [booking.status] FROM [booking] INNER JOIN [sessions] ON booking.sessionID = sessions.ID WHERE [driverID] = @DID AND [status] = 'pass'";
            
            cmd.Parameters.AddWithValue("@DID", selectedID);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString() + " - " + dr[1].ToString());
            }
            con.Close();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            String delQuery = "DELETE FROM drivers WHERE [ID]= @driverID";
            cmd = new OleDbCommand();
            cmd.CommandText = delQuery;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@driverID", selectedID);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void cUpdate_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Add")
            {
                con.Open();
                String delQuery = "UPDATE drivers SET cLondon = @cLondon WHERE [ID]= @driverID";
                cmd = new OleDbCommand();
                cmd.CommandText = delQuery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@cLondon", "true");
                cmd.Parameters.AddWithValue("@driverID", selectedID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Refresh();
                view_load();
                MessageBox.Show("recorded added");
                
            } else
            {
                con.Open();
                String delQuery = "UPDATE drivers SET cLondon = @cLondon WHERE [ID]= @driverID";
                cmd = new OleDbCommand();
                cmd.CommandText = delQuery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@cLondon", "false");
                cmd.Parameters.AddWithValue("@driverID", selectedID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Refresh();
                view_load();
                MessageBox.Show("record deleted");
                
            }

        }

        private void nUpdate_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Add")
            {
                con.Open();
                String delQuery = "UPDATE drivers SET nLondon = @nLondon WHERE [ID]= @driverID";
                cmd = new OleDbCommand();
                cmd.CommandText = delQuery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@nLondon", "true");
                cmd.Parameters.AddWithValue("@driverID", selectedID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Refresh();
                view_load();
                MessageBox.Show("recorded added");
            
            }
            else
            {
                con.Open();
                String delQuery = "UPDATE drivers SET nLondon = @nLondon WHERE [ID]= @driverID";
                cmd = new OleDbCommand();
                cmd.CommandText = delQuery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@nLondon", "false");
                cmd.Parameters.AddWithValue("@driverID", selectedID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Refresh();
                view_load();
                MessageBox.Show("record deleted");
                
            }
        }

        private void wUpdate_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Add")
            {
                con.Open();
                String delQuery = "UPDATE drivers SET wLondon = @wLondon WHERE [ID]= @driverID";
                cmd = new OleDbCommand();
                cmd.CommandText = delQuery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@wLondon", "true");
                cmd.Parameters.AddWithValue("@driverID", selectedID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Refresh();
                view_load();
                MessageBox.Show("recorded added");
                
            }
            else
            {
                con.Open();
                String delQuery = "UPDATE drivers SET wLondon = @wLondon WHERE [ID]= @driverID";
                cmd = new OleDbCommand();
                cmd.CommandText = delQuery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@wLondon", "false");
                cmd.Parameters.AddWithValue("@driverID", selectedID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Refresh();
                view_load();
                MessageBox.Show("record deleted");
                
            }
        }

        private void eUpdate_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Add")
            {
                con.Open();
                String delQuery = "UPDATE drivers SET eLondon = @eLondon WHERE [ID]= @driverID";
                cmd = new OleDbCommand();
                cmd.CommandText = delQuery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@eLondon", "true");
                cmd.Parameters.AddWithValue("@driverID", selectedID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Refresh();
                view_load();
                MessageBox.Show("recorded added");
                
            }
            else
            {
                con.Open();
                String delQuery = "UPDATE drivers SET eLondon = @eLondon WHERE [ID]= @driverID";
                cmd = new OleDbCommand();
                cmd.CommandText = delQuery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@eLondon", "false");
                cmd.Parameters.AddWithValue("@driverID", selectedID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Refresh();
                view_load();
                MessageBox.Show("record deleted");
                
            }
        }

        private void sUpdate_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Add")
            {
                con.Open();
                String delQuery = "UPDATE drivers SET sLondon = @sLondon WHERE [ID]= @driverID";
                cmd = new OleDbCommand();
                cmd.CommandText = delQuery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@sLondon", "true");
                cmd.Parameters.AddWithValue("@driverID", selectedID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Refresh();
                view_load();
                MessageBox.Show("recorded added");
                
            }
            else
            {
                con.Open();
                String delQuery = "UPDATE drivers SET sLondon = @sLondon WHERE [ID]= @driverID";
                cmd = new OleDbCommand();
                cmd.CommandText = delQuery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@sLondon", "false");
                cmd.Parameters.AddWithValue("@driverID", selectedID);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Refresh();
                view_load();
                MessageBox.Show("record deleted");
                
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            String delQuery = "UPDATE drivers SET fName = @fName, lName = @lName, [number] = @number  WHERE [ID]= @driverID";
            cmd = new OleDbCommand();
            cmd.CommandText = delQuery;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@fName", fNameTextBox.Text);
            cmd.Parameters.AddWithValue("@lName", lNameTextBox.Text);
            cmd.Parameters.AddWithValue("@number", numberTextBox.Text);
            cmd.Parameters.AddWithValue("@driverID", selectedID);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Refresh();
            view_load();
            MessageBox.Show("record updated");
        }

        private void addSessionBtn_Click(object sender, EventArgs e)
        {
            var bookSession = new bookSession(selectedID);
            bookSession.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DateTime nowDate = DateTime.Now;
            DateTime expiryDate = DateTime.Now.AddDays(30);
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select [sessions.Training_Type], [booking.status], [booking.expiry] FROM [booking] INNER JOIN [sessions] ON booking.sessionID = sessions.ID WHERE [driverID] = @DID AND [booking.expiry] BETWEEN '@nDate' AND '@eDate'";
            
            cmd.Parameters.AddWithValue("@DID", selectedID);
            cmd.Parameters.AddWithValue("@nDate", nowDate.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@eDate", expiryDate.ToString("dd/MM/yyyy"));
            dr = cmd.ExecuteReader();
            listBox1.Items.Clear();
            if (dr.Read())
            {
                
                DateTime oDate = Convert.ToDateTime(dr[2].ToString());
                listBox1.Items.Add(dr[0].ToString() + " - " + dr[1].ToString());
                
            }
            con.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var reportPage = new reportPage(selectedID);
            reportPage.Show();
        }
    }
}





