namespace WindowsFormsApp4
{
    partial class Basic_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basic_Window));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Amd_comboBox = new System.Windows.Forms.ComboBox();
            this.Nvidia_comboBox = new System.Windows.Forms.ComboBox();
            this.X_Button = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Intel_comboBox = new System.Windows.Forms.ComboBox();
            this.Radeon_comboBox = new System.Windows.Forms.ComboBox();
            this.Zakaz = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Nal_button = new System.Windows.Forms.RadioButton();
            this.Card_button = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Name_user = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(310, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseDown);
            // 
            // Amd_comboBox
            // 
            this.Amd_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Amd_comboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amd_comboBox.FormattingEnabled = true;
            this.Amd_comboBox.Items.AddRange(new object[] {
            "r5_3600 169$",
            "r7_3700x 300$",
            "r5_5600 239$",
            "r7_5800x3D 350$",
            "r9_5950x 799$",
            "r5_7600x 279$",
            "r7_7700x 350$",
            "r9_7950x 799$"});
            this.Amd_comboBox.Location = new System.Drawing.Point(209, 157);
            this.Amd_comboBox.Name = "Amd_comboBox";
            this.Amd_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Amd_comboBox.TabIndex = 1;
            this.Amd_comboBox.Text = "Amd";
            this.Amd_comboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Amd_comboBox_MouseClick);
            this.Amd_comboBox.MouseEnter += new System.EventHandler(this.Amd_comboBox_MouseEnter);
            // 
            // Nvidia_comboBox
            // 
            this.Nvidia_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nvidia_comboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nvidia_comboBox.FormattingEnabled = true;
            this.Nvidia_comboBox.Items.AddRange(new object[] {
            "rtx3060 250$",
            "rtx3060ti 300$",
            "rtx3070 450$",
            "rtx3080 700$",
            "rtx3090 1000$",
            "rtx4090 1209$"});
            this.Nvidia_comboBox.Location = new System.Drawing.Point(577, 271);
            this.Nvidia_comboBox.Name = "Nvidia_comboBox";
            this.Nvidia_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Nvidia_comboBox.TabIndex = 2;
            this.Nvidia_comboBox.Text = "Nvidia";
            this.Nvidia_comboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Nvidia_comboBox_MouseDown);
            this.Nvidia_comboBox.MouseEnter += new System.EventHandler(this.Nvidia_comboBox_MouseEnter);
            // 
            // X_Button
            // 
            this.X_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.X_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X_Button.Location = new System.Drawing.Point(747, 9);
            this.X_Button.Name = "X_Button";
            this.X_Button.Size = new System.Drawing.Size(24, 24);
            this.X_Button.TabIndex = 3;
            this.X_Button.Text = "X";
            this.X_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.X_Button.Click += new System.EventHandler(this.X_Button_Click);
            this.X_Button.MouseEnter += new System.EventHandler(this.X_Button_MouseEnter);
            this.X_Button.MouseLeave += new System.EventHandler(this.X_Button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(304, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбор железа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Intel_comboBox
            // 
            this.Intel_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Intel_comboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Intel_comboBox.FormattingEnabled = true;
            this.Intel_comboBox.Items.AddRange(new object[] {
            "i5_12400 149$",
            "i5_12600k 220$",
            "i7_12700k 300$",
            "i9_12900k 799$",
            "i5_13600k 250$",
            "i9_13900k 899$"});
            this.Intel_comboBox.Location = new System.Drawing.Point(450, 157);
            this.Intel_comboBox.Name = "Intel_comboBox";
            this.Intel_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Intel_comboBox.TabIndex = 5;
            this.Intel_comboBox.Text = "Intel";
            this.Intel_comboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Intel_comboBox_MouseClick);
            this.Intel_comboBox.MouseEnter += new System.EventHandler(this.Intel_comboBox_MouseEnter);
            // 
            // Radeon_comboBox
            // 
            this.Radeon_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Radeon_comboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Radeon_comboBox.FormattingEnabled = true;
            this.Radeon_comboBox.Items.AddRange(new object[] {
            "rx5600 149$",
            "rx5700 300$",
            "rx6700 320$",
            "rx6800 450$"});
            this.Radeon_comboBox.Location = new System.Drawing.Point(93, 271);
            this.Radeon_comboBox.Name = "Radeon_comboBox";
            this.Radeon_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Radeon_comboBox.TabIndex = 6;
            this.Radeon_comboBox.Text = "Radeon";
            this.Radeon_comboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Radeon_comboBox_MouseDown);
            this.Radeon_comboBox.MouseEnter += new System.EventHandler(this.Radeon_comboBox_MouseEnter);
            // 
            // Zakaz
            // 
            this.Zakaz.Location = new System.Drawing.Point(577, 383);
            this.Zakaz.Name = "Zakaz";
            this.Zakaz.Size = new System.Drawing.Size(137, 33);
            this.Zakaz.TabIndex = 7;
            this.Zakaz.Text = "Вперед";
            this.Zakaz.UseVisualStyleBackColor = true;
            this.Zakaz.Click += new System.EventHandler(this.Zakaz_Click);
            this.Zakaz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Zakaz_MouseDown);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(63, 383);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(137, 33);
            this.Back_button.TabIndex = 8;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Visible = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Nal_button
            // 
            this.Nal_button.AutoSize = true;
            this.Nal_button.BackColor = System.Drawing.Color.Transparent;
            this.Nal_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nal_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nal_button.Location = new System.Drawing.Point(209, 227);
            this.Nal_button.Name = "Nal_button";
            this.Nal_button.Size = new System.Drawing.Size(94, 27);
            this.Nal_button.TabIndex = 9;
            this.Nal_button.TabStop = true;
            this.Nal_button.Text = "Наличные";
            this.Nal_button.UseVisualStyleBackColor = false;
            this.Nal_button.Visible = false;
            this.Nal_button.MouseEnter += new System.EventHandler(this.Nal_button_MouseEnter);
            this.Nal_button.MouseLeave += new System.EventHandler(this.Nal_button_MouseLeave);
            this.Nal_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Nal_button_MouseUp);
            // 
            // Card_button
            // 
            this.Card_button.AutoSize = true;
            this.Card_button.BackColor = System.Drawing.Color.Transparent;
            this.Card_button.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Card_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Card_button.Location = new System.Drawing.Point(516, 227);
            this.Card_button.Name = "Card_button";
            this.Card_button.Size = new System.Drawing.Size(77, 27);
            this.Card_button.TabIndex = 10;
            this.Card_button.TabStop = true;
            this.Card_button.Text = "Карта";
            this.Card_button.UseVisualStyleBackColor = false;
            this.Card_button.Visible = false;
            this.Card_button.MouseEnter += new System.EventHandler(this.Card_button_MouseEnter);
            this.Card_button.MouseLeave += new System.EventHandler(this.Card_button_MouseLeave);
            this.Card_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Card_button_MouseUp);
            // 
            // Name_user
            // 
            this.Name_user.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name_user.Location = new System.Drawing.Point(310, 296);
            this.Name_user.Name = "Name_user";
            this.Name_user.Size = new System.Drawing.Size(170, 20);
            this.Name_user.TabIndex = 11;
            this.Name_user.Text = "Имя";
            this.Name_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_user.Visible = false;
            this.Name_user.Leave += new System.EventHandler(this.Name_user_Leave);
            this.Name_user.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Name_MouseDown);
            // 
            // phone
            // 
            this.phone.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.phone.Location = new System.Drawing.Point(310, 337);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(170, 20);
            this.phone.TabIndex = 12;
            this.phone.Text = "Телефон";
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phone.Visible = false;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            this.phone.Leave += new System.EventHandler(this.phone_Leave);
            this.phone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.phone_MouseDown);
            // 
            // Basic_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._015;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 493);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Name_user);
            this.Controls.Add(this.Card_button);
            this.Controls.Add(this.Nal_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Zakaz);
            this.Controls.Add(this.Radeon_comboBox);
            this.Controls.Add(this.Intel_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X_Button);
            this.Controls.Add(this.Nvidia_comboBox);
            this.Controls.Add(this.Amd_comboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Basic_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic_Window";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Basic_Window_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Basic_Window_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Amd_comboBox;
        private System.Windows.Forms.ComboBox Nvidia_comboBox;
        private System.Windows.Forms.Label X_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Intel_comboBox;
        private System.Windows.Forms.ComboBox Radeon_comboBox;
        private System.Windows.Forms.Button Zakaz;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.RadioButton Nal_button;
        private System.Windows.Forms.RadioButton Card_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox Name_user;
        private System.Windows.Forms.TextBox phone;
    }
}

