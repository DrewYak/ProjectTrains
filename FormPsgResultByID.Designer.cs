namespace Trains
{
    partial class PsgResultByID
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultID = new System.Windows.Forms.Label();
            this.ResultLName = new System.Windows.Forms.Label();
            this.ResultFName = new System.Windows.Forms.Label();
            this.ResultTicketType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(106, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(51, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тип билета";
            // 
            // ResultID
            // 
            this.ResultID.AutoSize = true;
            this.ResultID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultID.Location = new System.Drawing.Point(152, 59);
            this.ResultID.Name = "ResultID";
            this.ResultID.Size = new System.Drawing.Size(51, 20);
            this.ResultID.TabIndex = 5;
            this.ResultID.Text = "label5";
            // 
            // ResultLName
            // 
            this.ResultLName.AutoSize = true;
            this.ResultLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLName.Location = new System.Drawing.Point(152, 79);
            this.ResultLName.Name = "ResultLName";
            this.ResultLName.Size = new System.Drawing.Size(51, 20);
            this.ResultLName.TabIndex = 6;
            this.ResultLName.Text = "label6";
            // 
            // ResultFName
            // 
            this.ResultFName.AutoSize = true;
            this.ResultFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultFName.Location = new System.Drawing.Point(152, 99);
            this.ResultFName.Name = "ResultFName";
            this.ResultFName.Size = new System.Drawing.Size(51, 20);
            this.ResultFName.TabIndex = 7;
            this.ResultFName.Text = "label7";
            // 
            // ResultTicketType
            // 
            this.ResultTicketType.AutoSize = true;
            this.ResultTicketType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTicketType.Location = new System.Drawing.Point(152, 119);
            this.ResultTicketType.Name = "ResultTicketType";
            this.ResultTicketType.Size = new System.Drawing.Size(51, 20);
            this.ResultTicketType.TabIndex = 8;
            this.ResultTicketType.Text = "label8";
            // 
            // PsgResultByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 152);
            this.Controls.Add(this.ResultTicketType);
            this.Controls.Add(this.ResultFName);
            this.Controls.Add(this.ResultLName);
            this.Controls.Add(this.ResultID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "PsgResultByID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты поиска пассажира по номеру паспорта";
            this.Load += new System.EventHandler(this.ResultSearchPasByID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ResultID;
        private System.Windows.Forms.Label ResultLName;
        private System.Windows.Forms.Label ResultFName;
        private System.Windows.Forms.Label ResultTicketType;
    }
}