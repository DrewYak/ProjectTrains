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
    public partial class ResultSearchPasByID : Form
    {
        public Form PreviousForm { get; set;}

        public ResultSearchPasByID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Visible   = true;
            this.Close();
        }
    }
}
