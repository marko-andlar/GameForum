using GameForum.Helper;
using GameForum.Model;
using System.Collections.Generic;
using System.Linq;

namespace GameForum.ViewModel
{
    public class PostViewModel
    {
        public PostViewModel(Post post, ApplicationUser user = null)
        {
            Id = post.Id;
            Title = post.Title;
            Content = post.Content;
            LastActivity = Activity.FromDates(post.DateCreated, post.DateEdited);
            Author = post.Author;
            Category = post.Category;
            FillReplies(post.Replies, user);
            Likes = post.Likes;
            LikeCount = post.Likes is null ? 0 : post.Likes.Count;
            if (user is not null)
                Liked = Likes.FirstOrDefault(l => l.UserId == user.Id) is not null;
        }

        private void FillReplies(ICollection<Reply> replies, ApplicationUser user)
        {
            Replies = new List<ReplyViewModel>();
            foreach (var reply in replies)
            {
                Replies.Add(new ReplyViewModel(reply, user));
            }
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string LastActivity { get; set; }
        public ApplicationUser Author { get; set; }
        public PostCategory Category { get; set; }
        public List<ReplyViewModel> Replies { get; set; }
        public ICollection<PostLike> Likes { get; set; }
        public int LikeCount { get; set; }
        public bool Liked { get; set; }
    }
}