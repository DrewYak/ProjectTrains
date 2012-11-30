namespace Trains
{
    partial class TrnResultByNumber
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NNumber = new System.Windows.Forms.Label();
            this.NTimeOfDeparture = new System.Windows.Forms.Label();
            this.NTimeOfArrival = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.PointOfDeparture = new System.Windows.Forms.Label();
            this.TimeOfDeparture = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NPointOfDeparture = new System.Windows.Forms.Label();
            this.NPointOfArrival = new System.Windows.Forms.Label();
            this.PointOfArrival = new System.Windows.Forms.Label();
            this.TimeOfArrival = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NNumber
            // 
            this.NNumber.AutoSize = true;
            this.NNumber.Location = new System.Drawing.Point(13, 50);
            this.NNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NNumber.Name = "NNumber";
            this.NNumber.Size = new System.Drawing.Size(118, 20);
            this.NNumber.TabIndex = 0;
            this.NNumber.Text = "Номер поезда";
            // 
            // NTimeOfDeparture
            // 
            this.NTimeOfDeparture.AutoSize = true;
            this.NTimeOfDeparture.Location = new System.Drawing.Point(13, 90);
            this.NTimeOfDeparture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NTimeOfDeparture.Name = "NTimeOfDeparture";
            this.NTimeOfDeparture.Size = new System.Drawing.Size(162, 20);
            this.NTimeOfDeparture.TabIndex = 1;
            this.NTimeOfDeparture.Text = "Время отправления";
            // 
            // NTimeOfArrival
            // 
            this.NTimeOfArrival.AutoSize = true;
            this.NTimeOfArrival.Location = new System.Drawing.Point(13, 130);
            this.NTimeOfArrival.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NTimeOfArrival.Name = "NTimeOfArrival";
            this.NTimeOfArrival.Size = new System.Drawing.Size(136, 20);
            this.NTimeOfArrival.TabIndex = 2;
            this.NTimeOfArrival.Text = "Время прибытия";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(203, 50);
            this.Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(65, 20);
            this.Number.TabIndex = 3;
            this.Number.Text = "Number";
            // 
            // PointOfDeparture
            // 
            this.PointOfDeparture.AutoSize = true;
            this.PointOfDeparture.Location = new System.Drawing.Point(203, 70);
            this.PointOfDeparture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PointOfDeparture.Name = "PointOfDeparture";
            this.PointOfDeparture.Size = new System.Drawing.Size(134, 20);
            this.PointOfDeparture.TabIndex = 4;
            this.PointOfDeparture.Text = "PointOfDeparture";
            // 
            // TimeOfDeparture
            // 
            this.TimeOfDeparture.AutoSize = true;
            this.TimeOfDeparture.Location = new System.Drawing.Point(203, 90);
            this.TimeOfDeparture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeOfDeparture.Name = "TimeOfDeparture";
            this.TimeOfDeparture.Size = new System.Drawing.Size(132, 20);
            this.TimeOfDeparture.TabIndex = 5;
            this.TimeOfDeparture.Text = "TimeOfDeparture";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NPointOfDeparture
            // 
            this.NPointOfDeparture.AutoSize = true;
            this.NPointOfDeparture.Location = new System.Drawing.Point(13, 70);
            this.NPointOfDeparture.Name = "NPointOfDeparture";
            this.NPointOfDeparture.Size = new System.Drawing.Size(162, 20);
            this.NPointOfDeparture.TabIndex = 7;
            this.NPointOfDeparture.Text = "Пункт  отправления";
            // 
            // NPointOfArrival
            // 
            this.NPointOfArrival.AutoSize = true;
            this.NPointOfArrival.Location = new System.Drawing.Point(13, 110);
            this.NPointOfArrival.Name = "NPointOfArrival";
            this.NPointOfArrival.Size = new System.Drawing.Size(136, 20);
            this.NPointOfArrival.TabIndex = 8;
            this.NPointOfArrival.Text = "Пункт  прибытия";
            // 
            // PointOfArrival
            // 
            this.PointOfArrival.AutoSize = true;
            this.PointOfArrival.Location = new System.Drawing.Point(203, 110);
            this.PointOfArrival.Name = "PointOfArrival";
            this.PointOfArrival.Size = new System.Drawing.Size(105, 20);
            this.PointOfArrival.TabIndex = 9;
            this.PointOfArrival.Text = "PointOfArrival";
            // 
            // TimeOfArrival
            // 
            this.TimeOfArrival.AutoSize = true;
            this.TimeOfArrival.Location = new System.Drawing.Point(203, 130);
            this.TimeOfArrival.Name = "TimeOfArrival";
            this.TimeOfArrival.Size = new System.Drawing.Size(103, 20);
            this.TimeOfArrival.TabIndex = 10;
            this.TimeOfArrival.Text = "TimeOfArrival";
            // 
            // TrnResultByNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 200);
            this.Controls.Add(this.TimeOfArrival);
            this.Controls.Add(this.PointOfArrival);
            this.Controls.Add(this.NPointOfArrival);
            this.Controls.Add(this.NPointOfDeparture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeOfDeparture);
            this.Controls.Add(this.PointOfDeparture);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.NTimeOfArrival);
            this.Controls.Add(this.NTimeOfDeparture);
            this.Controls.Add(this.NNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrnResultByNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты поиска поезда по его номеру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NNumber;
        private System.Windows.Forms.Label NTimeOfDeparture;
        private System.Windows.Forms.Label NTimeOfArrival;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Number;
        public System.Windows.Forms.Label PointOfDeparture;
        public System.Windows.Forms.Label TimeOfDeparture;
        private System.Windows.Forms.Label NPointOfDeparture;
        private System.Windows.Forms.Label NPointOfArrival;
        public System.Windows.Forms.Label PointOfArrival;
        public System.Windows.Forms.Label TimeOfArrival;
    }
}