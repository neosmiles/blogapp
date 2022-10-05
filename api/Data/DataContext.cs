using api.Models;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DataContext: DbContext
    {
      public DataContext(DbContextOptions<DataContext> options): base(options)
      {
        
      } 
      public DbSet<BlogPost> BlogPosts { get; set; } 
      public DbSet<Author> Authors { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
        var AuthorId = 1;
        var blogPostId = 1;

        var AuthorSeeder = new Faker<Author>()
            .RuleFor(a=> a.Id, f=> AuthorId++)
            .RuleFor(a=> a.Name, f=> f.Person.FullName);
            modelBuilder.Entity<Author>().HasData(AuthorSeeder.GenerateBetween(20,20));

        var BlogPostSeeder = new Faker<BlogPost>()
            .RuleFor(bp=> bp.Id, f=> blogPostId++)
            .RuleFor(bp=> bp.AuthorId, f=> f.Random.Int(1,20))
            .RuleFor(bp=> bp.Title, f=> f.Lorem.Sentence(4))
            .RuleFor(bp=> bp.Body, f=> f.Lorem.Sentences(10));
            modelBuilder.Entity<BlogPost>().HasData(BlogPostSeeder.GenerateBetween(30,30));
            
      }
    }
}