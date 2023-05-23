namespace GalleryGloomV2.Models.Entities
{
    public class ImageEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public IFormFile ImageFile { get; set; } = null!;

        public Guid UserId { get; set; } // Foreign key to UserEntity

    }
}
