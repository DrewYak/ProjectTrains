namespace Trains
{
    partial class TrainsForm
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
//        }

//        #endregion

            this.ButSearchTrain = new System.Windows.Forms.Button();
            this.ButSearchPas = new System.Windows.Forms.Button();
            this.butData = new System.Windows.Forms.Button();
            this.butGraphic = new System.Windows.Forms.Button();
            this.tablePanelWithButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanelWithButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButSearchTrain
            // 
            this.ButSearchTrain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButSearchTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButSearchTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButSearchTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButSearchTrain.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButSearchTrain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.ButSearchTrain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButSearchTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButSearchTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSearchTrain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButSearchTrain.Location = new System.Drawing.Point(3, 3);
            this.ButSearchTrain.Name = "ButSearchTrain";
            this.ButSearchTrain.Size = new System.Drawing.Size(404, 211);
            this.ButSearchTrain.TabIndex = 0;
            this.ButSearchTrain.Tag = "";
            this.ButSearchTrain.Text = "Поиск поезда";
            this.ButSearchTrain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButSearchTrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButSearchTrain.UseVisualStyleBackColor = false;
            this.ButSearchTrain.Click += new System.EventHandler(this.ButSearchTrain_Click);
            // 
            // ButSearchPas
            // 
            this.ButSearchPas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButSearchPas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButSearchPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButSearchPas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButSearchPas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButSearchPas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.ButSearchPas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButSearchPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButSearchPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSearchPas.Location = new System.Drawing.Point(3, 220);
            this.ButSearchPas.Name = "ButSearchPas";
            this.ButSearchPas.Size = new System.Drawing.Size(404, 212);
            this.ButSearchPas.TabIndex = 1;
            this.ButSearchPas.Text = "Поиск пассажира";
            this.ButSearchPas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.butData.Location = new System.Drawing.Point(413, 3);
            this.butData.Name = "butData";
            this.butData.Size = new System.Drawing.Size(405, 211);
            this.butData.TabIndex = 2;
            this.butData.Text = "Работа с данными";
            this.butData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.butGraphic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.butGraphic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butGraphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butGraphic.Location = new System.Drawing.Point(413, 220);
            this.butGraphic.Name = "butGraphic";
            this.butGraphic.Size = new System.Drawing.Size(405, 212);
            this.butGraphic.TabIndex = 3;
            this.butGraphic.Text = "Просмотр движения поездов";
            this.butGraphic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butGraphic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butGraphic.UseVisualStyleBackColor = false;
            this.butGraphic.Click += new System.EventHandler(this.butGraphic_Click);
            // 
            // tablePanelWithButtons
            // 
            this.tablePanelWithButtons.ColumnCount = 2;
            this.tablePanelWithButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelWithButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelWithButtons.Controls.Add(this.ButSearchTrain, 0, 0);
            this.tablePanelWithButtons.Controls.Add(this.butGraphic, 1, 1);
            this.tablePanelWithButtons.Controls.Add(this.butData, 1, 0);
            this.tablePanelWithButtons.Controls.Add(this.ButSearchPas, 0, 1);
            this.tablePanelWithButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelWithButtons.Location = new System.Drawing.Point(0, 0);
            this.tablePanelWithButtons.Name = "tablePanelWithButtons";
            this.tablePanelWithButtons.RowCount = 2;
            this.tablePanelWithButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelWithButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelWithButtons.Size = new System.Drawing.Size(821, 435);
            this.tablePanelWithButtons.TabIndex = 4;
            // 
            // TrainsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 435);
            this.Controls.Add(this.tablePanelWithButtons);
            this.MaximumSize = new System.Drawing.Size(837, 473);
            this.Name = "TrainsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программная система \"Поезда и пассажиры\"";
            this.tablePanelWithButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ButSearchTrain;
        public System.Windows.Forms.Button ButSearchPas;
        public System.Windows.Forms.Button butData;
        public System.Windows.Forms.Button butGraphic;
        private System.Windows.Forms.TableLayoutPanel tablePanelWithButtons;
    }
}

