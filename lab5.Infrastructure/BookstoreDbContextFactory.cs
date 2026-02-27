using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Infrastructure
{
    public class BookstoreDbContextFactory : IDesignTimeDbContextFactory<BookstoreDbContext>
    {
        public BookstoreDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookstoreDbContext>();

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
                                          Database=BookstoreDB;
                                          Trusted_Connection=True;");

            return new BookstoreDbContext(optionsBuilder.Options);
        }
    }
}
