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

        public DbSet<Fodor_Emanuela_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Fodor_Emanuela_lab2.Models.Publisher> Publisher { get; set; }
        public DbSet<Fodor_Emanuela_lab2.Models.Author> Author { get; set; }
    }
}
