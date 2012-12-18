namespace Trains
{
    partial class PsgResultByParams
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел5");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Узел6");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Узел4", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Узел9");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Узел3", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Узел1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Узел4");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Узел6");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Узел7");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Узел5", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Узел0", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode10});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TablePas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showTrains = new System.Windows.Forms.RadioButton();
            this.showPassengers = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.treeView2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Back, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TablePas);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(272, 370);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о пассажире";
            // 
            // TablePas
            // 
            this.TablePas.AllowUserToAddRows = false;
            this.TablePas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LName,
            this.FName,
            this.Tickets});
            this.TablePas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePas.Location = new System.Drawing.Point(6, 25);
            this.TablePas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TablePas.Name = "TablePas";
            this.TablePas.ReadOnly = true;
            this.TablePas.Size = new System.Drawing.Size(260, 339);
            this.TablePas.TabIndex = 0;
            this.TablePas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablePas_CellContentClick);
            this.TablePas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablePas_CellContentClick);
            this.TablePas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablePas_CellContentClick);
            this.TablePas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablePas_CellContentClick);
            this.TablePas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TablePas_CellContentClick);
            this.TablePas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TablePas_CellContentClick);
            this.TablePas.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TablePas_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "Номер паспорта";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // LName
            // 
            this.LName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LName.HeaderText = "Фамилия";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            this.LName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FName
            // 
            this.FName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FName.HeaderText = "Имя";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // Tickets
            // 
            this.Tickets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tickets.HeaderText = "Билеты";
            this.Tickets.Name = "Tickets";
            this.Tickets.ReadOnly = true;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(690, 86);
            this.treeView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Узел5";
            treeNode1.Text = "Узел5";
            treeNode2.Name = "Узел6";
            treeNode2.Text = "Узел6";
            treeNode3.Name = "Узел4";
            treeNode3.Text = "Узел4";
            treeNode4.Name = "Узел9";
            treeNode4.Text = "Узел9";
            treeNode5.Name = "Узел3";
            treeNode5.Text = "Узел3";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView2.Size = new System.Drawing.Size(388, 370);
            this.treeView2.TabIndex = 5;
            this.treeView2.Visible = false;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(290, 86);
            this.treeView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.treeView1.Name = "treeView1";
            treeNode6.Name = "Узел1";
            treeNode6.Text = "Узел1";
            treeNode7.Name = "Узел4";
            treeNode7.Text = "Узел4";
            treeNode8.Name = "Узел6";
            treeNode8.Text = "Узел6";
            treeNode9.Name = "Узел7";
            treeNode9.Text = "Узел7";
            treeNode10.Name = "Узел5";
            treeNode10.Text = "Узел5";
            treeNode11.Name = "Узел0";
            treeNode11.Text = "Узел0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(388, 370);
            this.treeView1.TabIndex = 4;
            this.treeView1.Visible = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(290, 6);
            this.Back.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(388, 68);
            this.Back.TabIndex = 1;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showTrains);
            this.panel1.Controls.Add(this.showPassengers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 68);
            this.panel1.TabIndex = 6;
            // 
            // showTrains
            // 
            this.showTrains.AutoSize = true;
            this.showTrains.Location = new System.Drawing.Point(9, 34);
            this.showTrains.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.showTrains.Name = "showTrains";
            this.showTrains.Size = new System.Drawing.Size(95, 28);
            this.showTrains.TabIndex = 1;
            this.showTrains.TabStop = true;
            this.showTrains.Text = "Поезда";
            this.showTrains.UseVisualStyleBackColor = true;
            this.showTrains.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // showPassengers
            // 
            this.showPassengers.AutoSize = true;
            this.showPassengers.Location = new System.Drawing.Point(9, 6);
            this.showPassengers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.showPassengers.Name = "showPassengers";
            this.showPassengers.Size = new System.Drawing.Size(130, 28);
            this.showPassengers.TabIndex = 0;
            this.showPassengers.TabStop = true;
            this.showPassengers.Text = "Пассажиры";
            this.showPassengers.UseVisualStyleBackColor = true;
            this.showPassengers.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PsgResultByParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "PsgResultByParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPsgResultByParams";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView TablePas;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tickets;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton showTrains;
        public System.Windows.Forms.RadioButton showPassengers;
    }
}