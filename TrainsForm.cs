using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trains
{
    public partial class TrainsForm : Form
    {
        public TrainsForm()
        {
            InitializeComponent();
        }

        private void ButSearchTrain_Click(object sender, EventArgs e)
        {
            SearchTrains STForm = new SearchTrains();
            STForm.PreviousForm = this;
            STForm.ShowDialog();
        }

        private void butData_Click(object sender, EventArgs e)
        {
            Passenger.AddDataFromFile("TrainsAndAnotherStuff.xml");
        }

        private void butGraphic_Click(object sender, EventArgs e)
        {

        }

        private void ButSearchPas_Click(object sender, EventArgs e)
        {
            SearchPassengers SPForm = new SearchPassengers();
            SPForm.PreviousForm     = this;
            SPForm.ShowDialog();
        }
    }
}
