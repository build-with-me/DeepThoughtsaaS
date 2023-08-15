using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DeepThoughtsaaS.Core;

public class ThoughtDbContext : DbContext
{

    public ThoughtDbContext(DbContextOptions<ThoughtDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Thought>().HasData(
            new Thought { Id = 1, Text = "If you go flying back through time, and you see somebody else flying forward into the future, it's probably best to avoid eye contact.", Downvotes = 0, Views = 0, Upvotes = 0 });
       modelBuilder.Entity<Thought>().HasData(
            new Thought { Id = 2, Text = "If I ever get real rich, I hope I'm not real mean to poor people, like I am now.", Downvotes = 0, Views = 0, Upvotes = 0 });
    }

    public virtual DbSet<Thought> Thoughts { get; set; } = null!;
}
