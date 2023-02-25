
namespace Airport_App
{
    partial class FormFlight
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg = new System.Windows.Forms.DataGridView();
            this.dgNameAirline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNameAirplane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgWhen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgWhere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPassagesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTypesClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPriceTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPriceBaggage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameAirline = new System.Windows.Forms.TextBox();
            this.nameAirplane = new System.Windows.Forms.TextBox();
            this.where = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.typesClass = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.from = new System.Windows.Forms.TextBox();
            this.passagesCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.priceTicket = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.priceBaggage = new System.Windows.Forms.TextBox();
            this.when = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgNameAirline,
            this.dgNameAirplane,
            this.dgWhen,
            this.dgWhere,
            this.dgFrom,
            this.dgPassagesCount,
            this.dgTypesClass,
            this.dgPriceTicket,
            this.dgPriceBaggage});
            this.dg.Location = new System.Drawing.Point(334, 12);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(952, 530);
            this.dg.TabIndex = 0;
            // 
            // dgNameAirline
            // 
            this.dgNameAirline.HeaderText = "Авиакомпания";
            this.dgNameAirline.Name = "dgNameAirline";
            // 
            // dgNameAirplane
            // 
            this.dgNameAirplane.HeaderText = "Самолёт";
            this.dgNameAirplane.Name = "dgNameAirplane";
            // 
            // dgWhen
            // 
            this.dgWhen.HeaderText = "Когда";
            this.dgWhen.Name = "dgWhen";
            // 
            // dgWhere
            // 
            this.dgWhere.HeaderText = "Куда";
            this.dgWhere.Name = "dgWhere";
            // 
            // dgFrom
            // 
            this.dgFrom.HeaderText = "Откуда";
            this.dgFrom.Name = "dgFrom";
            // 
            // dgPassagesCount
            // 
            this.dgPassagesCount.HeaderText = "Мест";
            this.dgPassagesCount.Name = "dgPassagesCount";
            // 
            // dgTypesClass
            // 
            this.dgTypesClass.HeaderText = "Классы";
            this.dgTypesClass.Name = "dgTypesClass";
            // 
            // dgPriceTicket
            // 
            this.dgPriceTicket.HeaderText = "Билет р.";
            this.dgPriceTicket.Name = "dgPriceTicket";
            // 
            // dgPriceBaggage
            // 
            this.dgPriceBaggage.HeaderText = "Багаж р.";
            this.dgPriceBaggage.Name = "dgPriceBaggage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название авиакомпаний";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название самолёта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Куда";
            // 
            // nameAirline
            // 
            this.nameAirline.Location = new System.Drawing.Point(17, 86);
            this.nameAirline.Name = "nameAirline";
            this.nameAirline.Size = new System.Drawing.Size(297, 20);
            this.nameAirline.TabIndex = 2;
            // 
            // nameAirplane
            // 
            this.nameAirplane.Location = new System.Drawing.Point(17, 137);
            this.nameAirplane.Name = "nameAirplane";
            this.nameAirplane.Size = new System.Drawing.Size(297, 20);
            this.nameAirplane.TabIndex = 2;
            // 
            // where
            // 
            this.where.Location = new System.Drawing.Point(17, 239);
            this.where.Name = "where";
            this.where.Size = new System.Drawing.Size(297, 20);
            this.where.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(77, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Работа с рейсами";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Откуда";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Сколько мест";
            // 
            // btnQuit
            // 
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuit.Location = new System.Drawing.Point(264, 548);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(64, 41);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Выйти";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(334, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(952, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить данные";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(12, 548);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 41);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Классы";
            // 
            // typesClass
            // 
            this.typesClass.Location = new System.Drawing.Point(16, 392);
            this.typesClass.Name = "typesClass";
            this.typesClass.Size = new System.Drawing.Size(297, 20);
            this.typesClass.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(138, 548);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(17, 290);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(297, 20);
            this.from.TabIndex = 2;
            // 
            // passagesCount
            // 
            this.passagesCount.Location = new System.Drawing.Point(17, 341);
            this.passagesCount.Name = "passagesCount";
            this.passagesCount.Size = new System.Drawing.Size(297, 20);
            this.passagesCount.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(11, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Стоимость билета";
            // 
            // priceTicket
            // 
            this.priceTicket.Location = new System.Drawing.Point(17, 443);
            this.priceTicket.Name = "priceTicket";
            this.priceTicket.Size = new System.Drawing.Size(297, 20);
            this.priceTicket.TabIndex = 2;
            this.priceTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTicket_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Стоимость багажа";
            // 
            // priceBaggage
            // 
            this.priceBaggage.Location = new System.Drawing.Point(17, 496);
            this.priceBaggage.Name = "priceBaggage";
            this.priceBaggage.Size = new System.Drawing.Size(297, 20);
            this.priceBaggage.TabIndex = 2;
            this.priceBaggage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBaggage_KeyPress);
            // 
            // when
            // 
            this.when.Location = new System.Drawing.Point(17, 188);
            this.when.Name = "when";
            this.when.Size = new System.Drawing.Size(297, 20);
            this.when.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Когда";
            // 
            // FormFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1298, 601);
            this.Controls.Add(this.when);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.priceTicket);
            this.Controls.Add(this.priceBaggage);
            this.Controls.Add(this.typesClass);
            this.Controls.Add(this.passagesCount);
            this.Controls.Add(this.from);
            this.Controls.Add(this.where);
            this.Controls.Add(this.nameAirplane);
            this.Controls.Add(this.nameAirline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg);
            this.Name = "FormFlight";
            this.Text = "FormFlight";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFlight_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameAirline;
        private System.Windows.Forms.TextBox nameAirplane;
        private System.Windows.Forms.TextBox where;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typesClass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox passagesCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceTicket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox priceBaggage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNameAirline;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNameAirplane;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgWhen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgWhere;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPassagesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTypesClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPriceTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPriceBaggage;
        private System.Windows.Forms.DateTimePicker when;
        private System.Windows.Forms.Label label10;
    }
}