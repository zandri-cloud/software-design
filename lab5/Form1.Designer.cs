namespace lab5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Modern Font Setting
            System.Drawing.Font modernFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            System.Drawing.Color primaryBlue = System.Drawing.Color.FromArgb(0, 120, 212);

            // Labels
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = modernFont;
            this.lblAuthor.Location = new System.Drawing.Point(30, 30);
            this.lblAuthor.Text = "Author Name:";

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = modernFont;
            this.lblTitle.Location = new System.Drawing.Point(30, 90);
            this.lblTitle.Text = "Book Title:";

            this.lblID.AutoSize = true;
            this.lblID.Font = modernFont;
            this.lblID.Location = new System.Drawing.Point(30, 150);
            this.lblID.Text = "Book ID (Update/Delete):";

            // TextBoxes
            this.txtAuthorName.Font = modernFont;
            this.txtAuthorName.Location = new System.Drawing.Point(30, 55);
            this.txtAuthorName.Size = new System.Drawing.Size(250, 30);

            this.txtBookTitle.Font = modernFont;
            this.txtBookTitle.Location = new System.Drawing.Point(30, 115);
            this.txtBookTitle.Size = new System.Drawing.Size(250, 30);

            this.txtBookID.Font = modernFont;
            this.txtBookID.Location = new System.Drawing.Point(30, 175);
            this.txtBookID.Size = new System.Drawing.Size(250, 30);

            // Buttons Configuration Method
            void StyleButton(System.Windows.Forms.Button btn, string text, int x, int y)
            {
                btn.Text = text;
                btn.Location = new System.Drawing.Point(x, y);
                btn.Size = new System.Drawing.Size(120, 40);
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.BackColor = primaryBlue;
                btn.ForeColor = System.Drawing.Color.White;
                btn.FlatAppearance.BorderSize = 0;
            }

            // Apply Styles to Buttons
            this.btnAddBook = new System.Windows.Forms.Button();
            StyleButton(this.btnAddBook, "Add Book", 30, 230);
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);

            this.btnUpdateBook = new System.Windows.Forms.Button();
            StyleButton(this.btnUpdateBook, "Update Book", 160, 230);
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);

            this.btnDeleteBook = new System.Windows.Forms.Button();
            StyleButton(this.btnDeleteBook, "Delete Book", 30, 280);
            this.btnDeleteBook.BackColor = System.Drawing.Color.Crimson; // Red for delete
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);

            this.btnSearchAuthor = new System.Windows.Forms.Button();
            StyleButton(this.btnSearchAuthor, "Search Author", 160, 280);
            this.btnSearchAuthor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);

            this.btnShowBooks = new System.Windows.Forms.Button();
            StyleButton(this.btnShowBooks, "Show All Books", 320, 380);
            this.btnShowBooks.Size = new System.Drawing.Size(430, 40);
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);

            // ListBox
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.listBoxBooks.Font = modernFont;
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 23;
            this.listBoxBooks.Location = new System.Drawing.Point(320, 30);
            this.listBoxBooks.Size = new System.Drawing.Size(430, 326);
            this.listBoxBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245); // Light Gray Background
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.btnShowBooks);
            this.Name = "Form1";
            this.Text = "Modern Bookstore Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
    }
}