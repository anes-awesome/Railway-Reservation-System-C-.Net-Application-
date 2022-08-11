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
    public partial class Trains : Form
    {
        public Trains()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-I9CCNUJ\SQLEXPRESS;Initial Catalog=RailwayDB;Integrated Security=True");

        private void addTrainbtn_Click(object sender, EventArgs e)
        {
            if (trainNum.Text == "" || trainName.Text == "" || sourceBox.SelectedItem.ToString() == "" || destiBox.SelectedItem.ToString() == "" || avilSeats.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into TrainTable values('" + trainNum.Text + "','" + trainName.Text + "','" + sourceBox.SelectedItem.ToString() + "','" + destiBox.SelectedItem.ToString() + "','" + avilSeats.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Added Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void viewTrainbtn_Click(object sender, EventArgs e)
        {
            ViewTrain viewTrain = new ViewTrain();
            viewTrain.Show();
            this.Hide();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            trainNum.Text = "";
            trainName.Text = "";
            sourceBox.SelectedItem = "";
            destiBox.SelectedItem = "";
            avilSeats.Text = "";
        }
    }
}
