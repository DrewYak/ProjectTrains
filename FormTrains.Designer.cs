namespace Trains
{
    partial class FormTrains
    {
        /// <summary>
        /// ��������� ���������� ������������.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ���������� ��� ������������ �������.
        /// </summary>
        /// <param name="disposing">�������, ���� ����������� ������ ������ ���� ������; ����� �����.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region ���, ������������� ��������� ������������� ���� Windows

        /// <summary>
        /// ������������ ����� ��� ��������� ������������ - �� ���������
        /// ���������� ������� ������ ��� ������ ��������� ����.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButSearchPas = new System.Windows.Forms.Button();
            this.butData = new System.Windows.Forms.Button();
            this.butGraphic = new System.Windows.Forms.Button();
            this.tablePanelWithButtons = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tablePanelWithButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButSearchPas
            // 
            this.ButSearchPas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButSearchPas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButSearchPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButSearchPas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButSearchPas.Enabled = false;
            this.ButSearchPas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButSearchPas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.ButSearchPas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButSearchPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButSearchPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSearchPas.Location = new System.Drawing.Point(6, 6);
            this.ButSearchPas.Margin = new System.Windows.Forms.Padding(6);
            this.ButSearchPas.Name = "ButSearchPas";
            this.ButSearchPas.Size = new System.Drawing.Size(230, 119);
            this.ButSearchPas.TabIndex = 1;
            this.ButSearchPas.Text = "�����";
            this.ButSearchPas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButSearchPas.UseVisualStyleBackColor = false;
            this.ButSearchPas.Click += new System.EventHandler(this.ButSearchPas_Click);
            // 
            // butData
            // 
            this.butData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.butData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butData.Location = new System.Drawing.Point(248, 6);
            this.butData.Margin = new System.Windows.Forms.Padding(6);
            this.butData.Name = "butData";
            this.butData.Size = new System.Drawing.Size(237, 119);
            this.butData.TabIndex = 2;
            this.butData.Text = "������ � �������";
            this.butData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butData.UseVisualStyleBackColor = false;
            this.butData.Click += new System.EventHandler(this.butData_Click);
            // 
            // butGraphic
            // 
            this.butGraphic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butGraphic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butGraphic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butGraphic.Enabled = false;
            this.butGraphic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.butGraphic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butGraphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butGraphic.Location = new System.Drawing.Point(497, 6);
            this.butGraphic.Margin = new System.Windows.Forms.Padding(6);
            this.butGraphic.Name = "butGraphic";
            this.butGraphic.Size = new System.Drawing.Size(231, 119);
            this.butGraphic.TabIndex = 3;
            this.butGraphic.Text = "�������� �������� �������";
            this.butGraphic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butGraphic.UseVisualStyleBackColor = false;
            this.butGraphic.Click += new System.EventHandler(this.butGraphic_Click);
            // 
            // tablePanelWithButtons
            // 
            this.tablePanelWithButtons.ColumnCount = 3;
            this.tablePanelWithButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tablePanelWithButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tablePanelWithButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tablePanelWithButtons.Controls.Add(this.ButSearchPas, 0, 0);
            this.tablePanelWithButtons.Controls.Add(this.button2, 0, 1);
            this.tablePanelWithButtons.Controls.Add(this.button3, 1, 1);
            this.tablePanelWithButtons.Controls.Add(this.button4, 2, 1);
            this.tablePanelWithButtons.Controls.Add(this.butData, 1, 0);
            this.tablePanelWithButtons.Controls.Add(this.butGraphic, 2, 0);
            this.tablePanelWithButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelWithButtons.Location = new System.Drawing.Point(0, 0);
            this.tablePanelWithButtons.Margin = new System.Windows.Forms.Padding(6);
            this.tablePanelWithButtons.Name = "tablePanelWithButtons";
            this.tablePanelWithButtons.RowCount = 2;
            this.tablePanelWithButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelWithButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelWithButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelWithButtons.Size = new System.Drawing.Size(734, 262);
            this.tablePanelWithButtons.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(6, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 119);
            this.button2.TabIndex = 5;
            this.button2.Text = "�������������� ���������";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(248, 137);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 119);
            this.button3.TabIndex = 6;
            this.button3.Text = "�������������� �������";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(497, 137);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 119);
            this.button4.TabIndex = 7;
            this.button4.Text = "�������������� ����������";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormTrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 262);
            this.Controls.Add(this.tablePanelWithButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(750, 300);
            this.Name = "FormTrains";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "����������� ������� \"������ � ���������\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormTrains_Activated);
            this.Load += new System.EventHandler(this.FormTrains_Activated);
            this.tablePanelWithButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ButSearchPas;
        public System.Windows.Forms.Button butData;
        public System.Windows.Forms.Button butGraphic;
        private System.Windows.Forms.TableLayoutPanel tablePanelWithButtons;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
