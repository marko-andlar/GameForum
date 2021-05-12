using GameForum.DAL;
using GameForum.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GameForum.Web.Controllers
{
    [Route("Post")]
    public class PostController : Controller
    {
        private ForumDbContext _dbContext;

        public PostController(ForumDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        [Route("Category/{categoryId}")]
        public async Task<IActionResult> Index(int categoryId)
        {
            var category = await _dbContext.PostCategories.FindAsync(categoryId);
            var posts = await _dbContext.Posts
                .Include(p => p.Author)
                .Include(p => p.Replies)
                .Where(p => p.CategoryId == categoryId)
                .ToListAsync();
            return View(new CategoryPosts { Category = category, Posts = posts });
        }
        [Route("{id}")]
        public async Task<IActionResult> Post(int id)
        {
            var post = await _dbContext.Posts.FindAsync(id);
            return post is null ? NotFound() : View(post);
        }
    }
}
