namespace CaptureImage.Models
{

    //File : /Models/ImageDbContext.cs
    public class ImageDbContext : DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        { }

        public DbSet<ImageModel> Images { get; set; }
    }
}
