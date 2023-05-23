namespace GalleryGloomV2.Models.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; } = null!;

        public ICollection<ImageEntity> Images { get; set; } // Collection navigation property to ImageEntity
    }
}
