using Microsoft.AspNetCore.Identity;

namespace GameForum.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string CustomTag { get; set; }
    }
}
