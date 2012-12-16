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
            List<Station> Stns = Station.Search();
            foreach (Station Stn in Stns)
            {
                comboBox1.Items.Add(Stn.Name);
                comboBox2.Items.Add(Stn.Name);
                comboBox3.Items.Add(Stn.Name);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> delTrns = new List<int>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    int del = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    delTrns.Add(del);
                }
            }
            foreach (int numTrn in delTrns)
            {
                Train delete = Train.Search(numTrn);
                delete.RemoveFromAllTrains();

            }
            FormEditTrains_Activated(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
          {
             int Number = Convert.ToInt32(this.textBox1.Text);
             Train entTrn = Train.Search(Number);
             string Time1Dep = maskedTextBox1.Text;
             string Time1Arr = maskedTextBox3.Text;
             string Time2Dep = maskedTextBox2.Text;
             string Time2Arr = maskedTextBox4.Text;
             Station Stn1 = Station.SearchByName(Convert.ToString(comboBox1.Text));
             Station Stn2 = Station.SearchByName(Convert.ToString(comboBox2.Text));
             if (entTrn == null)
             {
                Train Trn = new Train(Number);
                RouteNode  RN1 = new RouteNode(Stn1, Time1Arr, Time1Dep);
                RouteNode  RN2 = new RouteNode(Stn2, Time2Arr, Time2Dep);  
                Trn.AddRouteNode(RN1);
                Trn.AddRouteNode(RN2);
             }
             else
             {
                 string time1Dep = entTrn.RouteNodes[0].TimeOfDeparture;
                 string time1Arr = entTrn.RouteNodes[0].TimeOfArrival;
                 string time2Dep = entTrn.RouteNodes[entTrn.RouteNodes.Count - 1].TimeOfDeparture;
                 string time2Arr = entTrn.RouteNodes[entTrn.RouteNodes.Count - 1].TimeOfArrival;
             }
             FormEditTrains_Activated(sender, e);
             //textBox1_TextChanged(sender, e);
         }
    }
}
