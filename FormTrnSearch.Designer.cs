namespace Trains
{
    partial class TrnSearch
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
            this.gBByNumber = new System.Windows.Forms.GroupBox();
            this.MTBID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.byNumber = new System.Windows.Forms.RadioButton();
            this.gBByParams = new System.Windows.Forms.GroupBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.byParams = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.gBByNumber.SuspendLayout();
            this.gBByParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gBByNumber
            // 
            this.gBByNumber.Controls.Add(this.MTBID);
            this.gBByNumber.Controls.Add(this.label1);
            this.gBByNumber.Enabled = this.byNumber.Checked;
            this.gBByNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBByNumber.Location = new System.Drawing.Point(12, 41);
            this.gBByNumber.Name = "gBByNumber";
            this.gBByNumber.Size = new System.Drawing.Size(431, 63);
            this.gBByNumber.TabIndex = 4;
            this.gBByNumber.TabStop = false;
            // 
            // MTBID
            // 
            this.MTBID.BeepOnError = true;
            this.MTBID.Location = new System.Drawing.Point(181, 23);
            this.MTBID.Mask = "00";
            this.MTBID.Name = "MTBID";
            this.MTBID.Size = new System.Drawing.Size(244, 26);
            this.MTBID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер поезда";
            // 
            // byNumber
            // 
            this.byNumber.AutoSize = true;
            this.byNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byNumber.Location = new System.Drawing.Point(16, 39);
            this.byNumber.Name = "byNumber";
            this.byNumber.Size = new System.Drawing.Size(212, 24);
            this.byNumber.TabIndex = 0;
            this.byNumber.TabStop = true;
            this.byNumber.Text = "Поиск поезда по номеру";
            this.byNumber.UseVisualStyleBackColor = true;
            this.byNumber.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // gBByParams
            // 
            this.gBByParams.Controls.Add(this.maskedTextBox3);
            this.gBByParams.Controls.Add(this.maskedTextBox2);
            this.gBByParams.Controls.Add(this.label3);
            this.gBByParams.Controls.Add(this.label2);
            this.gBByParams.Enabled = this.byParams.Checked;
            this.gBByParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBByParams.Location = new System.Drawing.Point(12, 110);
            this.gBByParams.Name = "gBByParams";
            this.gBByParams.Size = new System.Drawing.Size(431, 99);
            this.gBByParams.TabIndex = 0;
            this.gBByParams.TabStop = false;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BeepOnError = true;
            this.maskedTextBox3.Location = new System.Drawing.Point(181, 56);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(244, 26);
            this.maskedTextBox3.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BeepOnError = true;
            this.maskedTextBox2.Location = new System.Drawing.Point(181, 24);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(244, 26);
            this.maskedTextBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пункт назначения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пункт отправления";
            // 
            // byParams
            // 
            this.byParams.AutoSize = true;
            this.byParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byParams.Location = new System.Drawing.Point(16, 108);
            this.byParams.Name = "byParams";
            this.byParams.Size = new System.Drawing.Size(252, 24);
            this.byParams.TabIndex = 1;
            this.byParams.TabStop = true;
            this.byParams.Text = "Поиск поезда по параметрам";
            this.byParams.UseVisualStyleBackColor = true;
            this.byParams.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TrnSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 246);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.byParams);
            this.Controls.Add(this.gBByParams);
            this.Controls.Add(this.byNumber);
            this.Controls.Add(this.gBByNumber);
            this.Controls.Add(this.button1);
            this.Name = "TrnSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск поезда (-ов)";
            this.Load += new System.EventHandler(this.TrnSearch_Load);
            this.gBByNumber.ResumeLayout(false);
            this.gBByNumber.PerformLayout();
            this.gBByParams.ResumeLayout(false);
            this.gBByParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gBByNumber;
        private System.Windows.Forms.GroupBox gBByParams;
        private System.Windows.Forms.RadioButton byNumber;
        private System.Windows.Forms.RadioButton byParams;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox MTBID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}