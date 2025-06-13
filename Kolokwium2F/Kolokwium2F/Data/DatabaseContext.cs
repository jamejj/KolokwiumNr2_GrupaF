using Kolokwium2F.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2F.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Artist> Artists { get; set; } = null!;
    public DbSet<Artwork> Artworks { get; set; } = null!;
    public DbSet<Exhibition> Exhibitions { get; set; } = null!;
    public DbSet<ExhibitionArtwork> ExhibitionArtworks { get; set; } = null!;
    public DbSet<Gallery> Galleries { get; set; } = null!;

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}