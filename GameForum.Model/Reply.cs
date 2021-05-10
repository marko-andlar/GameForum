using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameForum.Model
{
    public class Reply
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(3000, MinimumLength = 3)]
        public string Content { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public DateTime DateEdited { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        [Required]
        public string AuthorID { get; set; }
        public ApplicationUser Author { get; set; }
        public virtual ICollection<ReplyLike> Likes { get; set; }
    }
}
