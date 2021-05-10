using System.ComponentModel.DataAnnotations;

namespace GameForum.Model
{
    public class PostLike
    {
        [Key]
        public int Id { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
