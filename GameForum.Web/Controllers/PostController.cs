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
            return View(new CategoryPostsViewModel(category, posts));
        }
        [Route("{id}")]
        public async Task<IActionResult> Post(int id)
        {
            var post = await _dbContext.Posts
                .Include(p => p.Category)
                .Include(p => p.Author)
                .Include(p => p.Likes)
                .Include(p => p.Replies)
                    .ThenInclude(r => r.Likes)
                .Include(p => p.Replies)
                    .ThenInclude(r => r.Author)
                .FirstOrDefaultAsync(p => p.Id == id);
            return post is null ? NotFound() : View(new PostViewModel(post));
        }
    }
}
