namespace LogProcessingApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExportBtn = new System.Windows.Forms.Button();
            this.CancelExportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportState = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBoxSystem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.checkBoxW = new System.Windows.Forms.CheckBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.checkBoxI = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.logGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(346, 168);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(139, 29);
            this.ExportBtn.TabIndex = 0;
            this.ExportBtn.Text = "Начать экспорт";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // CancelExportBtn
            // 
            this.CancelExportBtn.Enabled = false;
            this.CancelExportBtn.Location = new System.Drawing.Point(491, 168);
            this.CancelExportBtn.Name = "CancelExportBtn";
            this.CancelExportBtn.Size = new System.Drawing.Size(149, 29);
            this.CancelExportBtn.TabIndex = 2;
            this.CancelExportBtn.Text = "Отменить";
            this.CancelExportBtn.UseVisualStyleBackColor = true;
            this.CancelExportBtn.Click += new System.EventHandler(this.CancelExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelExportBtn);
            this.groupBox1.Controls.Add(this.ExportBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ExportState);
            this.groupBox1.Location = new System.Drawing.Point(27, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cостояние Экспорта";
            // 
            // ExportState
            // 
            this.ExportState.Location = new System.Drawing.Point(167, 37);
            this.ExportState.Multiline = true;
            this.ExportState.Name = "ExportState";
            this.ExportState.ReadOnly = true;
            this.ExportState.Size = new System.Drawing.Size(473, 125);
            this.ExportState.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchBtn);
            this.groupBox2.Controls.Add(this.textBoxSystem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBoxE);
            this.groupBox2.Controls.Add(this.checkBoxW);
            this.groupBox2.Controls.Add(this.checkBoxD);
            this.groupBox2.Controls.Add(this.checkBoxI);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePickerTo);
            this.groupBox2.Controls.Add(this.dateTimePickerFrom);
            this.groupBox2.Location = new System.Drawing.Point(27, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 191);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search params";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(491, 146);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(149, 29);
            this.SearchBtn.TabIndex = 15;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // textBoxSystem
            // 
            this.textBoxSystem.Location = new System.Drawing.Point(167, 106);
            this.textBoxSystem.Name = "textBoxSystem";
            this.textBoxSystem.Size = new System.Drawing.Size(473, 22);
            this.textBoxSystem.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Система";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Типы";
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Location = new System.Drawing.Point(301, 73);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(39, 21);
            this.checkBoxE.TabIndex = 11;
            this.checkBoxE.Text = "E";
            this.checkBoxE.UseVisualStyleBackColor = true;
            // 
            // checkBoxW
            // 
            this.checkBoxW.AutoSize = true;
            this.checkBoxW.Location = new System.Drawing.Point(252, 73);
            this.checkBoxW.Name = "checkBoxW";
            this.checkBoxW.Size = new System.Drawing.Size(43, 21);
            this.checkBoxW.TabIndex = 10;
            this.checkBoxW.Text = "W";
            this.checkBoxW.UseVisualStyleBackColor = true;
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(206, 73);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(40, 21);
            this.checkBoxD.TabIndex = 9;
            this.checkBoxD.Text = "D";
            this.checkBoxD.UseVisualStyleBackColor = true;
            // 
            // checkBoxI
            // 
            this.checkBoxI.AutoSize = true;
            this.checkBoxI.Location = new System.Drawing.Point(167, 73);
            this.checkBoxI.Name = "checkBoxI";
            this.checkBoxI.Size = new System.Drawing.Size(33, 21);
            this.checkBoxI.TabIndex = 8;
            this.checkBoxI.Text = "I";
            this.checkBoxI.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "по";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Период  с";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(440, 28);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(167, 28);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(193, 22);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // logGridView
            // 
            this.logGridView.AllowUserToDeleteRows = false;
            this.logGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logGridView.Location = new System.Drawing.Point(27, 457);
            this.logGridView.Name = "logGridView";
            this.logGridView.ReadOnly = true;
            this.logGridView.RowHeadersWidth = 51;
            this.logGridView.RowTemplate.Height = 24;
            this.logGridView.Size = new System.Drawing.Size(732, 245);
            this.logGridView.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 714);
            this.Controls.Add(this.logGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Log export";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button CancelExportBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExportState;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox textBoxSystem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxE;
        private System.Windows.Forms.CheckBox checkBoxW;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.CheckBox checkBoxI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView logGridView;
    }
}

