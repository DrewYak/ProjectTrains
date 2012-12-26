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
    public partial class FormEditPassengers : Form
    {
        public FormEditPassengers()
        {
            InitializeComponent();
        }

        private void FillGridView(List<Passenger> ResultPas)
        {
            this.dataGridView1.Rows.Clear();
            foreach (Passenger Psg in ResultPas)
            {
                this.dataGridView1.Rows.Add(false, Psg.ID, Psg.LastName, Psg.FirstName, Psg.CountOfTickets);
            }

        }

        private void FormEditPassengers_Activated(object sender, EventArgs e)
        {
            List<Passenger> ResultPas = Passenger.Search("", "", "");
            FillGridView(ResultPas);
        }

        private void FormEditPassengers_Load(object sender, EventArgs e)
        {
            List<Train> Trns = Train.Search("","");
            foreach(Train Trn in Trns)
            {
                comboBox1.Items.Add(Trn.Number);
            }
            comboBox2.Items.Add("Плацкарт");
            comboBox2.Items.Add("Купе");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> delPsgs = new List<int>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    int del = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    delPsgs.Add(del);
                }
            }
            foreach (int numPsg in delPsgs)
            {
                Passenger delete = Passenger.Search(numPsg);
                List.RemoveFromAllPassengers(delete);
            }
            FormEditPassengers_Activated(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(this.textBox1.Text);
            Passenger entPsg = Passenger.Search(Number);
            Train Trn = Train.Search(Convert.ToInt32(comboBox1.Text));
            if (entPsg == null)
            {
                string LName = this.textBox2.Text;
                string FName = this.textBox3.Text;
                Passenger Psg = new Passenger(Number, FName, LName);
                Ticket Tck = new Ticket(Trn, comboBox2.Text, Psg);
            }
            else
            {
                Ticket Tck = new Ticket(Trn, comboBox2.Text, entPsg);  
            }
            FormEditPassengers_Activated(sender, e);
            textBox1_TextChanged(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1_TextChanged(sender, e);
            if (this.textBox1.Text != "")
            {
                int Number = Convert.ToInt32(this.textBox1.Text);
                Passenger entPsg = Passenger.Search(Number);
                if (entPsg != null)
                {
                    string LName = entPsg.LastName;
                    string FName = entPsg.FirstName;
                    this.textBox2.Text = LName;
                    this.textBox3.Text = FName;
                    this.textBox2.Enabled = false;
                    this.textBox3.Enabled = false;
                    this.button2.Text = "Изменить";

                }
                else
                {
                    this.textBox2.Enabled = true;
                    this.textBox3.Enabled = true;
                    this.button2.Text = "Добавить";

                    this.textBox2.Clear();
                    this.textBox3.Clear();
                }
            }


        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.MaskCompleted) &&
                    (textBox2.Text != "") &&
                    (textBox3.Text != "") &&
                    (comboBox1.Text != "") &&
                    (comboBox2.Text != "")
                )
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}
