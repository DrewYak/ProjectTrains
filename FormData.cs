using System;
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
            
                Data.LoadFromFile(FileName);

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;
            try
            {
                Data.SaveToFile(fileName);
            }
            catch (ArgumentException)
            {
                FormMessage f       = new FormMessage();
                f.messageLabel.Text = "Файлы не были сохранены! Введите имя файла для сохранения!";
                f.ShowDialog();
            }
        }

        private void buttonUnload_Click(object sender, EventArgs e)
        {
            Data.Unload();
            FormMessage f       = new FormMessage();
            f.messageLabel.Text = "Данные успешно выгружены из программы.";
            f.ShowDialog();
        }

        private void FormData_Activated(object sender, EventArgs e)
        {
            this.buttonLoad.    Enabled = !Data.DataLoad;
            this.buttonUnload.  Enabled =  Data.DataLoad;
            this.buttonSave.    Enabled =  Data.DataLoad;
        }
    }
}
