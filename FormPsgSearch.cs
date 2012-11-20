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
    public partial class PsgSearch : Form
    {
        public PsgSearch()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void byID_CheckedChanged(object sender, EventArgs e)
        {
            gBByID.Enabled      = byID.Checked;
            gBByParams.Enabled  = byParams.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (byID.Checked)
            {
                PsgResultByID FormResultPasByID = new PsgResultByID();
                FormResultPasByID.Owner         = this;
                this.Visible                    = false;
                FormResultPasByID.ShowDialog(); 
            }
        }

        private void SearchID_KeyUp(object sender, KeyEventArgs e)
        {
            buttonSearch.Enabled    = SearchID.MaskCompleted;
        }
    }
}
