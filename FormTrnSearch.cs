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
    public partial class TrnSearch : Form
    {
        public TrnSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();      
        }

        private void CheckChange(object sender, EventArgs e)
        {
            gBByNumber.Enabled  = byNumber.Checked;
            gBByParams.Enabled  = byParams.Checked;
        }

        private void FillResultForm(TrnResultByNumber ResultForm, Train Trn)
        {
            ResultForm.Owner                      = this;
            ResultForm.ResultNumber        .Text  = Trn.Number.ToString();
            ResultForm.ResultPlaceDepart   .Text  = Trn.TimeOfDeparture;
            ResultForm.ResultPlaceArrive   .Text  = Trn.TimeOfArrival;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (byNumber.Checked)
            {
                try
                {
                    int     Number  = Convert.ToInt32(MTBID.Text);
                    Train   Trn     = Train.Search(Number);

                    TrnResultByNumber ResultForm   = new TrnResultByNumber();
                    FillResultForm(ResultForm, Trn);
                    ResultForm.ShowDialog();
                }

                catch (KeyNotFoundException)
                {
                    FormMessage Message         = new FormMessage();
                    Message.messageLabel.Text   = "Поиск не дал результатов.";
                    Message.ShowDialog();
                }
            }
        }
    }
}
