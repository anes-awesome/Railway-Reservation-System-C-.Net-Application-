using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void trainBtn_Click(object sender, EventArgs e)
        {
            Trains trains = new Trains();
            trains.Show();
            this.Hide();
        }

        private void passengerBtn_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger();
            passenger.Show();
            this.Hide();
        }

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Hide();
        }

        private void cancellationBtn_Click(object sender, EventArgs e)
        {
            Cancellation cancellation = new Cancellation();
            cancellation.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
