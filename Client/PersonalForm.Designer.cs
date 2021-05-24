namespace Client
{
    partial class PersonalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Look = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Button();
            this.ToOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.TimetoWait = new System.Windows.Forms.Label();
            this.unread = new System.Windows.Forms.Button();
            this.level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(375, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Личный кабинет";
            // 
            // Look
            // 
            this.Look.Location = new System.Drawing.Point(622, 165);
            this.Look.Name = "Look";
            this.Look.Size = new System.Drawing.Size(192, 23);
            this.Look.TabIndex = 1;
            this.Look.Text = "Прочитанные книги";
            this.Look.UseVisualStyleBackColor = true;
            this.Look.Click += new System.EventHandler(this.Look_Click);
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(622, 250);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(192, 23);
            this.Write.TabIndex = 2;
            this.Write.Text = "Добавить книгу";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // ToOut
            // 
            this.ToOut.Location = new System.Drawing.Point(14, 355);
            this.ToOut.Name = "ToOut";
            this.ToOut.Size = new System.Drawing.Size(155, 23);
            this.ToOut.TabIndex = 4;
            this.ToOut.Text = "Выйти из личного кабинета";
            this.ToOut.UseVisualStyleBackColor = true;
            this.ToOut.Click += new System.EventHandler(this.ToOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Возраст:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(100, 129);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 8;
            this.name.Text = "label5";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(100, 152);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(35, 13);
            this.surname.TabIndex = 9;
            this.surname.Text = "label6";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(100, 175);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(35, 13);
            this.age.TabIndex = 10;
            this.age.Text = "label7";
            // 
            // TimetoWait
            // 
            this.TimetoWait.AutoSize = true;
            this.TimetoWait.Location = new System.Drawing.Point(219, 140);
            this.TimetoWait.Name = "TimetoWait";
            this.TimetoWait.Size = new System.Drawing.Size(0, 13);
            this.TimetoWait.TabIndex = 11;
            // 
            // unread
            // 
            this.unread.Location = new System.Drawing.Point(622, 207);
            this.unread.Name = "unread";
            this.unread.Size = new System.Drawing.Size(192, 23);
            this.unread.TabIndex = 12;
            this.unread.Text = "Книги, которые хотите прочитать";
            this.unread.UseVisualStyleBackColor = true;
            this.unread.Click += new System.EventHandler(this.unread_Click);
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.level.Location = new System.Drawing.Point(12, 222);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(60, 24);
            this.level.TabIndex = 13;
            this.level.Text = "label5";
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 407);
            this.Controls.Add(this.level);
            this.Controls.Add(this.unread);
            this.Controls.Add(this.TimetoWait);
            this.Controls.Add(this.age);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToOut);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.Look);
            this.Controls.Add(this.label1);
            this.Name = "PersonalForm";
            this.Load += new System.EventHandler(this.Personal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Look;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button ToOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label TimetoWait;
        private System.Windows.Forms.Button unread;
        private System.Windows.Forms.Label level;
    }
}