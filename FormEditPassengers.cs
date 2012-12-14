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
    public partial class FormEditPassengers : Form
    {
        public FormEditPassengers()
        {
            InitializeComponent();
        }

        private void FormEditPassengers_Activated(object sender, EventArgs e)
        {
            List<Passenger> ResultPas = Passenger.Search("", "", "");
            foreach (Passenger Psg in ResultPas)
            {
                this.dataGridView1.Rows.Add(false, Psg.LastName, Psg.FirstName, Psg.CountOfTickets);
            }
        }

        private void FormEditPassengers_Load(object sender, EventArgs e)
        {

        }
    }
}
