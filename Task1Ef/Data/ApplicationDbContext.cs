using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Ef.Models;

namespace Task1Ef.Data
{
    internal class ApplicationDbContext: DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Task1;Trusted_Connection=True;TrustServerCertificate=True");

        }
    }
}
