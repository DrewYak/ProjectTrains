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
             List<string> delStns = new List<string>();
             for (int i = 0; i < dataGridView1.RowCount; i++)
             {
                 if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                 {
                     string del = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                     delStns.Add(del);
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
             string Name = Convert.ToString(this.textBox1.Text);
             Station entStn = Station.SearchByName(Name);
             if (entStn == null)
             {
                 int X = Convert.ToInt32(this.textBox2.Text);
                 int Y = Convert.ToInt32(this.textBox3.Text);
                 Station Stn = new Station(Name, X, Y);
             }
             FormEditRoute_Activated(sender, e);
             textBox1_TextChanged(sender, e);
         }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {
             textBox2_TextChanged(sender, e);
             if (this.textBox1.Text != "")
             {
                 string Name = Convert.ToString(this.textBox1.Text);
                 Station entStn = Station.SearchByName(Name);
                 if (entStn != null)
                 {
                     int X = entStn.X;
                     int Y = entStn.Y;
                     this.textBox2.Text = Convert.ToString(X);
                     this.textBox3.Text = Convert.ToString(Y);
                     this.textBox2.Enabled = false;
                     this.textBox3.Enabled = false;
                     button2.Enabled = false;
                 }
                 else
                 {
                     this.textBox2.Enabled = true;
                     this.textBox3.Enabled = true;
                     button2.Enabled = true;

                     this.textBox2.Clear();
                     this.textBox3.Clear();
                 }
             }
         }

         private void textBox2_TextChanged(object sender, EventArgs e)
         {
             if ((textBox1.Text != "") &&
                    (textBox2.Text != "") &&
                    (textBox3.Text != "")
                )
             {
                 button2.Enabled = true;
             }
             else
             {
                 button2.Enabled = false;
             }
         }
    }
}
