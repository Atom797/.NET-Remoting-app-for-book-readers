namespace Client
{
    partial class Input
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
            this.inputbatton = new System.Windows.Forms.Button();
            this.login1 = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputbatton
            // 
            this.inputbatton.Location = new System.Drawing.Point(410, 263);
            this.inputbatton.Name = "inputbatton";
            this.inputbatton.Size = new System.Drawing.Size(100, 23);
            this.inputbatton.TabIndex = 0;
            this.inputbatton.Text = "Войти";
            this.inputbatton.UseVisualStyleBackColor = true;
            this.inputbatton.Click += new System.EventHandler(this.inputbatton_Click);
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(410, 144);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(100, 20);
            this.login1.TabIndex = 1;
            this.login1.TextChanged += new System.EventHandler(this.login1_TextChanged);
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(410, 201);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(100, 20);
            this.password1.TabIndex = 2;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(329, 144);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(41, 13);
            this.login.TabIndex = 3;
            this.login.Text = "Логин:";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(322, 201);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(48, 13);
            this.password.TabIndex = 4;
            this.password.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(347, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите ваши данные";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 372);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 6;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 407);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.inputbatton);
            this.Name = "Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Input_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputbatton;
        private System.Windows.Forms.TextBox login1;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}

