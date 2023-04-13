using Assignment.CMS22.OOAD.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment.CMS22.OOAD.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ArticleEntity>? Articles { get; set; }
        public DbSet<ArticleGroupEntity>? ArticleGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleGroupEntity>().HasData(
                new ArticleGroupEntity { Id = 1, Blog = "Blog"},
                new ArticleGroupEntity { Id = 2, News = "News" },
                new ArticleGroupEntity { Id = 3, Product = "Product" }
            );
        }
    }
}