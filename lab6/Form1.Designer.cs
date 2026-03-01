namespace lab6
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
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnFetchBooks = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();

            System.Drawing.Font modernFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            System.Drawing.Color primaryBlue = System.Drawing.Color.FromArgb(0, 120, 212);

            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = modernFont;
            this.lblAuthor.Location = new System.Drawing.Point(30, 20);
            this.lblAuthor.Text = "Author Name:";

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = modernFont;
            this.lblTitle.Location = new System.Drawing.Point(30, 80);
            this.lblTitle.Text = "Book Title:";

            this.lblID.AutoSize = true;
            this.lblID.Font = modernFont;
            this.lblID.Location = new System.Drawing.Point(30, 140);
            this.lblID.Text = "Book ID (Update/Delete):";

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = modernFont;
            this.lblSearch.Location = new System.Drawing.Point(30, 310);
            this.lblSearch.Text = "Search by Book Title:";

            this.txtAuthorName.Font = modernFont;
            this.txtAuthorName.Location = new System.Drawing.Point(30, 45);
            this.txtAuthorName.Size = new System.Drawing.Size(250, 30);

            this.txtBookTitle.Font = modernFont;
            this.txtBookTitle.Location = new System.Drawing.Point(30, 105);
            this.txtBookTitle.Size = new System.Drawing.Size(250, 30);

            this.txtBookID.Font = modernFont;
            this.txtBookID.Location = new System.Drawing.Point(30, 165);
            this.txtBookID.Size = new System.Drawing.Size(250, 30);

            this.txtSearchTitle.Font = modernFont;
            this.txtSearchTitle.Location = new System.Drawing.Point(30, 335);
            this.txtSearchTitle.Size = new System.Drawing.Size(250, 30);

            void StyleButton(System.Windows.Forms.Button btn, string text, int x, int y)
            {
                btn.Text = text;
                btn.Location = new System.Drawing.Point(x, y);
                btn.Size = new System.Drawing.Size(120, 40);
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.BackColor = primaryBlue;
                btn.ForeColor = System.Drawing.Color.White;
                btn.FlatAppearance.BorderSize = 0;
            }

            this.btnAddBook = new System.Windows.Forms.Button();
            StyleButton(this.btnAddBook, "Add Async", 30, 210);
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);

            this.btnUpdateBook = new System.Windows.Forms.Button();
            StyleButton(this.btnUpdateBook, "Update Async", 160, 210);
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);

            this.btnDeleteBook = new System.Windows.Forms.Button();
            StyleButton(this.btnDeleteBook, "Delete Async", 30, 260);
            this.btnDeleteBook.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);

            this.btnSearchTitle = new System.Windows.Forms.Button();
            StyleButton(this.btnSearchTitle, "Search Title", 160, 380);
            this.btnSearchTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearchTitle.Click += new System.EventHandler(this.btnSearchTitle_Click);

            this.btnFetchBooks = new System.Windows.Forms.Button();
            StyleButton(this.btnFetchBooks, "Fetch Books Async", 320, 380);
            this.btnFetchBooks.Size = new System.Drawing.Size(430, 40);
            this.btnFetchBooks.Click += new System.EventHandler(this.btnFetchBooks_Click);

            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.listBoxBooks.Font = modernFont;
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 23;
            this.listBoxBooks.Location = new System.Drawing.Point(320, 30);
            this.listBoxBooks.Size = new System.Drawing.Size(430, 278);
            this.listBoxBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar1.Location = new System.Drawing.Point(320, 335);
            this.progressBar1.Size = new System.Drawing.Size(430, 30);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnSearchTitle);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnFetchBooks);
            this.Name = "Form1";
            this.Text = "Lab 6: Async Bookstore Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnFetchBooks;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnSearchTitle;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSearch;
    }
}