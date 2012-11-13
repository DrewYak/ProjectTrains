namespace Trains
{
    partial class SearchPassengers
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
            this.byID = new System.Windows.Forms.RadioButton();
            this.byParams = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.gBByID = new System.Windows.Forms.GroupBox();
            this.SearchID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBByParams = new System.Windows.Forms.GroupBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBByID.SuspendLayout();
            this.gBByParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // byID
            // 
            this.byID.AutoSize = true;
            this.byID.Checked = true;
            this.byID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byID.Location = new System.Drawing.Point(16, 37);
            this.byID.Name = "byID";
            this.byID.Size = new System.Drawing.Size(228, 24);
            this.byID.TabIndex = 1;
            this.byID.TabStop = true;
            this.byID.Text = "Поиск по номеру паспорта";
            this.byID.UseVisualStyleBackColor = true;
            this.byID.CheckedChanged += new System.EventHandler(this.byID_CheckedChanged);
            // 
            // byParams
            // 
            this.byParams.AutoSize = true;
            this.byParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byParams.Location = new System.Drawing.Point(15, 105);
            this.byParams.Name = "byParams";
            this.byParams.Size = new System.Drawing.Size(251, 24);
            this.byParams.TabIndex = 2;
            this.byParams.TabStop = true;
            this.byParams.Text = "Поиск по другим параметрам";
            this.byParams.UseVisualStyleBackColor = true;
            this.byParams.CheckedChanged += new System.EventHandler(this.byID_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gBByID
            // 
            this.gBByID.Controls.Add(this.SearchID);
            this.gBByID.Controls.Add(this.label1);
            this.gBByID.Enabled = this.byID.Checked;
            this.gBByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBByID.Location = new System.Drawing.Point(12, 41);
            this.gBByID.Name = "gBByID";
            this.gBByID.Size = new System.Drawing.Size(303, 61);
            this.gBByID.TabIndex = 4;
            this.gBByID.TabStop = false;
            // 
            // SearchID
            // 
            this.SearchID.BeepOnError = true;
            this.SearchID.Location = new System.Drawing.Point(146, 20);
            this.SearchID.Mask = "0000";
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(151, 26);
            this.SearchID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер паспорта";
            // 
            // gBByParams
            // 
            this.gBByParams.Controls.Add(this.maskedTextBox3);
            this.gBByParams.Controls.Add(this.maskedTextBox2);
            this.gBByParams.Controls.Add(this.maskedTextBox4);
            this.gBByParams.Controls.Add(this.label4);
            this.gBByParams.Controls.Add(this.label3);
            this.gBByParams.Controls.Add(this.label2);
            this.gBByParams.Enabled = this.byParams.Checked;
            this.gBByParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBByParams.Location = new System.Drawing.Point(12, 108);
            this.gBByParams.Name = "gBByParams";
            this.gBByParams.Size = new System.Drawing.Size(303, 120);
            this.gBByParams.TabIndex = 5;
            this.gBByParams.TabStop = false;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(146, 85);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(151, 26);
            this.maskedTextBox3.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(146, 21);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(151, 26);
            this.maskedTextBox2.TabIndex = 3;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(146, 53);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(151, 26);
            this.maskedTextBox4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тип билета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия";
            // 
            // SearchPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 268);
            this.Controls.Add(this.byParams);
            this.Controls.Add(this.byID);
            this.Controls.Add(this.gBByParams);
            this.Controls.Add(this.gBByID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SearchPassengers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchPassengers";
            this.gBByID.ResumeLayout(false);
            this.gBByID.PerformLayout();
            this.gBByParams.ResumeLayout(false);
            this.gBByParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton byID;
        private System.Windows.Forms.RadioButton byParams;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gBByID;
        private System.Windows.Forms.GroupBox gBByParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        public System.Windows.Forms.MaskedTextBox SearchID;
    }
}