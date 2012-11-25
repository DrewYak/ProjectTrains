﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Trains
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string FileName = openFileDialog1.FileName;
            
                Passenger.  LoadFromFile(FileName);
                Train.      AddDataFromFile(FileName);

                FormMessage Message         = new FormMessage();
                Message.messageLabel.Text   = "Загрузка данных из файла успешно завершена.";
                Message.ShowDialog();
            }
            
            catch (XmlException)
            {
                FormMessage Message         = new FormMessage();
                Message.messageLabel.Text   = "Формат выбранного файла неверный!";
                Message.ShowDialog();
            }

            catch (FileNotFoundException)
            {
                FormMessage Message         = new FormMessage();
                Message.messageLabel.Text   = "Файлы не были загружены.";
                Message.ShowDialog();
            }
        }
    }
}
