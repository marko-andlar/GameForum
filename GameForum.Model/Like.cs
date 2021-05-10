using System.ComponentModel.DataAnnotations;

namespace GameForum.Model
{
    public class Like
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
