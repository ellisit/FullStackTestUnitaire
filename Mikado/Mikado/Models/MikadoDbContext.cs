using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Mikado.Models
{
    public class MikadoDbContext : DbContext
    {
        public DbSet<Media> Medias { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MediaUser> MediaUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer(
              @"Server=(localdb)\mssqllocaldb;Database=Library;Integrated Security=True");
           // optionsBuilder.UseSqlite("Data Source=Library.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MediaUser>().HasKey(sc => new { sc.UserId, sc.MediaId });
        }
    }
}
