using System.ComponentModel.DataAnnotations;

namespace GameForum.Model
{
    public class ReplyLike
    {
        [Key]
        public int Id { get; set; }
        public int ReplyId { get; set; }
        public Reply Reply { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
