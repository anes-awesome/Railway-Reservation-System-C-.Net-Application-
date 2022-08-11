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
    public partial class Cancellation : Form
    {
        public Cancellation()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-I9CCNUJ\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = " select * from CancellationTable ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CancellationView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void fillTicket()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TicketId from ReservationTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TicketId", typeof(string));
            dt.Load(rdr);
            ticketIdC.ValueMember = "TicketId";
            ticketIdC.DataSource = dt;
            Con.Close();
        }

        private void Cancellation_Load(object sender, EventArgs e)
        {
            fillTicket();
            populate();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void deleteTicket()
        {
            try
            {
                Con.Open();
                string query = "delete from ReservationTable where TicketId='" + ticketIdC.SelectedValue.ToString() + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reserved Ticket Deleted Susscessfully");
                Con.Close();
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


            private void cancelTicketbtn_Click(object sender, EventArgs e)
            {
                if (cancelId.Text == "")
                {
                    MessageBox.Show("Information Missing");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "insert into CancellationTable values('" + cancelId.Text + "','" + ticketIdC.SelectedValue.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ticket Cancelled Successfully");
                        Con.Close();
                        populate();
                        deleteTicket();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            cancelId.Text = "";
            ticketIdC.SelectedItem = "";
        }
    }
}
