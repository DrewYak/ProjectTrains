namespace Trains
{
    partial class PsgSearch
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.searchTrains = new System.Windows.Forms.RadioButton();
            this.searchPassengers = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.gbSearchTrains = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pointDeparture = new System.Windows.Forms.TextBox();
            this.pointArrive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBSearchPassengers = new System.Windows.Forms.GroupBox();
            this.ticketType = new System.Windows.Forms.MaskedTextBox();
            this.lastName = new System.Windows.Forms.MaskedTextBox();
            this.firstName = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSearchTrains.SuspendLayout();
            this.gBSearchPassengers.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // searchTrains
            // 
            this.searchTrains.AutoSize = true;
            this.searchTrains.Checked = true;
            this.searchTrains.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTrains.Location = new System.Drawing.Point(16, 37);
            this.searchTrains.Name = "searchTrains";
            this.searchTrains.Size = new System.Drawing.Size(141, 24);
            this.searchTrains.TabIndex = 1;
            this.searchTrains.TabStop = true;
            this.searchTrains.Text = "Поиск поездов";
            this.searchTrains.UseVisualStyleBackColor = true;
            this.searchTrains.CheckedChanged += new System.EventHandler(this.searchTrains_CheckedChanged);
            // 
            // searchPassengers
            // 
            this.searchPassengers.AutoSize = true;
            this.searchPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchPassengers.Location = new System.Drawing.Point(15, 138);
            this.searchPassengers.Name = "searchPassengers";
            this.searchPassengers.Size = new System.Drawing.Size(167, 24);
            this.searchPassengers.TabIndex = 0;
            this.searchPassengers.Text = "Поиск пассажиров";
            this.searchPassengers.UseVisualStyleBackColor = true;
            this.searchPassengers.CheckedChanged += new System.EventHandler(this.searchTrains_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(271, 266);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbSearchTrains
            // 
            this.gbSearchTrains.Controls.Add(this.label5);
            this.gbSearchTrains.Controls.Add(this.pointDeparture);
            this.gbSearchTrains.Controls.Add(this.pointArrive);
            this.gbSearchTrains.Controls.Add(this.label1);
            this.gbSearchTrains.Enabled = this.searchTrains.Checked;
            this.gbSearchTrains.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSearchTrains.Location = new System.Drawing.Point(12, 41);
            this.gbSearchTrains.Name = "gbSearchTrains";
            this.gbSearchTrains.Size = new System.Drawing.Size(334, 94);
            this.gbSearchTrains.TabIndex = 4;
            this.gbSearchTrains.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пункт прибытия";
            // 
            // pointDeparture
            // 
            this.pointDeparture.Location = new System.Drawing.Point(170, 55);
            this.pointDeparture.Name = "pointDeparture";
            this.pointDeparture.Size = new System.Drawing.Size(151, 26);
            this.pointDeparture.TabIndex = 3;
            // 
            // pointArrive
            // 
            this.pointArrive.Location = new System.Drawing.Point(170, 23);
            this.pointArrive.Name = "pointArrive";
            this.pointArrive.Size = new System.Drawing.Size(151, 26);
            this.pointArrive.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пункт отправления";
            // 
            // gBSearchPassengers
            // 
            this.gBSearchPassengers.Controls.Add(this.ticketType);
            this.gBSearchPassengers.Controls.Add(this.lastName);
            this.gBSearchPassengers.Controls.Add(this.firstName);
            this.gBSearchPassengers.Controls.Add(this.label4);
            this.gBSearchPassengers.Controls.Add(this.label3);
            this.gBSearchPassengers.Controls.Add(this.label2);
            this.gBSearchPassengers.Enabled = this.searchPassengers.Checked;
            this.gBSearchPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBSearchPassengers.Location = new System.Drawing.Point(12, 141);
            this.gBSearchPassengers.Name = "gBSearchPassengers";
            this.gBSearchPassengers.Size = new System.Drawing.Size(334, 119);
            this.gBSearchPassengers.TabIndex = 5;
            this.gBSearchPassengers.TabStop = false;
            // 
            // ticketType
            // 
            this.ticketType.Location = new System.Drawing.Point(170, 85);
            this.ticketType.Name = "ticketType";
            this.ticketType.Size = new System.Drawing.Size(151, 26);
            this.ticketType.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(170, 25);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(151, 26);
            this.lastName.TabIndex = 2;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(170, 55);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(151, 26);
            this.firstName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тип билета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия";
            // 
            // PsgSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 295);
            this.Controls.Add(this.searchPassengers);
            this.Controls.Add(this.searchTrains);
            this.Controls.Add(this.gBSearchPassengers);
            this.Controls.Add(this.gbSearchTrains);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBack);
            this.Name = "PsgSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.gbSearchTrains.ResumeLayout(false);
            this.gbSearchTrains.PerformLayout();
            this.gBSearchPassengers.ResumeLayout(false);
            this.gBSearchPassengers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RadioButton searchTrains;
        private System.Windows.Forms.RadioButton searchPassengers;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox gbSearchTrains;
        private System.Windows.Forms.GroupBox gBSearchPassengers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ticketType;
        private System.Windows.Forms.MaskedTextBox lastName;
        private System.Windows.Forms.MaskedTextBox firstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pointDeparture;
        private System.Windows.Forms.TextBox pointArrive;
    }
}