namespace Trains
{
    partial class FormEditTrains
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wayStation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timeArrWayS = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.timeDepWays = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.initialStation = new System.Windows.Forms.ComboBox();
            this.terminalStation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeArrInit = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timeArrTerm = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timeDepInit = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timeDepTerm = new System.Windows.Forms.MaskedTextBox();
            this.numberTrain = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.add, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 558);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheck,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(606, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 490);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCheck.HeaderText = "Выбор";
            this.ColumnCheck.Name = "ColumnCheck";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Номер поезда";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Пункт отправления";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Пункт назначения";
            this.Column3.Name = "Column3";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(606, 508);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(548, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.Enabled = false;
            this.add.Location = new System.Drawing.Point(6, 508);
            this.add.Margin = new System.Windows.Forms.Padding(6);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(588, 44);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить/Изменить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.numberTrain);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 490);
            this.panel1.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(395, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 42;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.wayStation);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.timeArrWayS);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.timeDepWays);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(6, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 101);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование уже добавленного поезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Промежут. станция";
            // 
            // wayStation
            // 
            this.wayStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wayStation.FormattingEnabled = true;
            this.wayStation.Location = new System.Drawing.Point(12, 55);
            this.wayStation.Margin = new System.Windows.Forms.Padding(6);
            this.wayStation.Name = "wayStation";
            this.wayStation.Size = new System.Drawing.Size(175, 32);
            this.wayStation.TabIndex = 31;
            this.wayStation.TextChanged += new System.EventHandler(this.timeArrWayS_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 24);
            this.label10.TabIndex = 40;
            this.label10.Text = "Время отправления";
            // 
            // timeArrWayS
            // 
            this.timeArrWayS.Location = new System.Drawing.Point(199, 55);
            this.timeArrWayS.Margin = new System.Windows.Forms.Padding(6);
            this.timeArrWayS.Mask = "00/00/0000 90:00";
            this.timeArrWayS.Name = "timeArrWayS";
            this.timeArrWayS.Size = new System.Drawing.Size(154, 29);
            this.timeArrWayS.TabIndex = 33;
            this.timeArrWayS.ValidatingType = typeof(System.DateTime);
            this.timeArrWayS.TextChanged += new System.EventHandler(this.timeArrWayS_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Время прибытия";
            // 
            // timeDepWays
            // 
            this.timeDepWays.Location = new System.Drawing.Point(362, 55);
            this.timeDepWays.Margin = new System.Windows.Forms.Padding(6);
            this.timeDepWays.Mask = "00/00/0000 90:00";
            this.timeDepWays.Name = "timeDepWays";
            this.timeDepWays.Size = new System.Drawing.Size(154, 29);
            this.timeDepWays.TabIndex = 34;
            this.timeDepWays.ValidatingType = typeof(System.DateTime);
            this.timeDepWays.TextChanged += new System.EventHandler(this.timeArrWayS_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.initialStation);
            this.groupBox1.Controls.Add(this.terminalStation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.timeArrInit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.timeArrTerm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.timeDepInit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.timeDepTerm);
            this.groupBox1.Location = new System.Drawing.Point(6, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 183);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление нового поезда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Начальная станция";
            // 
            // initialStation
            // 
            this.initialStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.initialStation.FormattingEnabled = true;
            this.initialStation.Location = new System.Drawing.Point(9, 55);
            this.initialStation.Margin = new System.Windows.Forms.Padding(6);
            this.initialStation.Name = "initialStation";
            this.initialStation.Size = new System.Drawing.Size(175, 32);
            this.initialStation.TabIndex = 18;
            this.initialStation.TextChanged += new System.EventHandler(this.timeArrInit_TextChanged);
            // 
            // terminalStation
            // 
            this.terminalStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.terminalStation.FormattingEnabled = true;
            this.terminalStation.Location = new System.Drawing.Point(9, 126);
            this.terminalStation.Margin = new System.Windows.Forms.Padding(6);
            this.terminalStation.Name = "terminalStation";
            this.terminalStation.Size = new System.Drawing.Size(175, 32);
            this.terminalStation.TabIndex = 23;
            this.terminalStation.TextChanged += new System.EventHandler(this.timeArrInit_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Конечная станция";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Время отправления";
            // 
            // timeArrInit
            // 
            this.timeArrInit.Location = new System.Drawing.Point(196, 55);
            this.timeArrInit.Margin = new System.Windows.Forms.Padding(6);
            this.timeArrInit.Mask = "00/00/0000 90:00";
            this.timeArrInit.Name = "timeArrInit";
            this.timeArrInit.Size = new System.Drawing.Size(154, 29);
            this.timeArrInit.TabIndex = 26;
            this.timeArrInit.ValidatingType = typeof(System.DateTime);
            this.timeArrInit.TextChanged += new System.EventHandler(this.timeArrInit_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Время прибытия";
            // 
            // timeArrTerm
            // 
            this.timeArrTerm.Location = new System.Drawing.Point(196, 126);
            this.timeArrTerm.Margin = new System.Windows.Forms.Padding(6);
            this.timeArrTerm.Mask = "00/00/0000 90:00";
            this.timeArrTerm.Name = "timeArrTerm";
            this.timeArrTerm.Size = new System.Drawing.Size(154, 29);
            this.timeArrTerm.TabIndex = 27;
            this.timeArrTerm.ValidatingType = typeof(System.DateTime);
            this.timeArrTerm.TextChanged += new System.EventHandler(this.timeArrInit_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Время отправления";
            // 
            // timeDepInit
            // 
            this.timeDepInit.Location = new System.Drawing.Point(362, 55);
            this.timeDepInit.Margin = new System.Windows.Forms.Padding(6);
            this.timeDepInit.Mask = "00/00/0000 90:00";
            this.timeDepInit.Name = "timeDepInit";
            this.timeDepInit.Size = new System.Drawing.Size(154, 29);
            this.timeDepInit.TabIndex = 28;
            this.timeDepInit.ValidatingType = typeof(System.DateTime);
            this.timeDepInit.TextChanged += new System.EventHandler(this.timeArrInit_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Время прибытия";
            // 
            // timeDepTerm
            // 
            this.timeDepTerm.Location = new System.Drawing.Point(362, 126);
            this.timeDepTerm.Margin = new System.Windows.Forms.Padding(6);
            this.timeDepTerm.Mask = "00/00/0000 90:00";
            this.timeDepTerm.Name = "timeDepTerm";
            this.timeDepTerm.Size = new System.Drawing.Size(154, 29);
            this.timeDepTerm.TabIndex = 29;
            this.timeDepTerm.ValidatingType = typeof(System.DateTime);
            this.timeDepTerm.TextChanged += new System.EventHandler(this.timeArrInit_TextChanged);
            // 
            // numberTrain
            // 
            this.numberTrain.Location = new System.Drawing.Point(202, 78);
            this.numberTrain.Margin = new System.Windows.Forms.Padding(6);
            this.numberTrain.Mask = "00";
            this.numberTrain.Name = "numberTrain";
            this.numberTrain.Size = new System.Drawing.Size(154, 29);
            this.numberTrain.TabIndex = 30;
            this.numberTrain.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер поезда";
            // 
            // FormEditTrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEditTrains";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование поездов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormEditTrains_Activated);
            this.Load += new System.EventHandler(this.FormEditTrains_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox terminalStation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox initialStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox timeArrTerm;
        private System.Windows.Forms.MaskedTextBox timeArrInit;
        private System.Windows.Forms.MaskedTextBox timeDepTerm;
        private System.Windows.Forms.MaskedTextBox timeDepInit;
        private System.Windows.Forms.MaskedTextBox numberTrain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox wayStation;
        private System.Windows.Forms.MaskedTextBox timeDepWays;
        private System.Windows.Forms.MaskedTextBox timeArrWayS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}