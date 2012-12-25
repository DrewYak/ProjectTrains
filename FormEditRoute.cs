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
        bool    afterSearch;
        string  lastX;
        string  lastY;
        public FormEditRoute()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FillGridView(List<Station> stns)
        {
            this.tableStations.Rows.Clear();
            foreach (Station stn in stns)
            {
                this.tableStations.Rows.Add(false, stn.Name, stn.X, stn.Y);
            }
        }

        private void FormEditRoute_Activated(object sender, EventArgs e)
        {
            List<Station> stns = Station.Search();
            FillGridView(stns);

        }

         private void button1_Click(object sender, EventArgs e)
         {
             List<string> delStns = new List<string>();
             for (int i = 0; i < tableStations.RowCount; i++)
             {
                 if (Convert.ToBoolean(tableStations.Rows[i].Cells[0].Value))
                 {
                     string stn = Convert.ToString(tableStations.Rows[i].Cells[1].Value);
                     delStns.Add(stn);
                 }
             }
             foreach (string numStn in delStns)
             {
                 Station delete = Station.SearchByName(numStn);
                 delete.RemoveFromAllStations();
             }
             FormEditRoute_Activated(sender, e);
         }

         private void button2_Click(object sender, EventArgs e)
         {
             string Name = Convert.ToString(this.nameStation.Text);
             Station entStn = Station.SearchByName(Name);
             if (entStn == null)
             {
                 int X = Convert.ToInt32(this.xStation.Text);
                 int Y = Convert.ToInt32(this.yStation.Text);
                 Station Stn = new Station(Name, X, Y);
             }
             FormEditRoute_Activated(sender, e);
             nameStation_TextChanged(sender, e);
         }

         private void nameStation_TextChanged(object sender, EventArgs e)
         {
             xStations_TextChanged(sender, e);
             if (this.nameStation.Text != "")
             {
                 string     Name    = Convert.ToString(this.nameStation.Text);
                 Station    entStn  = Station.SearchByName(Name);
                 if (entStn != null)
                 {
                     if (!afterSearch)
                     {
                         lastX                  = xStation.Text;                     
                         lastY                  = yStation.Text;
                     }
                     this.xStation.Text     = Convert.ToString(entStn.X);
                     this.yStation.Text     = Convert.ToString(entStn.Y);
                     this.xStation.Enabled  = false;
                     this.yStation.Enabled  = false;
                     add.Enabled            = false;
                     afterSearch            = true;
                 }
                 else
                 {
                     this.xStation.Enabled  = true;
                     this.yStation.Enabled  = true;
                     
                     if (afterSearch == true)
                     {
                         this.xStation.Clear();
                         this.yStation.Clear();
                         this.xStation.Text     = lastX;
                         this.yStation.Text     = lastY;
                         afterSearch            = false;
                     }
                 }
             }
         }

         private void xStations_TextChanged(object sender, EventArgs e)
         {
             if ((nameStation.Text != "") &&
                    (xStation.Text != "") &&
                    (yStation.Text != "")
                )
             {
                 add.Enabled = true;
             }
             else
             {
                 add.Enabled = false;
             }
         }
    }
}
