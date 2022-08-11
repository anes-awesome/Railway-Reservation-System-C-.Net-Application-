using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_System
{
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-I9CCNUJ\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True");

        private void populate()
        {
            Con.Open();
            string query = " select * from PassengerTable ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger();
            passenger.Show();
            this.Hide();
        }

        private void deletePassbtn_Click(object sender, EventArgs e)
        {
            if(passIdV.Text == "")
            {
                MessageBox.Show("Enter the Passenger ID to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PassengerTable where PassId='" + passIdV.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PassengerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(PassengerView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                PassengerView.CurrentRow.Selected = true;
                passIdV.Text = PassengerView.Rows[e.RowIndex].Cells["PassId"].FormattedValue.ToString();
                passNameV.Text = PassengerView.Rows[e.RowIndex].Cells["PassName"].FormattedValue.ToString();
                passAgeV.Text = PassengerView.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                passAddrV.Text = PassengerView.Rows[e.RowIndex].Cells["PassAddress"].FormattedValue.ToString();
                passCityV.Text = PassengerView.Rows[e.RowIndex].Cells["City"].FormattedValue.ToString();
                passGenderV.SelectedItem = PassengerView.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                passNatioV.SelectedItem = PassengerView.Rows[e.RowIndex].Cells["Nationality"].FormattedValue.ToString();
                passContactV.Text = PassengerView.Rows[e.RowIndex].Cells["Contact"].FormattedValue.ToString();
            }
            
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            passIdV.Text = "";
            passNameV.Text = "";
            passAgeV.Text = "";
            passAddrV.Text = "";
            passCityV.Text = "";
            passContactV.Text = "";
            passGenderV.SelectedItem = "";
            passNatioV.SelectedItem = "";
        }

        private void updatePassbtn_Click(object sender, EventArgs e)
        {
            if (passIdV.Text == "" || passNameV.Text == "" || passAgeV.Text == "" || passAddrV.Text == "" || passCityV.Text == "" || passContactV.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengerTable set PassName = '" + passNameV.Text + "', Age = '" + passAgeV.Text + "', PassAddress = '" + passAddrV.Text + "', City = '" + passCityV.Text + "', Gender = '" + passGenderV.SelectedItem.ToString() + "', Nationality = '" + passNatioV.SelectedItem.ToString() + "', Contact = '" + passContactV.Text + "' where PassId = '" + passIdV.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");
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
