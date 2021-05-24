namespace Client
{
    partial class Registration
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
            this.regB = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.age1 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regB
            // 
            this.regB.Location = new System.Drawing.Point(436, 283);
            this.regB.Name = "regB";
            this.regB.Size = new System.Drawing.Size(104, 23);
            this.regB.TabIndex = 0;
            this.regB.Text = "Регистрация";
            this.regB.UseVisualStyleBackColor = true;
            this.regB.Click += new System.EventHandler(this.regB_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 362);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(52, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(436, 143);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(104, 20);
            this.name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ваше имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ваша фамилия";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(436, 221);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(104, 20);
            this.login.TabIndex = 6;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(436, 247);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(104, 20);
            this.password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ваш пароль";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(436, 169);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(104, 20);
            this.surname.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ваш логин";
            // 
            // age1
            // 
            this.age1.AutoSize = true;
            this.age1.Location = new System.Drawing.Point(347, 195);
            this.age1.Name = "age1";
            this.age1.Size = new System.Drawing.Size(72, 13);
            this.age1.TabIndex = 5;
            this.age1.Text = "Ваш возраст";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(436, 195);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(104, 20);
            this.age.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(288, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите ваши данные для регистрации";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 407);
            this.Controls.Add(this.age);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.age1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.regB);
            this.Name = "Registration";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regB;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label age1;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label3;
    }
}