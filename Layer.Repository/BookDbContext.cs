using Layer.Core.Entities;
using Layer.Repository.Configurations;
using Layer.Repository.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository
{
   public class BookDbContext :DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options): base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Book_Category> Book_Categories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder) 
        {   
            base.OnModelCreating(builder);
            builder.ApplyConfiguration<Writer>(new WriterConfiguration());
            builder.ApplyConfiguration<Writer>(new WriterSeed());
            builder.ApplyConfiguration<Category>(new CategoryConfiguration());
            builder.ApplyConfiguration<Comment>(new CommentConfiguration());
            builder.ApplyConfiguration<Book>(new BookConfiguration());
            builder.ApplyConfiguration<Book>(new BookSeed());
            builder.ApplyConfiguration<Category>(new CategorySeed());
            
        }
       
    }

}
