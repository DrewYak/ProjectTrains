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
            if (searchTrains.Checked)
            {
                List<Train> trains = Train.Search(pointArrive.Text, pointDeparture.Text);

                if (trains.Count == 0)
                {
                    FormMessage Message         = new FormMessage();
                    Message.messageLabel.Text   = "Поиск не дал результатов.";
                    Message.ShowDialog();
                }
                else
                {
                    PsgResultByParams f     = new PsgResultByParams();
                    f.showTrains.Checked    = true;
                    f.FillTable(trains);
                    f.ShowDialog();                
                }
            }

            if (searchPassengers.Checked)
            {
                List<Passenger> passengers  = Passenger.Search(lastName.Text, firstName.Text, ticketType.Text);

                if (passengers.Count == 0)
                {
                    FormMessage Message         = new FormMessage();
                    Message.messageLabel.Text   = "Поиск не дал результатов.";
                    Message.ShowDialog();
                }
                else
                {
                    PsgResultByParams f         = new PsgResultByParams();
                    f.showPassengers.Checked    = true;
                    f.FillTable(passengers);
                    f.ShowDialog();
                }
            }
        }

        private void FillResultFormAndShowIt(List<Passenger> Psgs)
        {
            PsgResultByParams FormResultPasByParams = new PsgResultByParams();
            FormResultPasByParams.Owner             = this;

            foreach (Passenger Psg in Psgs)
            {
                FormResultPasByParams.TablePas.Rows.Add(Psg.ID, Psg.LastName, Psg.FirstName, Psg.CountOfTickets);
            }

            FormResultPasByParams.ShowDialog();
        }

        private void SearchID_KeyUp(object sender, KeyEventArgs e)
        {
           // buttonSearch.Enabled    = MTextBoxID.MaskCompleted;
        }

        private void searchTrains_CheckedChanged(object sender, EventArgs e)
        {
            gbSearchTrains.Enabled      = searchTrains.Checked;
            gBSearchPassengers.Enabled  = searchPassengers.Checked;
        }
    }
}
