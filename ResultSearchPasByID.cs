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

        /// <summary>
        /// Метод, заполняющий форму данными о найденном пассажире.
        /// </summary>
        /// <param name="Pas">Пассажир</param>
        private void FillResults(Passenger Pas)
        {
            ResultID.Text           = Pas.ID.ToString();
            ResultLName.Text        = Pas.LastName;
            ResultFName.Text        = Pas.FirstName;
            ResultTicketType.Text   = Pas.TypeOfTicket;
        }

        private void ResultSearchPasByID_Load(object sender, EventArgs e)
        {
            SearchPassengers main   = this.Owner as SearchPassengers; 
            int PasID               = Convert.ToInt32(main.SearchID.Text);
            Passenger ResultPas     = Passenger.Search(PasID);
            
            FillResults(ResultPas);
        }
    }
}
