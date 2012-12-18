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
                initialStation.Items.Add(Stn.Name);
                terminalStation.Items.Add(Stn.Name);
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
             string Time1Dep = timeArrInit.Text;
             string Time1Arr = timeDepInit.Text;
             string Time2Dep = timeArrTerm.Text;
             string Time2Arr = timeDepTerm.Text;
             Station Stn1 = Station.SearchByName(Convert.ToString(initialStation.Text));
             Station Stn2 = Station.SearchByName(Convert.ToString(terminalStation.Text));
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

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            timeArrInit.Text = e.Start.ToString();
            timeArrTerm.Text = e.Start.ToString();
            timeDepInit.Text = e.Start.ToString();
            timeDepTerm.Text = e.Start.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.MaskCompleted)
            {
                int     trainNumber = Convert.ToInt32(textBox1.Text);
                Train   train       = Train.Search(trainNumber);
                if (train != null)
                {
                    initialStation.Text     = train.PointOfDeparture;
                    terminalStation.Text    = train.PointOfArrival;
                    timeArrInit.Text        = train.RouteNodes.First().TimeOfArrival;
                    timeDepInit.Text        = train.RouteNodes.First().TimeOfDeparture;
                    timeArrTerm.Text        = train.RouteNodes.Last().TimeOfArrival;
                    timeDepTerm.Text        = train.RouteNodes.Last().TimeOfDeparture;
                    groupBox1.Enabled       = false;
                }
                else
                {
                    groupBox1.Enabled       = true;
                }
            }
            else
            {
                groupBox1.Enabled   = true;
            }
        }
    }
}
