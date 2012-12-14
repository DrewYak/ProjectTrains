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
    public partial class FormEditTrains : Form
    {
        public FormEditTrains()
        {
            InitializeComponent();
        }

        private void FormEditTrains_Activated(object sender, EventArgs e)
        {
            List<Train> ResultTrn = Train.Search("", "");
            foreach (Train Trn in ResultTrn)
            {
                this.dataGridView1.Rows.Add(false, Trn.Number, Trn.PointOfArrival, Trn.PointOfDeparture);
            }
        }

        private void FormEditTrains_Load(object sender, EventArgs e)
        {

        }
    }
}
