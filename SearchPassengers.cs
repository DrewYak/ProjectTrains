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
    public partial class SearchPassengers : Form
    {
        public SearchPassengers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void byID_CheckedChanged(object sender, EventArgs e)
        {
            gBByID.Enabled      = byID.Checked;
            gBByParams.Enabled  = byParams.Checked;
        }

        public Form PreviousForm { get; set;}

        private void button2_Click(object sender, EventArgs e)
        {
            if (byID.Checked)
            {
                ResultSearchPasByID FormResultPasByID = new ResultSearchPasByID();
                FormResultPasByID.PreviousForm  = this;
                this.Visible                    = false;
                FormResultPasByID.ShowDialog();
            }
        }
    }
}
