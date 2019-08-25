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
    public partial class dashboard : Form
    {
        DataGridViewRow row;
        DataGridViewRow sessionRow;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        String sessionID;

        public dashboard()
        {
            InitializeComponent();

            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb");
            populateData();
        }

        private void populateData()
        {
            trainingComboBox.Items.Clear();
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select training_type From training_type";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                trainingComboBox.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        private void driverBtn_Click(object sender, EventArgs e)
        {
            driverPanel.BringToFront();
        }

        private void qualBtn_Click(object sender, EventArgs e)
        {
            qualPanel.BringToFront();
        }

        private void trainingBtn_Click(object sender, EventArgs e)
        {
            trainingPanel.BringToFront();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.sessions' table. You can move, or remove it, as needed.
            this.sessionsTableAdapter.Fill(this.databaseDataSet.sessions);
            // TODO: This line of code loads data into the 'databaseDataSet.drivers' table. You can move, or remove it, as needed.
            this.driversTableAdapter.Fill(this.databaseDataSet.drivers);
            // TODO: This line of code loads data into the 'databaseDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addDriver = new addDriver();
            addDriver.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.refreshTable();
        }

        public void refreshTable()
        {
            this.driversTableAdapter.Fill(this.databaseDataSet.drivers);
            driversDataGridView.Update();
            //driversDataGridView.Refresh();
            this.sessionsTableAdapter.Fill(this.databaseDataSet.sessions);
            sessionsDataGridView.Refresh();
        }
        private void driversDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void driversDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach(DataGridViewCell selectedCell in driversDataGridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                row = cell.OwningRow;
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            var view = new view(row);
            view.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = driversDataGridView.DataSource;
            bs.Filter = "fName ='" + searchTextbox.Text + "'";
            driversDataGridView.DataSource = bs;

        }

        private void addSessionBtn_Click(object sender, EventArgs e)
        {
            String sDate = startDatePicker.Text;
            String eDate = endDatePicker.Text;
            String type = trainingComboBox.Text;

            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO sessions (Training_Type, sDate, eDate) VALUES (@type, @sdate, @edate)";
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@sdate", sDate);
            cmd.Parameters.AddWithValue("@edate", eDate);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            
            
            MessageBox.Show("added");
            refreshTable();
            //this.sessionsTableAdapter.Fill(this.databaseDataSet.sessions);
           // sessionsDataGridView.Refresh();
        }

        private void viewSessionBtn_Click(object sender, EventArgs e)
        {
            var viewSession = new viewSession(sessionID);
            viewSession.Show();
        }

        private void sessionsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in sessionsDataGridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                sessionRow = cell.OwningRow;
            }
           
            sessionID = sessionRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addTraining = new addTraining();
            addTraining.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            populateData();
            refreshTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd2 = new OleDbCommand();
            con.Open();
            cmd2.Connection = con;
            cmd2.CommandText = "DELETE * FROM training_type where training_type = @type";
            cmd2.Parameters.AddWithValue("@type", trainingComboBox.SelectedItem.ToString());
            cmd2.ExecuteNonQuery();
            MessageBox.Show(trainingComboBox.SelectedItem.ToString());
            con.Close();
            populateData();
        }
    }
}

