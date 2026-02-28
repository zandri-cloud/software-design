using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Infrastructure
{
    public class BookstoreDbContext : DbContext {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options)
           : base(options) { }
    }
}
