using GameForum.Helper;
using GameForum.Model;
using System.Collections.Generic;

namespace GameForum.ViewModel
{
    public class PostViewModel
    {
        public PostViewModel(Post post)
        {
            Id = post.Id;
            Title = post.Title;
            Content = post.Content;
            LastActivity = Activity.FromDates(post.DateCreated, post.DateEdited);
            Author = post.Author;
            Category = post.Category;
            FillReplies(post.Replies);
            LikeCount = post.Likes is null ? 0 : post.Likes.Count;
        }

        private void FillReplies(ICollection<Reply> replies)
        {
            Replies = new List<ReplyViewModel>();
            foreach (var reply in replies)
            {
                Replies.Add(new ReplyViewModel(reply));
            }
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string LastActivity { get; set; }
        public ApplicationUser Author { get; set; }
        public PostCategory Category { get; set; }
        public List<ReplyViewModel> Replies { get; set; }
        public int LikeCount { get; set; }
    }
}