namespace Trains
{
    partial class FormVisual
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
            this.components = new System.ComponentModel.Container();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sizeIncSt = new System.Windows.Forms.Button();
            this.sizeDecSt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sizeIncTr = new System.Windows.Forms.Button();
            this.sizeDecTr = new System.Windows.Forms.Button();
            this.radiusTr = new System.Windows.Forms.Label();
            this.radiusSt = new System.Windows.Forms.Label();
            this.colorTr2 = new System.Windows.Forms.Button();
            this.colorTr1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.colorSt1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorSt2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(4, 5);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBox1.Mask = "00/00/0000 90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.Text = "010120120000";
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sizeIncSt
            // 
            this.sizeIncSt.Location = new System.Drawing.Point(626, 3);
            this.sizeIncSt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sizeIncSt.Name = "sizeIncSt";
            this.sizeIncSt.Size = new System.Drawing.Size(30, 30);
            this.sizeIncSt.TabIndex = 2;
            this.sizeIncSt.Text = "+";
            this.sizeIncSt.UseVisualStyleBackColor = true;
            this.sizeIncSt.Click += new System.EventHandler(this.sizeIncSt_Click);
            // 
            // sizeDecSt
            // 
            this.sizeDecSt.Location = new System.Drawing.Point(555, 3);
            this.sizeDecSt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sizeDecSt.Name = "sizeDecSt";
            this.sizeDecSt.Size = new System.Drawing.Size(30, 30);
            this.sizeDecSt.TabIndex = 3;
            this.sizeDecSt.Text = "-";
            this.sizeDecSt.UseVisualStyleBackColor = true;
            this.sizeDecSt.Click += new System.EventHandler(this.sizeDecSt_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1584, 862);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1428, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 776);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1419, 776);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.sizeIncTr);
            this.panel3.Controls.Add(this.sizeDecTr);
            this.panel3.Controls.Add(this.radiusTr);
            this.panel3.Controls.Add(this.radiusSt);
            this.panel3.Controls.Add(this.colorTr2);
            this.panel3.Controls.Add(this.colorTr1);
            this.panel3.Controls.Add(this.sizeIncSt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.colorSt1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.sizeDecSt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.colorSt2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1419, 74);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Размер поездов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Размер станций";
            // 
            // sizeIncTr
            // 
            this.sizeIncTr.Location = new System.Drawing.Point(626, 39);
            this.sizeIncTr.Name = "sizeIncTr";
            this.sizeIncTr.Size = new System.Drawing.Size(30, 30);
            this.sizeIncTr.TabIndex = 8;
            this.sizeIncTr.Text = "+";
            this.sizeIncTr.UseVisualStyleBackColor = true;
            this.sizeIncTr.Click += new System.EventHandler(this.sizeIncTr_Click);
            // 
            // sizeDecTr
            // 
            this.sizeDecTr.Location = new System.Drawing.Point(555, 39);
            this.sizeDecTr.Name = "sizeDecTr";
            this.sizeDecTr.Size = new System.Drawing.Size(30, 30);
            this.sizeDecTr.TabIndex = 7;
            this.sizeDecTr.Text = "-";
            this.sizeDecTr.UseVisualStyleBackColor = true;
            this.sizeDecTr.Click += new System.EventHandler(this.sizeDecTr_Click);
            // 
            // radiusTr
            // 
            this.radiusTr.AutoSize = true;
            this.radiusTr.Location = new System.Drawing.Point(592, 44);
            this.radiusTr.Name = "radiusTr";
            this.radiusTr.Size = new System.Drawing.Size(27, 20);
            this.radiusTr.TabIndex = 6;
            this.radiusTr.Text = "15";
            this.radiusTr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radiusSt
            // 
            this.radiusSt.AutoSize = true;
            this.radiusSt.Location = new System.Drawing.Point(592, 8);
            this.radiusSt.Name = "radiusSt";
            this.radiusSt.Size = new System.Drawing.Size(27, 20);
            this.radiusSt.TabIndex = 5;
            this.radiusSt.Text = "15";
            this.radiusSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorTr2
            // 
            this.colorTr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorTr2.Location = new System.Drawing.Point(348, 39);
            this.colorTr2.Name = "colorTr2";
            this.colorTr2.Size = new System.Drawing.Size(30, 30);
            this.colorTr2.TabIndex = 3;
            this.colorTr2.UseVisualStyleBackColor = true;
            this.colorTr2.Click += new System.EventHandler(this.ColorTr2_Click);
            // 
            // colorTr1
            // 
            this.colorTr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorTr1.Location = new System.Drawing.Point(348, 3);
            this.colorTr1.Name = "colorTr1";
            this.colorTr1.Size = new System.Drawing.Size(30, 30);
            this.colorTr1.TabIndex = 2;
            this.colorTr1.UseVisualStyleBackColor = true;
            this.colorTr1.Click += new System.EventHandler(this.colorTr1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цвет поездов 1";
            // 
            // colorSt1
            // 
            this.colorSt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorSt1.Location = new System.Drawing.Point(142, 3);
            this.colorSt1.Name = "colorSt1";
            this.colorSt1.Size = new System.Drawing.Size(30, 30);
            this.colorSt1.TabIndex = 0;
            this.colorSt1.UseVisualStyleBackColor = true;
            this.colorSt1.Click += new System.EventHandler(this.colorSt1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цвет поездов 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цвет станций 1";
            // 
            // colorSt2
            // 
            this.colorSt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorSt2.Location = new System.Drawing.Point(142, 39);
            this.colorSt2.Name = "colorSt2";
            this.colorSt2.Size = new System.Drawing.Size(30, 30);
            this.colorSt2.TabIndex = 1;
            this.colorSt2.UseVisualStyleBackColor = true;
            this.colorSt2.Click += new System.EventHandler(this.colorSt2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цвет станций 2";
            // 
            // FormVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2242, 1133);
            this.MinimumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FormVisual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVisual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVisual_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormVisual_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button sizeIncSt;
        private System.Windows.Forms.Button sizeDecSt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button colorTr2;
        private System.Windows.Forms.Button colorTr1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button colorSt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button colorSt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label radiusTr;
        private System.Windows.Forms.Label radiusSt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sizeIncTr;
        private System.Windows.Forms.Button sizeDecTr;

    }
}