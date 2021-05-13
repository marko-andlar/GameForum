using GameForum.Helper;
using GameForum.Model;
using System.Collections.Generic;
using System.Linq;

namespace GameForum.ViewModel
{
    public class ReplyViewModel
    {
        public ReplyViewModel(Reply reply, ApplicationUser user = null)
        {
            Id = reply.Id;
            Content = reply.Content;
            LastActivity = Activity.FromDates(reply.DateCreated, reply.DateEdited);
            Author = reply.Author;
            Likes = reply.Likes;
            LikeCount = reply.Likes is null ? 0 : reply.Likes.Count;
            if (user is not null)
                Liked = Likes.FirstOrDefault(l => l.UserId == user.Id) is not null;
        }
        public int Id { get; set; }
        public string Content { get; set; }
        public string LastActivity { get; set; }
        public Post Post { get; set; }
        public ApplicationUser Author { get; set; }
        public ICollection<ReplyLike> Likes { get; set; }
        public int LikeCount { get; set; }
        public bool Liked { get; set; }
    }
}
