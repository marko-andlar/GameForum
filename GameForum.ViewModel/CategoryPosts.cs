using GameForum.Model;
using System.Collections.Generic;

namespace GameForum.ViewModel
{
    public class CategoryPosts
    {
        public PostCategory Category { get; set; }
        public List<Post> Posts { get; set; }
    }
}
