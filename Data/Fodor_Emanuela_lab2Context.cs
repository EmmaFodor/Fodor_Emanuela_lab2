using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fodor_Emanuela_lab2.Models;

namespace Fodor_Emanuela_lab2.Data
{
    public class Fodor_Emanuela_lab2Context : DbContext
    {
        public Fodor_Emanuela_lab2Context (DbContextOptions<Fodor_Emanuela_lab2Context> options)
            : base(options)
        {
        }
        /*protected override void onModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.BookCategories)
                .HasForeignKey(bi => bi.BookID);

           /* modelBuilder.Entity<Author>()
                .HasOne(b => b.Author)
                .WithMany(ba => ba.BookCategories)
                .HasForeignKey(bi => bi.AuthorID);*/

           // base.OnModelCreating(modelBuilder);

        public DbSet<Fodor_Emanuela_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Fodor_Emanuela_lab2.Models.Publisher> Publisher { get; set; }
        public DbSet<Fodor_Emanuela_lab2.Models.Author> Author { get; set; }
        public DbSet<Fodor_Emanuela_lab2.Models.Category> Category { get; set; }
        public DbSet<Fodor_Emanuela_lab2.Models.Member> Member { get; set; }
        public DbSet<Fodor_Emanuela_lab2.Models.Borrowing> Borrowing { get; set; }
       // public DbSet<Fodor_Emanuela_lab2.Models.BookCategory> BookCategories { get; set; }
    }
}
