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
        [Required]
        public DateTime DateEdited { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public int Author { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public PostCategory Category { get; set; }
        public List<Like> Likes { get; set; }
        public List<Reply> Replies { get; set; }

    }
}
