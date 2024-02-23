using Microsoft.EntityFrameworkCore;

namespace PhotoBoothApi.Models
{
  public class PhotoBoothApiContext : DbContext
  {
    public DbSet<Booth> Booths { get; set; }

    public PhotoBoothApiContext(DbContextOptions<PhotoBoothApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
    builder.Entity<Booth>()
      .HasData(
        new Booth { BoothId = 1, Location = "The Florida Room", Address = "435 N Killingsworth St, Portland, OR 97217", Neighborhood = "NE", Type = "Digital", Color = "Both"},
        new Booth { BoothId = 2, Location = "Stumptown Coffee", Address = "1026 SW Harvey Milk St, Portland, OR 97205", Neighborhood = "SW", Type = "Film", Color = "B&W"},
        new Booth { BoothId = 3, Location = "Psychic Sister", Address = "1829 NE Alberta St ste c, Portland, OR 9721", Neighborhood = "NE", Type = "Digital", Color = "Both"},
        new Booth { BoothId = 4, Location = "Space Room Lounge", Address = "4800 SE Hawthorne Blvd, Portland, OR 97215", Neighborhood = "SE", Type = "Digital", Color = "Both"}
        );
    }
  }
}