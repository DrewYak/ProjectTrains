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
    public partial class FormTrains : Form
    {
        public FormTrains()
        {
            InitializeComponent();
        }

        private void ButSearchTrain_Click(object sender, EventArgs e)
        {
            TrnSearch STForm    = new TrnSearch();
            STForm.ShowDialog();
        }

        private void butData_Click(object sender, EventArgs e)
        {
            FormData FLoad  = new FormData();
            FLoad.Owner     = this;
            FLoad.ShowDialog();
        }

        private void butGraphic_Click(object sender, EventArgs e)
        {
            Form    MyForm          = new Form();
            MyForm.Height           = 200;
            MyForm.Width            = 600;
            MyForm.StartPosition    = FormStartPosition.CenterScreen;
            MyForm.Text             = "Сообщение об ошибке";
            
            Label label1            = new Label();
            label1.Text             = "Hello!";
            label1.AutoSize         = true;
            label1.Location         = new Point(5, 5);
            label1.Font             = new Font("Times New Roman", 40);
                     
            MyForm.Controls.Add(label1);
            MyForm.ShowDialog();
        }

        private void ButSearchPas_Click(object sender, EventArgs e)
        {
            PsgSearch PsgSearchForm         = new PsgSearch();
            PsgSearchForm.Owner             = this;
            PsgSearchForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddRemove AddRemove = new FormAddRemove();
            AddRemove.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditRoute EditRoute = new FormEditRoute();
            EditRoute.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEditTrains EditTrains = new FormEditTrains();
            EditTrains.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEditPassengers EditPassenger = new FormEditPassengers();
            EditPassenger.ShowDialog();
        }
    }
}