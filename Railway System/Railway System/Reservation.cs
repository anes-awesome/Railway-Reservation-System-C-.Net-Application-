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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-I9CCNUJ\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = " select * from ReservationTable ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReservationView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void fillPassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(string));
            dt.Load(rdr);
            passIdR.ValueMember = "PassId";
            passIdR.DataSource = dt;
            Con.Close();
        }

        private void fillTrain()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TrainNumber from TrainTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainNumber", typeof(string));
            dt.Load(rdr);
            trainNumbR.ValueMember = "TrainNumber";
            trainNumbR.DataSource = dt;
            Con.Close();
        }

        

        private void bookTicketbtn_Click(object sender, EventArgs e)
        {
            if (ticketIdR.Text == "" || amountR.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into ReservationTable values('" + ticketIdR.Text + "','" + trainNumbR.SelectedValue.ToString() + "','" + passIdR.SelectedValue.ToString() + "', '"+amountR.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Reservation_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillTrain();
            populate();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            ticketIdR.Text = "";
            trainNumbR.SelectedItem = "";
            passIdR.SelectedItem = "";
            amountR.Text = "";
        }
    }
}
