using lab5.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using lab5.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using lab5.Domain.Models;

namespace lab5
{
    public partial class Form1 : Form
    {
        private BookstoreDbContextFactory _contextFactory;

        public Form1()
        {
            InitializeComponent();
            _contextFactory = new BookstoreDbContextFactory();
        }

        // --- TASK 5: Add a New Author and Book ---
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthorName.Text) || string.IsNullOrWhiteSpace(txtBookTitle.Text))
            {
                MessageBox.Show("Please enter both an Author Name and a Book Title.");
                return;
            }

            using (var context = _contextFactory.CreateDbContext(null))
            {
                var author = new Author { Name = txtAuthorName.Text };
                var book = new Book { Title = txtBookTitle.Text, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();

                MessageBox.Show("Book and Author added successfully!");
                ClearInputs();
                ShowAllBooks(); // Refresh list
            }
        }

        // --- TASK 5: Display All Books ---
        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            ShowAllBooks();
        }

        private void ShowAllBooks()
        {
            listBoxBooks.Items.Clear();
            using (var context = _contextFactory.CreateDbContext(null))
            {
                var books = context.Books.Include(b => b.Author).ToList();
                foreach (var book in books)
                {
                    listBoxBooks.Items.Add($"ID: {book.BookID} | Title: {book.Title} | Author: {book.Author.Name}");
                }
            }
        }

        // --- TASK 6: Update Book and Author Information ---
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid Book ID to update.");
                return;
            }

            using (var context = _contextFactory.CreateDbContext(null))
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);

                if (book != null)
                {
                    if (!string.IsNullOrWhiteSpace(txtBookTitle.Text)) book.Title = txtBookTitle.Text;
                    if (!string.IsNullOrWhiteSpace(txtAuthorName.Text)) book.Author.Name = txtAuthorName.Text;

                    context.SaveChanges();
                    MessageBox.Show("Book/Author updated successfully!");
                    ShowAllBooks();
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        // --- TASK 7: Delete a Book ---
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid Book ID to delete.");
                return;
            }

            using (var context = _contextFactory.CreateDbContext(null))
            {
                var book = context.Books.Find(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully!");
                    ShowAllBooks();
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        // --- TASK 7: Search Books by Author ---
        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string searchName = txtAuthorName.Text.Trim();
            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Please enter an Author Name to search.");
                return;
            }

            listBoxBooks.Items.Clear();
            using (var context = _contextFactory.CreateDbContext(null))
            {
                var books = context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(searchName))
                    .ToList();

                if (books.Any())
                {
                    foreach (var book in books)
                    {
                        listBoxBooks.Items.Add($"ID: {book.BookID} | Title: {book.Title} | Author: {book.Author.Name}");
                    }
                }
                else
                {
                    listBoxBooks.Items.Add("No books found for this author.");
                }
            }
        }

        private void ClearInputs()
        {
            txtAuthorName.Clear();
            txtBookTitle.Clear();
            txtBookID.Clear();
        }
    }
}