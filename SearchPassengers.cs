﻿using System;
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

        public Form PreviousForm { get; set;}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
