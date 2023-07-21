using MCH.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace MCH.Infrastructure
{
  public class AppDbContext : DbContext
  {
    public DbSet<Person> Persons { get; set; }
    public DbSet<Site> Sites { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //modelBuilder.Entity<Game>()
      //  .HasMany(e => e.Janres)
      //  .WithMany();

      //modelBuilder.Entity<Game>()
      //  .HasOne(e => e.GameStudio)
      //  .WithMany()
      //  .HasForeignKey(e => e.GameStudioId);

      base.OnModelCreating(modelBuilder);
    }
  }
}
