using GameForum.Model;
using System.Collections.Generic;

namespace GameForum.ViewModel
{
    public class CategoryPostsViewModel
    {
        public CategoryPostsViewModel(PostCategory category, ICollection<Post> posts)
        {
            Category = category;
            Posts = new List<PostViewModel>();
            foreach (var post in posts)
            {
                Posts.Add(new PostViewModel(post));
            }
        }
        public PostCategory Category { get; set; }
        public List<PostViewModel> Posts { get; set; }
    }
}
