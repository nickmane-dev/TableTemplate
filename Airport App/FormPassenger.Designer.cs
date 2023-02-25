
namespace Airport_App
{
    partial class FormPassenger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dg = new System.Windows.Forms.DataGridView();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPassportSeria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPassage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTypeClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBaggage = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgNumFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgName,
            this.dgSurname,
            this.dgPatronymic,
            this.dgHbd,
            this.dgNumber,
            this.dgPassportSeria,
            this.dgPassage,
            this.dgTypeClass,
            this.dgBaggage,
            this.dgNumFlight});
            this.dg.Location = new System.Drawing.Point(247, 12);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1054, 585);
            this.dg.TabIndex = 0;
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Имя";
            this.dgName.Name = "dgName";
            // 
            // dgSurname
            // 
            this.dgSurname.HeaderText = "Фамилия";
            this.dgSurname.Name = "dgSurname";
            // 
            // dgPatronymic
            // 
            this.dgPatronymic.HeaderText = "Отчество";
            this.dgPatronymic.Name = "dgPatronymic";
            // 
            // dgHbd
            // 
            this.dgHbd.HeaderText = "ДР";
            this.dgHbd.Name = "dgHbd";
            // 
            // dgNumber
            // 
            this.dgNumber.HeaderText = "Номер тл.";
            this.dgNumber.Name = "dgNumber";
            // 
            // dgPassportSeria
            // 
            this.dgPassportSeria.HeaderText = "Серия пасп.";
            this.dgPassportSeria.Name = "dgPassportSeria";
            // 
            // dgPassage
            // 
            this.dgPassage.HeaderText = "Место";
            this.dgPassage.Name = "dgPassage";
            // 
            // dgTypeClass
            // 
            this.dgTypeClass.HeaderText = "Класс";
            this.dgTypeClass.Name = "dgTypeClass";
            // 
            // dgBaggage
            // 
            this.dgBaggage.HeaderText = "Багаж";
            this.dgBaggage.Items.AddRange(new object[] {
            "Есть",
            "Нету"});
            this.dgBaggage.Name = "dgBaggage";
            // 
            // dgNumFlight
            // 
            this.dgNumFlight.HeaderText = "Номер рейса";
            this.dgNumFlight.Name = "dgNumFlight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Работа с пассажирами";
            // 
            // btnQuit
            // 
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuit.Location = new System.Drawing.Point(12, 556);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(224, 41);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Выйти";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(12, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(224, 87);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить данные";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(12, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(224, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1313, 609);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dg);
            this.Name = "FormPassenger";
            this.Text = "FormPassenger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPassenger_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPassportSeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPassage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTypeClass;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgBaggage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNumFlight;
    }
}