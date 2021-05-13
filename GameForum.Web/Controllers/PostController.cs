using GameForum.DAL;
using GameForum.Model;
using GameForum.ViewModel;
using Microsoft.AspNetCore.Identity;
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
        private UserManager<ApplicationUser> _userManager;

        public PostController(ForumDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        [HttpGet]
        [Route("Category/{categoryId}")]
        public async Task<IActionResult> Index(int categoryId)
        {
            var category = await _dbContext.PostCategories.FindAsync(categoryId);
            var posts = await _dbContext.Posts
                .Include(p => p.Author)
                .Include(p => p.Replies)
                .Include(p => p.Likes)
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
            var user = await _userManager.GetUserAsync(User);
            return post is null ? NotFound() : View(new PostViewModel(post, user));
        }
        [HttpPost]
        [Route("LikePost/{id}")]
        public async Task<IActionResult> LikePost(int id)
        {
            var post = await _dbContext.Posts
                .Include(p => p.Likes)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (post is null)
                return NotFound();
            var user = await _userManager.GetUserAsync(User);
            if (user is null)
                return StatusCode(500);
            var userId = user.Id;
            var like = post.Likes.FirstOrDefault(l => l.UserId == userId);
            if (like is not null)
            {
                post.Likes.Remove(like);
                var ok = await _dbContext.SaveChangesAsync();
                if (ok == 0)
                    return StatusCode(500);
                return Ok(-1);
            }
            post.Likes.Add(new Model.PostLike { PostId = id, UserId = userId });
            var result = await _dbContext.SaveChangesAsync();
            if (result == 0)
                return StatusCode(500);
            return Ok(1);
        }
        [HttpPost]
        [Route("LikeReply/{id}")]
        public async Task<IActionResult> LikeReply(int id)
        {
            var reply = await _dbContext.Replies
                .Include(p => p.Likes)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (reply is null)
                return NotFound();
            var user = await _userManager.GetUserAsync(User);
            if (user is null)
                return StatusCode(500);
            var userId = user.Id;
            var like = reply.Likes.FirstOrDefault(l => l.UserId == userId);
            if (like is not null)
            {
                reply.Likes.Remove(like);
                var ok = await _dbContext.SaveChangesAsync();
                if (ok == 0)
                    return StatusCode(500);
                return Ok(-1);
            }
            reply.Likes.Add(new Model.ReplyLike { ReplyId = id, UserId = userId });
            var result = await _dbContext.SaveChangesAsync();
            if (result == 0)
                return StatusCode(500);
            return Ok(1);
        }
    }
}
