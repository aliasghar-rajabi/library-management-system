namespace WindowsFormsApp1
{
    partial class Form11
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
            this.Book_Search = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Book_loan = new System.Windows.Forms.Button();
            this.Dispaly_Book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Book_Search
            // 
            this.Book_Search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Book_Search.ForeColor = System.Drawing.Color.Red;
            this.Book_Search.Location = new System.Drawing.Point(11, 28);
            this.Book_Search.Margin = new System.Windows.Forms.Padding(2);
            this.Book_Search.Name = "Book_Search";
            this.Book_Search.Size = new System.Drawing.Size(145, 57);
            this.Book_Search.TabIndex = 21;
            this.Book_Search.Text = "Book Search";
            this.Book_Search.UseVisualStyleBackColor = false;
            this.Book_Search.Click += new System.EventHandler(this.Book_Search_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(196, 115);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(145, 60);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Book_loan
            // 
            this.Book_loan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Book_loan.ForeColor = System.Drawing.Color.Red;
            this.Book_loan.Location = new System.Drawing.Point(371, 28);
            this.Book_loan.Margin = new System.Windows.Forms.Padding(2);
            this.Book_loan.Name = "Book_loan";
            this.Book_loan.Size = new System.Drawing.Size(145, 57);
            this.Book_loan.TabIndex = 16;
            this.Book_loan.Text = "Book loan";
            this.Book_loan.UseVisualStyleBackColor = false;
            this.Book_loan.Click += new System.EventHandler(this.Book_loan_Click);
            // 
            // Dispaly_Book
            // 
            this.Dispaly_Book.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dispaly_Book.ForeColor = System.Drawing.Color.Red;
            this.Dispaly_Book.Location = new System.Drawing.Point(196, 28);
            this.Dispaly_Book.Margin = new System.Windows.Forms.Padding(2);
            this.Dispaly_Book.Name = "Dispaly_Book";
            this.Dispaly_Book.Size = new System.Drawing.Size(145, 57);
            this.Dispaly_Book.TabIndex = 15;
            this.Dispaly_Book.Text = "Dispaly Book";
            this.Dispaly_Book.UseVisualStyleBackColor = false;
            this.Dispaly_Book.Click += new System.EventHandler(this.Dispaly_Book_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 205);
            this.Controls.Add(this.Book_Search);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Book_loan);
            this.Controls.Add(this.Dispaly_Book);
            this.MaximumSize = new System.Drawing.Size(567, 244);
            this.MinimumSize = new System.Drawing.Size(567, 244);
            this.Name = "Form11";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Book_Search;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Book_loan;
        private System.Windows.Forms.Button Dispaly_Book;
    }
}