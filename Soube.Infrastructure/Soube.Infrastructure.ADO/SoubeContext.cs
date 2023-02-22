using Microsoft.EntityFrameworkCore;
using Soube.Infrastructure.ADO.Data;

namespace Soube.Infrastructure.ADO;

public partial class SoubeContext : DbContext
{
    public SoubeContext(DbContextOptions<SoubeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WeatherForecast> WeatherForecast { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherForecast>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WeatherF__3214EC071949EF2E");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}