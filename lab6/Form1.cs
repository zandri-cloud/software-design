using Microsoft.EntityFrameworkCore;
using System;
using lab5.Domain.Models;
using lab5.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6
{
    public partial class Form1 : Form
    {
        private BookstoreDbContextFactory _contextFactory;

        public Form1()
        {
            InitializeComponent();
            _contextFactory = new BookstoreDbContextFactory();
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthorName.Text) || string.IsNullOrWhiteSpace(txtBookTitle.Text))
            {
                MessageBox.Show("Please enter both an Author Name and a Book Title.");
                return;
            }

            btnAddBook.Enabled = false;

            using (var context = _contextFactory.CreateDbContext(null))
            {
                var author = new Author { Name = txtAuthorName.Text };
                var book = new Book { Title = txtBookTitle.Text, Author = author };

                await context.Authors.AddAsync(author);
                await context.Books.AddAsync(book);
                await context.SaveChangesAsync();

                MessageBox.Show("Book and Author added successfully!");
                txtAuthorName.Clear();
                txtBookTitle.Clear();
            }

            btnAddBook.Enabled = true;
            await FetchAndDisplayBooksAsync();
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            await FetchAndDisplayBooksAsync();
        }

        private async Task FetchAndDisplayBooksAsync()
        {
            btnFetchBooks.Enabled = false;
            listBoxBooks.Items.Clear();

            var progress = new Progress<int>(percent => progressBar1.Value = percent);
            var progressReport = (IProgress<int>)progress;

            progressReport.Report(10);

            using (var context = _contextFactory.CreateDbContext(null))
            {
                progressReport.Report(40);
                    
                var books = await context.Books.Include(b => b.Author).ToListAsync();

                progressReport.Report(80);

                foreach (var book in books)
                {
                    listBoxBooks.Items.Add($"ID: {book.BookID} | Title: {book.Title} | Author: {book.Author.Name}");
                }
            }

            progressReport.Report(100);
            btnFetchBooks.Enabled = true;
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid Book ID to update.");
                return;
            }

            btnUpdateBook.Enabled = false;

            using (var context = _contextFactory.CreateDbContext(null))
            {
                var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == bookId);

                if (book != null)
                {
                    if (!string.IsNullOrWhiteSpace(txtBookTitle.Text)) book.Title = txtBookTitle.Text;
                    if (!string.IsNullOrWhiteSpace(txtAuthorName.Text)) book.Author.Name = txtAuthorName.Text;

                    await context.SaveChangesAsync();
                    MessageBox.Show("Book updated asynchronously!");
                    await FetchAndDisplayBooksAsync();
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }

            btnUpdateBook.Enabled = true;
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid Book ID to delete.");
                return;
            }

            btnDeleteBook.Enabled = false;

            using (var context = _contextFactory.CreateDbContext(null))
            {
                var book = await context.Books.FindAsync(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                    MessageBox.Show("Book deleted asynchronously!");
                    await FetchAndDisplayBooksAsync();
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }

            btnDeleteBook.Enabled = true;
        }

        private async void btnSearchTitle_Click(object sender, EventArgs e)
        {
            string searchTitle = txtSearchTitle.Text.Trim();
            if (string.IsNullOrEmpty(searchTitle))
            {
                MessageBox.Show("Please enter a Title to search.");
                return;
            }

            btnSearchTitle.Enabled = false;
            listBoxBooks.Items.Clear();

            using (var context = _contextFactory.CreateDbContext(null))
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.Contains(searchTitle))
                    .ToListAsync();

                if (books.Any())
                {
                    foreach (var book in books)
                    {
                        listBoxBooks.Items.Add($"ID: {book.BookID} | Title: {book.Title} | Author: {book.Author.Name}");
                    }
                }
                else
                {
                    listBoxBooks.Items.Add("No books found with that title.");
                }
            }

            btnSearchTitle.Enabled = true;
        }
    }
}