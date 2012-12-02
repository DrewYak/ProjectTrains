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
            gBByID.Enabled          = byID.Checked;
            gBByParams.Enabled      = byParams.Checked;
            buttonSearch.Enabled    = byParams.Checked;
            if (MTextBoxID.MaskCompleted)
            {
                buttonSearch.Enabled    = true;    
            }
        }

        /// <summary>
        /// Метод, заполняющий форму данными о пассажире.
        /// </summary>
        /// <param name="Psg">Пассажир, данные о  котором вносятся в форму.</param>
        /// <param name="ResultForm">Форма, в которую вносятся данные.</param>
        private void FillResultForm(PsgResultByID ResultForm, Passenger Psg)
        {
            ResultForm.Owner                    = this;
            ResultForm.ResultID        .Text    = Psg.ID.ToString();
            ResultForm.ResultLName     .Text    = Psg.LastName;
            ResultForm.ResultFName     .Text    = Psg.FirstName;
            ResultForm.ResultTicketType.Text    = Psg.Tickets[0].Type;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (byID.Checked)
            {
                try 
                {
                    int             ID                  = Convert.ToInt32(MTextBoxID.Text);
                    Passenger       Psg                 = Passenger.Search(ID);

                    PsgResultByID   FormResultPasByID   = new PsgResultByID();
                    FillResultForm(FormResultPasByID, Psg);
                    FormResultPasByID.ShowDialog(); 
                }

                catch (KeyNotFoundException)
                {
                    FormMessage Message         = new FormMessage();
                    Message.messageLabel.Text   = "Поиск не дал результатов.";
                    Message.ShowDialog();
                }
            }

            if (byParams.Checked)
            {
                string LName                            = ParamLastName.Text;
                string FName                            = ParamFName.Text;
                string TypeOfTicket                     = ParamTypeOfTicket.Text;

                List<Passenger> ResultPas               = Passenger.Search(LName, FName, TypeOfTicket);

                if (ResultPas.Count == 0)
                {
                    FormMessage Message         = new FormMessage();
                    Message.messageLabel.Text   = "Поиск не дал результатов.";
                    Message.ShowDialog();
                }
                else
                {
                    FillResultFormAndShowIt(ResultPas);
                }
            }
        }

        private void FillResultFormAndShowIt(List<Passenger> Psgs)
        {
            PsgResultByParams FormResultPasByParams = new PsgResultByParams();
            FormResultPasByParams.Owner             = this;

            foreach (Passenger Psg in Psgs)
            {
                FormResultPasByParams.TablePas.Rows.Add(Psg.ID, Psg.LastName, Psg.FirstName, Psg.Tickets.Count);
            }

            FormResultPasByParams.ShowDialog();
        }

        private void SearchID_KeyUp(object sender, KeyEventArgs e)
        {
            buttonSearch.Enabled    = MTextBoxID.MaskCompleted;
        }
    }
}
