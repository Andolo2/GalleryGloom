using GalleryGloomV2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GalleryGloomV2.Contexts
{
    public class ImageContext : DbContext
    {
        public ImageContext(DbContextOptions<ImageContext> options) : base(options)
        {
        }

        public DbSet<ImageEntity> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ImageEntity>()
                .Property(i => i.UserId)
                .IsRequired();

            modelBuilder.Entity<ImageEntity>()
                .HasOne<UserEntity>()
                .WithMany(u => u.Images)
                .HasForeignKey(i => i.UserId);

            
        }

    }
}
