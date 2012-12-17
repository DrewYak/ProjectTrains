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
            this.byID = new System.Windows.Forms.RadioButton();
            this.byParams = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.gBByID = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBByParams = new System.Windows.Forms.GroupBox();
            this.ParamTypeOfTicket = new System.Windows.Forms.MaskedTextBox();
            this.ParamLastName = new System.Windows.Forms.MaskedTextBox();
            this.ParamFName = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gBByID.SuspendLayout();
            this.gBByParams.SuspendLayout();
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
            // byID
            // 
            this.byID.AutoSize = true;
            this.byID.Checked = true;
            this.byID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byID.Location = new System.Drawing.Point(16, 37);
            this.byID.Name = "byID";
            this.byID.Size = new System.Drawing.Size(141, 24);
            this.byID.TabIndex = 1;
            this.byID.TabStop = true;
            this.byID.Text = "Поиск поездов";
            this.byID.UseVisualStyleBackColor = true;
            this.byID.CheckedChanged += new System.EventHandler(this.byID_CheckedChanged);
            // 
            // byParams
            // 
            this.byParams.AutoSize = true;
            this.byParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byParams.Location = new System.Drawing.Point(15, 138);
            this.byParams.Name = "byParams";
            this.byParams.Size = new System.Drawing.Size(167, 24);
            this.byParams.TabIndex = 0;
            this.byParams.Text = "Поиск пассажиров";
            this.byParams.UseVisualStyleBackColor = true;
            this.byParams.CheckedChanged += new System.EventHandler(this.byID_CheckedChanged);
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
            // gBByID
            // 
            this.gBByID.Controls.Add(this.label5);
            this.gBByID.Controls.Add(this.textBox2);
            this.gBByID.Controls.Add(this.textBox1);
            this.gBByID.Controls.Add(this.label1);
            this.gBByID.Enabled = this.byID.Checked;
            this.gBByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBByID.Location = new System.Drawing.Point(12, 41);
            this.gBByID.Name = "gBByID";
            this.gBByID.Size = new System.Drawing.Size(334, 94);
            this.gBByID.TabIndex = 4;
            this.gBByID.TabStop = false;
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
            // gBByParams
            // 
            this.gBByParams.Controls.Add(this.ParamTypeOfTicket);
            this.gBByParams.Controls.Add(this.ParamLastName);
            this.gBByParams.Controls.Add(this.ParamFName);
            this.gBByParams.Controls.Add(this.label4);
            this.gBByParams.Controls.Add(this.label3);
            this.gBByParams.Controls.Add(this.label2);
            this.gBByParams.Enabled = this.byParams.Checked;
            this.gBByParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBByParams.Location = new System.Drawing.Point(12, 141);
            this.gBByParams.Name = "gBByParams";
            this.gBByParams.Size = new System.Drawing.Size(334, 119);
            this.gBByParams.TabIndex = 5;
            this.gBByParams.TabStop = false;
            // 
            // ParamTypeOfTicket
            // 
            this.ParamTypeOfTicket.Location = new System.Drawing.Point(170, 85);
            this.ParamTypeOfTicket.Name = "ParamTypeOfTicket";
            this.ParamTypeOfTicket.Size = new System.Drawing.Size(151, 26);
            this.ParamTypeOfTicket.TabIndex = 4;
            // 
            // ParamLastName
            // 
            this.ParamLastName.Location = new System.Drawing.Point(170, 25);
            this.ParamLastName.Name = "ParamLastName";
            this.ParamLastName.Size = new System.Drawing.Size(151, 26);
            this.ParamLastName.TabIndex = 2;
            // 
            // ParamFName
            // 
            this.ParamFName.Location = new System.Drawing.Point(170, 55);
            this.ParamFName.Name = "ParamFName";
            this.ParamFName.Size = new System.Drawing.Size(151, 26);
            this.ParamFName.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 26);
            this.textBox2.TabIndex = 3;
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
            // PsgSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 295);
            this.Controls.Add(this.byParams);
            this.Controls.Add(this.byID);
            this.Controls.Add(this.gBByParams);
            this.Controls.Add(this.gBByID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBack);
            this.Name = "PsgSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск пассажира (-ов)";
            this.gBByID.ResumeLayout(false);
            this.gBByID.PerformLayout();
            this.gBByParams.ResumeLayout(false);
            this.gBByParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RadioButton byID;
        private System.Windows.Forms.RadioButton byParams;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox gBByID;
        private System.Windows.Forms.GroupBox gBByParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ParamTypeOfTicket;
        private System.Windows.Forms.MaskedTextBox ParamLastName;
        private System.Windows.Forms.MaskedTextBox ParamFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}