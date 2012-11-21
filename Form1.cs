using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Trains
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string FileName = openFileDialog1.FileName;
            
                Passenger.AddDataFromFile(FileName);
                Train.AddDataFromFile(FileName);

                FormErrorLoad FormErr   = new FormErrorLoad();
                FormErr.label1.Text     = "Загрузка данных из файла успешно завершена.";
                FormErr.label2.Text     = "";
                FormErr.ShowDialog();
            }
            catch (XmlException)
            {
                FormErrorLoad FormErr = new FormErrorLoad();
                FormErr.ShowDialog();
            }

        }
    }
}
