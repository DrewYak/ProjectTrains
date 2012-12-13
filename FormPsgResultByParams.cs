using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
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
            foreach (Ticket tkt in tkts)
            {
                if (tkt.Type == "Плацкарт")
                { treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Add(tkt.Train.Number.ToString()); }
                if (tkt.Type == "Купе")
                { treeView1.Nodes[0].Nodes[2].Nodes[1].Nodes.Add(tkt.Train.Number.ToString()); }
            }
        }

        private void FillTreeviewPsgs(Passenger Pasg)
        {
            FillInfoWithoutTicket(Pasg);

            List<Ticket> tkts = Pasg.Tickets;
            FillTreeviewTicket(tkts);
            
        }
        private void TablePas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Clear();
            treeView1.Nodes[0].Nodes[2].Nodes[1].Nodes.Clear();
            int NumberRow  = e.RowIndex;
            int ID         = Convert.ToInt32(TablePas.Rows[NumberRow].Cells[0].Value.ToString());
            Passenger Pasg = Passenger.Search(ID);
            FillTreeviewPsgs(Pasg);
            treeView1.Visible = true;
           
        }

        

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_Click(object sender, EventArgs e)
        {
           
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 3)
            {
                MessageBox.Show("YES");
            }
        }
    }
}
