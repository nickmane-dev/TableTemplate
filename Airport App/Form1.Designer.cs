namespace Airport_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backround = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.regTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.authPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.auth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backround)).BeginInit();
            this.authPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backround
            // 
            this.backround.Image = ((System.Drawing.Image)(resources.GetObject("backround.Image")));
            this.backround.Location = new System.Drawing.Point(-41, 90);
            this.backround.Name = "backround";
            this.backround.Size = new System.Drawing.Size(1038, 710);
            this.backround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backround.TabIndex = 0;
            this.backround.TabStop = false;
            // 
            // icon
            // 
            this.icon.AutoSize = true;
            this.icon.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.icon.Location = new System.Drawing.Point(6, 13);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(272, 58);
            this.icon.TabIndex = 1;
            this.icon.Text = "Airport App";
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(293, 23);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(193, 46);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Работа с рейсами";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn2_click);
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(749, 23);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(232, 46);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Работа с персоналом\r\n";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(485, 23);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(263, 46);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Работа с пассажирами";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // regTicket
            // 
            this.regTicket.BackColor = System.Drawing.Color.Transparent;
            this.regTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regTicket.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regTicket.ForeColor = System.Drawing.Color.White;
            this.regTicket.Location = new System.Drawing.Point(809, 260);
            this.regTicket.Name = "regTicket";
            this.regTicket.Size = new System.Drawing.Size(188, 46);
            this.regTicket.TabIndex = 2;
            this.regTicket.Text = "Оформить билет";
            this.regTicket.UseVisualStyleBackColor = false;
            this.regTicket.Click += new System.EventHandler(this.regTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(571, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 174);
            this.label1.TabIndex = 5;
            this.label1.Text = "Регистрация\r\nбилетов для новых\r\nпассажиров";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.Color.White;
            this.authPanel.Controls.Add(this.label5);
            this.authPanel.Controls.Add(this.label4);
            this.authPanel.Controls.Add(this.label3);
            this.authPanel.Controls.Add(this.password);
            this.authPanel.Controls.Add(this.surname);
            this.authPanel.Controls.Add(this.name);
            this.authPanel.Controls.Add(this.button2);
            this.authPanel.Controls.Add(this.auth);
            this.authPanel.Controls.Add(this.label2);
            this.authPanel.Location = new System.Drawing.Point(16, 116);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(408, 204);
            this.authPanel.TabIndex = 6;
            this.authPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(103, 118);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(177, 20);
            this.password.TabIndex = 2;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(103, 93);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(177, 20);
            this.surname.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(103, 68);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(177, 20);
            this.name.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(204, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // auth
            // 
            this.auth.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth.Location = new System.Drawing.Point(15, 156);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(183, 34);
            this.auth.TabIndex = 1;
            this.auth.Text = "Войти в систему";
            this.auth.UseVisualStyleBackColor = true;
            this.auth.Click += new System.EventHandler(this.auth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(113, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Авторизация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 560);
            this.Controls.Add(this.authPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regTicket);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.backround);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airport App v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backround)).EndInit();
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backround;
        private System.Windows.Forms.Label icon;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button regTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button auth;
        private System.Windows.Forms.Label label2;
    }
}

