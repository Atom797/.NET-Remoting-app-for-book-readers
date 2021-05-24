namespace Client
{
    partial class Read
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
            this.back = new System.Windows.Forms.Button();
            this.mylist = new System.Windows.Forms.ListView();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(329, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Книги, котрые вы прочитали:";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 372);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // mylist
            // 
            this.mylist.HideSelection = false;
            this.mylist.Location = new System.Drawing.Point(193, 79);
            this.mylist.Name = "mylist";
            this.mylist.Size = new System.Drawing.Size(548, 267);
            this.mylist.TabIndex = 3;
            this.mylist.UseCompatibleStateImageBehavior = false;
            this.mylist.View = System.Windows.Forms.View.List;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.status.Location = new System.Drawing.Point(242, 359);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 24);
            this.status.TabIndex = 4;
            this.status.Text = "label2";
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 407);
            this.Controls.Add(this.status);
            this.Controls.Add(this.mylist);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Name = "Read";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OtherNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListView mylist;
        private System.Windows.Forms.Label status;
    }
}