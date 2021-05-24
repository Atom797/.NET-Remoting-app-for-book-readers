namespace Client
{
    partial class NewBook
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
            this.ToAdd = new System.Windows.Forms.Button();
            this.ToBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.read = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Автор книги:";
            // 
            // ToAdd
            // 
            this.ToAdd.Location = new System.Drawing.Point(411, 256);
            this.ToAdd.Name = "ToAdd";
            this.ToAdd.Size = new System.Drawing.Size(122, 23);
            this.ToAdd.TabIndex = 3;
            this.ToAdd.Text = "Добавить в список";
            this.ToAdd.UseVisualStyleBackColor = true;
            this.ToAdd.Click += new System.EventHandler(this.ToAdd_Click);
            // 
            // ToBack
            // 
            this.ToBack.Location = new System.Drawing.Point(12, 372);
            this.ToBack.Name = "ToBack";
            this.ToBack.Size = new System.Drawing.Size(75, 23);
            this.ToBack.TabIndex = 4;
            this.ToBack.Text = "Назад";
            this.ToBack.UseVisualStyleBackColor = true;
            this.ToBack.Click += new System.EventHandler(this.ToBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(392, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Добавьте книгу";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(412, 158);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(122, 20);
            this.author.TabIndex = 7;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(411, 199);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(122, 20);
            this.title.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название книги:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(565, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "примечание: в поле прочитали или хотите прочитать \r\nесли вы прочитали введите:\"Пр" +
    "очитал\"\r\nесли хотите прочитать:\"Хочу прочитать\"\r\n";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Читали или хотите прочитать:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // read
            // 
            this.read.FormattingEnabled = true;
            this.read.Items.AddRange(new object[] {
            "Прочитал",
            "Хочу прочитать"});
            this.read.Location = new System.Drawing.Point(412, 117);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(121, 21);
            this.read.TabIndex = 10;
            // 
            // NewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 407);
            this.Controls.Add(this.read);
            this.Controls.Add(this.title);
            this.Controls.Add(this.author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToBack);
            this.Controls.Add(this.ToAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "NewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NewNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToAdd;
        private System.Windows.Forms.Button ToBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox read;
    }
}