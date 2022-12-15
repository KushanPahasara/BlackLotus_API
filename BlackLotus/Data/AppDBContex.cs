using Microsoft.EntityFrameworkCore;
using BlackLotus.Model;
using System;

namespace BlackLotus.Data
{
    public class AppDBContex:DbContext
    {
        public AppDBContex(DbContextOptions<AppDBContex> options) : base(options)
        {

        }
        public DbSet<Flower> flower { get; set; }
        public DbSet<Catagory> catagory { get; set; }

        public DbSet<Stock> stock { get; set; } 
        public DbSet<Order> order { get; set; }

        public DbSet<User> user { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flower>().ToTable("flower");
            modelBuilder.Entity<Catagory>().ToTable("catgory");
            modelBuilder.Entity<Stock>().ToTable("stock");
            modelBuilder.Entity<Order>().ToTable("order");
            modelBuilder.Entity<User>().ToTable("user");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = "Data Source=DESKTOP-6KQ0841\\SQL2019;Initial Catalog=BlackLotusDB;Persist Security Info=True;User ID=sa;Password=sql@123";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
