using GameForum.Helper;
using GameForum.Model;

namespace GameForum.ViewModel
{
    public class ReplyViewModel
    {
        public ReplyViewModel(Reply reply)
        {
            Id = reply.Id;
            Content = reply.Content;
            LastActivity = Activity.FromDates(reply.DateCreated, reply.DateEdited);
            Author = reply.Author;
            LikeCount = reply.Likes.Count;
        }
        public int Id { get; set; }
        public string Content { get; set; }
        public string LastActivity { get; set; }
        public Post Post { get; set; }
        public ApplicationUser Author { get; set; }
        public int LikeCount { get; set; }
    }
}
