using Microsoft.EntityFrameworkCore;

using MyPortfolyo.DAL.Entities;

namespace MyPortfolyo.DAL.Context
{
    public class MyPortfolyoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ZEHRA\\SQLEXPRESS;initial Catalog=MyPortfolyoDb;integrated Security=true");
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Message> Messages  { get; set; }

        public DbSet<Portfolyo> Portfolyos { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
