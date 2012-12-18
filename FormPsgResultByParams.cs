using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Trains
{
    public partial class PsgResultByParams : Form
    {
        public PsgResultByParams()
        {
            InitializeComponent();
        }


        private void FillInfoWithoutTicket(Passenger Pasg)
        {
            treeView1.Nodes[0].Text = Pasg.ID.ToString();
            treeView1.Nodes[0].Nodes[0].Text = Pasg.FirstName;
            treeView1.Nodes[0].Nodes[1].Text = Pasg.LastName;
            treeView1.Nodes[0].Nodes[2].Text = "Билеты";
            treeView1.Nodes[0].Nodes[2].Nodes[0].Text = "Плацкарт";
            treeView1.Nodes[0].Nodes[2].Nodes[1].Text = "Купе";
        }


        private void FillTreeviewTicket(List<Ticket> tkts)
        {
            treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Clear();
            treeView1.Nodes[0].Nodes[2].Nodes[1].Nodes.Clear();
            foreach (Ticket tkt in tkts)
            {
                if (tkt.Type == "Плацкарт")
                { treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Add(tkt.Train.Number.ToString()
                    +" "+ tkt.Train.PointOfArrival
                    + " - " + tkt.Train.PointOfDeparture); }
                if (tkt.Type == "Купе")
                {
                    treeView1.Nodes[0].Nodes[2].Nodes[1].Nodes.Add(tkt.Train.Number.ToString()
                      + " " + tkt.Train.PointOfArrival
                      + " - " + tkt.Train.PointOfDeparture);
                }
            }
        }

        private void FillTreeviewPsgs(Passenger Pasg)
        {
            FillInfoWithoutTicket(Pasg);
            List<Ticket> tkts = Pasg.Tickets;
            FillTreeviewTicket(tkts);
            treeView1.Visible = true;
            
        }
        private void TablePas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showPassengers.Checked)
            {
                treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Clear();
                treeView1.Nodes[0].Nodes[2].Nodes[1].Nodes.Clear();
                int NumberRow = e.RowIndex;
                if (NumberRow != -1)
                {
                    int ID = Convert.ToInt32(TablePas.Rows[NumberRow].Cells[0].Value.ToString());
                    Passenger Pasg = Passenger.Search(ID);
                    FillTreeviewPsgs(Pasg);
                }
            }
            if (showTrains.Checked)
            {
                int NumberRow = e.RowIndex;
                if (NumberRow != -1)
                {
                    int Number = Convert.ToInt32(TablePas.Rows[NumberRow].Cells[0].Value.ToString());
                    FillInfoTrain(Number);
                }
            }
        }

        

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_Click(object sender, EventArgs e)
        {
           
        }



        private void FillInfoTrain(int Number)
        {
            Train Trn = Train.Search(Number);
            List<Ticket> tkts = Trn.Tickets;
            List<RouteNode> rtns = Trn.RouteNodes;

            treeView2.Nodes[0].Text = Trn.Number.ToString();
            treeView2.Nodes[0].Nodes[0].Text = "Пассажиры";
            treeView2.Nodes[0].Nodes[1].Text = "Маршрут";
            treeView2.Nodes[0].Nodes[0].Nodes[0].Text = "Плацкарт";
            treeView2.Nodes[0].Nodes[0].Nodes[1].Text = "Купе";
            treeView2.Nodes[0].Nodes[0].Nodes[0].Nodes.Clear();
            treeView2.Nodes[0].Nodes[0].Nodes[1].Nodes.Clear();

            foreach (Ticket tkt in tkts)
            {
                if (tkt.Type == "Плацкарт")
                { treeView2.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(tkt.Passenger.ID.ToString() 
                    + " " + tkt.Passenger.LastName
                    + " " + tkt.Passenger.FirstName
                    ); }
                if (tkt.Type == "Купе")
                {
                    treeView2.Nodes[0].Nodes[0].Nodes[1].Nodes.Add(tkt.Passenger.ID.ToString()
                      + " " + tkt.Passenger.LastName
                      + " " + tkt.Passenger.FirstName
                      );
                }
            }

            treeView2.Nodes[0].Nodes[1].Nodes.Clear();
            foreach (RouteNode rtn in rtns)
            {
                treeView2.Nodes[0].Nodes[1].Nodes.Add(rtn.Station.Name.ToString());
            }

            treeView2.Visible = true;

        }
       
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 3)
            {
                int Number = Convert.ToInt32(e.Node.Text.Substring(0,2)) ;
                FillInfoTrain(Number);
            
            }
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 3)
            {
                int ID = Convert.ToInt32(e.Node.Text.Substring(0, 4));
                Passenger psg = Passenger.Search(ID);
                FillTreeviewPsgs(psg);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAllPas_Click(object sender, EventArgs e)
        {
            List<Passenger> Psgs= Passenger.Search("", "", "");
            TablePas.Rows.Clear();
            foreach (Passenger Psg in Psgs)
            {
                TablePas.Rows.Add(Psg.ID, Psg.LastName, Psg.FirstName, Psg.CountOfTickets);
            }
        }

        private void TablePas_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        public void FillTable(List<Passenger> passengers)
        {
            TablePas.Rows.Clear();
            if (TablePas.Columns.Contains("PointArr"))
            {
                TablePas.Columns.Remove("PointArr");
            }
            TablePas.Columns[0].HeaderText = "Номер паспорта";
            TablePas.Columns[1].HeaderText = "Фамилия";
            TablePas.Columns[2].HeaderText = "Имя";
            TablePas.Columns[3].HeaderText = "Билет";
            foreach (Passenger Psg in passengers)
            {
                TablePas.Rows.Add(Psg.ID, Psg.LastName, Psg.FirstName, Psg.CountOfTickets);
            }
        }

        public void FillTable(List<Train> trains)
        {
            TablePas.Rows.Clear();
            if (!TablePas.Columns.Contains("PointArr"))
            {
                TablePas.Columns.Add("PointArr", "Пункт прибытия");
            }
            TablePas.Columns[0].HeaderText = "Номер поезда";
            TablePas.Columns[1].HeaderText = "Время отправления";
            TablePas.Columns[2].HeaderText = "Пункт отправления";
            TablePas.Columns[3].HeaderText = "Время прибытия";
            TablePas.Columns[4].HeaderText = "Пункт прибытия";
            foreach (Train Trn in trains)
            {
                TablePas.Rows.Add(Trn.Number, Trn.TimeOfDeparture, Trn.PointOfDeparture, Trn.TimeOfArrival, Trn.PointOfArrival);
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassengers.Checked)
            {
                List<Passenger> Psgs = Passenger.Search("", "", "");
                FillTable(Psgs);
            }
            if (showTrains.Checked)
            {
                List<Train> Trns = Train.Search("", "");
                FillTable(Trns);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
        
    }
}
