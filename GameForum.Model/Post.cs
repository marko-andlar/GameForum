using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameForum.Model
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        [Required, StringLength(3000, MinimumLength = 3)]
        public string Content { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public DateTime DateEdited { get; set; }
        [Required]
        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public PostCategory Category { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
        public virtual ICollection<PostLike> Likes { get; set; }

    }
}
