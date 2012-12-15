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

        private void FillGridView(List<Train> ResultTrn)
        {
            this.dataGridView1.Rows.Clear();
            foreach (Train Trn in ResultTrn)
            {
                this.dataGridView1.Rows.Add(false, Trn.Number, Trn.PointOfArrival, Trn.PointOfDeparture);
            }
        }

        private void FormEditTrains_Activated(object sender, EventArgs e)
        {
            List<Train> ResultTrn = Train.Search("", "");
            FillGridView(ResultTrn);
        }

        private void FormEditTrains_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    int del = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    Train delete = Train.Search(del);
                    delete.RemoveFromAllTrains();
                    FormEditTrains_Activated(sender, e);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
