using System.Collections;
using Microsoft.EntityFrameworkCore;
using restapinet.Domain.Models;

namespace restapinet.Persistence.Contexts;

public class AppDbContext: DbContext
{
    public DbSet<MoodEntry> MoodEntries { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<MoodEntry>().ToTable("MoodEntries");
        builder.Entity<MoodEntry>().HasKey(p => p.key);
        builder.Entity<MoodEntry>().Property(p => p.key).IsRequired();

        builder.Entity<MoodEntry>().HasData(
            new MoodEntry
            {
                key = "test1", date = DateTime.Now.ToShortDateString(),
                time = DateTime.Now.TimeOfDay.ToString(), mood = 3, sleep = 4,
                medication = true, activities = new List<Activities>(), feelings = new List<Feelings>()
            });
    }
}