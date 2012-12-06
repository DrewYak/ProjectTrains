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
            ResultForm.Owner                    = this;
            ResultForm.Number           .Text   = Trn.Number.ToString();
            ResultForm.PointOfDeparture .Text   = Trn.PointOfDeparture;
            ResultForm.TimeOfDeparture  .Text   = Trn.TimeOfDeparture;
            ResultForm.PointOfArrival   .Text   = Trn.PointOfArrival;
            ResultForm.TimeOfArrival    .Text   = Trn.TimeOfArrival;
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

            if (byParams.Checked)
            {
                string PointOfDep   = maskedTextBox2.Text;
                string PointOfArr   = maskedTextBox3.Text;
                List<Train> Trns    = Train.Search(PointOfDep, PointOfArr);

                if (Trns.Count == 0)
                {
                    FormMessage Message         = new FormMessage();
                    Message.messageLabel.Text   = "Поиск не дал результатов.";
                    Message.ShowDialog();
                }
                else
                {
                    FormResultTrnByParams TrnByPar  = new FormResultTrnByParams();
                    foreach(Train Trn in Trns)
                    {
                        int     Number      = Trn.Number;
                        string  TimeDep     = Trn.TimeOfDeparture;
                        string  PointDep    = Trn.PointOfDeparture;
                        string  TimeArr     = Trn.TimeOfArrival;
                        string  PointArr    = Trn.PointOfArrival;
                        TrnByPar.TableTrns.Rows.Add(Number, TimeDep, PointDep, TimeArr, PointArr);
                    }
                    TrnByPar.ShowDialog();
                }
            }
        }
    }
}
