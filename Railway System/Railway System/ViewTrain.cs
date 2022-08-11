using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Railway_System
{
    public partial class ViewTrain : Form
    {
        public ViewTrain()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-I9CCNUJ\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True");

        private void populate()
        {
            Con.Open();
            string query = " select * from TrainTable ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TrainView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewTrain_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Trains trains = new Trains();
            trains.Show();
            this.Hide();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            trainNumbV.Text = "";
            trainNameV.Text = "";
            sourceBoxV.SelectedItem = "";
            destiBoxV.SelectedItem = "";
            avilSeatsV.Text = "";
        }

        private void TrainView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TrainView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                TrainView.CurrentRow.Selected = true;
                trainNumbV.Text = TrainView.Rows[e.RowIndex].Cells["TrainNumber"].FormattedValue.ToString();
                trainNameV.Text = TrainView.Rows[e.RowIndex].Cells["TrainName"].FormattedValue.ToString();
                sourceBoxV.SelectedItem = TrainView.Rows[e.RowIndex].Cells["TrainSource"].FormattedValue.ToString();
                destiBoxV.SelectedItem = TrainView.Rows[e.RowIndex].Cells["TrainDestination"].FormattedValue.ToString();
                avilSeatsV.Text = TrainView.Rows[e.RowIndex].Cells["TrainSeats"].FormattedValue.ToString();
            }
        }

        private void updateTrainbtn_Click(object sender, EventArgs e)
        {
            if (trainNumbV.Text == "" || trainNameV.Text == "" || avilSeatsV.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update TrainTable set TrainName = '" + trainNameV.Text + "', TrainSource = '" + sourceBoxV.SelectedItem.ToString() + "', TrainDestination = '" + destiBoxV.SelectedItem.ToString() + "', TrainSeats = " + avilSeatsV.Text + " where TrainNumber = '" + trainNumbV.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void deleteTrainbtn_Click(object sender, EventArgs e)
        {
            if (trainNumbV.Text == "")
            {
                MessageBox.Show("Enter the Train Number to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from TrainTable where TrainNumber='" + trainNumbV.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Deleted Susscessfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
