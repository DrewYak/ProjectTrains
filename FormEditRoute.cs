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
    public partial class FormEditRoute : Form
    {
        public FormEditRoute()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FillGridView(List<Station> stns)
        {
            this.dataGridView1.Rows.Clear();
            foreach (Station stn in stns)
            {
                this.dataGridView1.Rows.Add(false, stn.Name, stn.X, stn.Y);
            }
        }

        private void FormEditRoute_Activated(object sender, EventArgs e)
        {
            List<Station> stns = Station.Search();
            FillGridView(stns);

        }

         private void button1_Click(object sender, EventArgs e)
         {
             /* for (int i = 0; i < dataGridView1.RowCount; i++)
                  if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                  {
                      int del = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                      Station delete = Station.Search(del);
                      delete.RemoveFromAllStation();
                      FormEditRoute_Activated(sender, e);
                  }*/
         }
    }
}
