using System;
using BlogEntity.Data.Mappings;
using BlogEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEntity.Data
{
    public class BlogEntityDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(
                "Server=localhost,1433;Database=BlogFluentEntity;User ID=sa;Password=S4k0r400;TrustServerCertificate=True ");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
        }
    }
}