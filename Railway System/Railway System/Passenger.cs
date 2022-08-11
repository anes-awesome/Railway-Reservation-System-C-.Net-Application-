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
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-I9CCNUJ\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True");

        private void viewPassbtn_Click(object sender, EventArgs e)
        {
            ViewPassenger viewpassenger = new ViewPassenger();
            viewpassenger.Show();
            this.Hide();
        }

        private void addPassbtn_Click(object sender, EventArgs e)
        {
            if (passId.Text == "" || passName.Text == "" || passAge.Text == "" || passAddr.Text == "" || passCity.Text == "" || passContact.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PassengerTable values('" + passId.Text + "','" + passName.Text + "','" + passAge.Text + "','" + passAddr.Text + "','" + passCity.Text + "','" + passGender.SelectedItem.ToString() + "','" + passNation.SelectedItem.ToString() + "','" + passContact.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Added Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            passId.Text = "";
            passName.Text = "";
            passAge.Text = "";
            passAddr.Text = "";
            passCity.Text = "";
            passContact.Text = "";
            passGender.SelectedItem = "";
            passNation.SelectedItem = "";
        }
    }
}
