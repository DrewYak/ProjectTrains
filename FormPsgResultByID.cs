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
    public partial class PsgResultByID : Form
    {
        public Form PreviousForm { get; set;}

        public PsgResultByID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Visible   = true;
            this.Close();
        }

        /// <summary>
        /// Метод, заполняющий форму данными о найденном пассажире.
        /// </summary>
        /// <param name="Pas">Пассажир.</param>
        private void FillResults(Passenger Pas)
        {
            ResultID        .Text   = Pas.ID.ToString();
            ResultLName     .Text   = Pas.LastName;
            ResultFName     .Text   = Pas.FirstName;
            ResultTicketType.Text   = Pas.Tickets[0].Type;
        }

        private void ResultSearchPasByID_Load(object sender, EventArgs e)
        {
            // Обращаемся к владельцу данной формы и указываем, что работать с ним
            // надо как с формой типа PsgSearch.
            PsgSearch   OwnerForm   = this.Owner as PsgSearch; 
            
            // Вытаскиваем данные из формы поиска пассажира, т.е. из владельца
            // данной формы.
            int         PasID       = Convert.ToInt32(OwnerForm.SearchID.Text);

            // Ищем пассажира, удовлетворяющего параметрам поиска, после чего присваиваем
            // ссылку на него ResultPas.
            Passenger   ResultPas   = Passenger.Search(PasID);
            
            // Вызываем метод, заполняющий форму данными о найденном пассажире.
            FillResults(ResultPas);
        }
    }
}
