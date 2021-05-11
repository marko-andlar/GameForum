using System.ComponentModel.DataAnnotations;

namespace GameForum.Model
{
    public class PostCategory
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [Required, StringLength(200, MinimumLength = 3)]
        public string Description { get; set; }
    }
}
