using GameForum.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameForum.DAL
{
    public class ForumDbContext : IdentityDbContext<ApplicationUser>
    {
        public ForumDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostLike> PostLikes { get; set; }
        public DbSet<ReplyLike> ReplyLikes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedUsers(builder);
            SeedRoles(builder);
            SeedUserRoles(builder);
            SeedPostCategories(builder);
            SeedPosts(builder);
            SeedReplies(builder);
            SeedPostLikes(builder);
            SeedReplyLikes(builder);
        }

        private static void SeedReplyLikes(ModelBuilder builder)
        {
            builder.Entity<ReplyLike>().HasData(
                new ReplyLike { Id = 1, ReplyId = 1, UserId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce" },
                new ReplyLike { Id = 2, ReplyId = 1, UserId = "f895175a-5bd7-4a95-8ffd-2be14fd3e787" },
                new ReplyLike { Id = 3, ReplyId = 2, UserId = "413d708c-623c-4be6-af1b-a52e7f120046" }
                );
        }

        private static void SeedPostLikes(ModelBuilder builder)
        {
            builder.Entity<PostLike>().HasData(
                new PostLike { Id = 1, PostId = 1, UserId = "f895175a-5bd7-4a95-8ffd-2be14fd3e787" },
                new PostLike { Id = 2, PostId = 1, UserId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce" },
                new PostLike { Id = 3, PostId = 3, UserId = "f895175a-5bd7-4a95-8ffd-2be14fd3e787" }
                );
        }

        private static void SeedReplies(ModelBuilder builder)
        {
            builder.Entity<Reply>().HasData(
                new Reply
                {
                    Id = 1,
                    PostId = 1,
                    AuthorID = "413d708c-623c-4be6-af1b-a52e7f120046",
                    DateCreated = DateTime.Now.AddMinutes(-32),
                    Content = "Can’t say anything but yes we do",
                },
                new Reply
                {
                    Id = 2,
                    PostId = 1,
                    AuthorID = "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                    DateCreated = DateTime.Now.AddMinutes(-15),
                    Content = "As long as hot pink is an available color for everything.",
                },
                new Reply
                {
                    Id = 3,
                    PostId = 2,
                    AuthorID = "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                    DateCreated = DateTime.Now.AddMinutes(-7),
                    Content = "They love making money / saving money so they should just start removing majority of low pop realms and freely transfer the remaining players to the remaining low pop realms. This way they spend less money on servers."
                }
            );
        }

        private static void SeedPostCategories(ModelBuilder builder)
        {
            builder.Entity<PostCategory>().HasData(
                new PostCategory { Id = 1, Name = "General Discussion", Description = "Discuss all things related." },
                new PostCategory { Id = 2, Name = "Gameplay", Description = "Gameplay discussion for the game." },
                new PostCategory { Id = 3, Name = "Development", Description = "Discuss our in-development content." },
                new PostCategory { Id = 4, Name = "Off-Topic", Description = "For all your non-game related discussions." },
                new PostCategory { Id = 5, Name = "Support", Description = "Problem installing? In-game or account issues? Reporting bugs? Come and join us here in Support." }
                );
        }

        private static void SeedPosts(ModelBuilder builder)
        {
            builder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    AuthorId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                    CategoryId = 1,
                    Title = "We Need Armor Dyes",
                    Content = "There have been so many awesome armor sets available in the game that I’ve passed up because the color palates didn’t fit the look I was going for. Game really needs to allow the player to customize their armor with armor dyes. Why is this not a thing yet?",
                    DateCreated = DateTime.Now.AddHours(-1),
                }
            );
            builder.Entity<Post>().HasData(
                new Post
                {
                    Id = 2,
                    AuthorId = "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                    CategoryId = 1,
                    Title = "Need a New Server",
                    Content = "So my server is pretty much dead, it’s combined with a bunch of other servers but yet I can’t find a guild that isn’t almost full with 90% of people offline all the time. Where would I find a good server to roll on and find a guild?\n\rNot sure if this is the right location for this post, if it isn’t just let me know where to post it and I’ll post it there.",
                    DateCreated = DateTime.Now.AddHours(-5),
                }
            );
            builder.Entity<Post>().HasData(
                new Post
                {
                    Id = 3,
                    AuthorId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                    CategoryId = 2,
                    Title = "Tank Aggro",
                    Content = "Tank aggro this xpac has felt awful for me. I strongly dislike the idea of having to fight my dps for aggro on every pack of mobs that they have cds on. This gets significantly worse for when I swap between my main and the other 3 tanks that I currently run. When I swap to a dps spec and join a group I always inspect the tank now to see if I am going to be the one ripping aggro when I have cds up. These of course are the problems that arise as I do my m+ for the week and not really during raiding which has its own frustrations. Fighting with my co-tank for aggro is also just a giant pain in the butt. I personally derive zero enjoyment from all the aggro issues I encounter this xpac and would like to see the aggro gen of tanks go way up and and maybe some kind of bonus aggro in tank spec if you are currently tanking so I don;t have to constantly afk when I pop too much dmg verses my co-tank or vice versa.",
                    DateCreated = DateTime.Now.AddHours(-2),
                }
            );
            builder.Entity<Post>().HasData(
                new Post
                {
                    Id = 4,
                    AuthorId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                    CategoryId = 3,
                    Title = "Can’t login",
                    Content = "Character is stuck falling. I have done a ton of stuff and do not want to delete.",
                    DateCreated = DateTime.Now.AddDays(-2),
                }
            );
        }

        private static void SeedUsers(ModelBuilder builder)
        {
            var admin = new ApplicationUser()
            {
                Id = "e629ed86-01f3-45f2-a5e2-af6913bf20b4",
                UserName = "Admin",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            passwordHasher.HashPassword(admin, "Admin*123");

            builder.Entity<ApplicationUser>().HasData(admin);

            var userJohn = new ApplicationUser()
            {
                Id = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                UserName = "John123",
                Email = "john123@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };

            passwordHasher.HashPassword(userJohn, "JohnJohn*123");

            builder.Entity<ApplicationUser>().HasData(userJohn);

            var userAnn = new ApplicationUser()
            {
                Id = "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                UserName = "Ann123",
                Email = "ann123@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };

            passwordHasher.HashPassword(userAnn, "AnnAnn*123");

            builder.Entity<ApplicationUser>().HasData(userAnn);

            var userMark = new ApplicationUser()
            {
                Id = "413d708c-623c-4be6-af1b-a52e7f120046",
                UserName = "Mark123",
                Email = "mark123@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };

            passwordHasher.HashPassword(userMark, "MarkMark*123");

            builder.Entity<ApplicationUser>().HasData(userMark);
        }

        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "9d6c5b06-d16c-43aa-939f-b2c0e6a9b031", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "ee6e369d-36f8-4220-943a-d42f680c2098", Name = "User", ConcurrencyStamp = "2", NormalizedName = "Standard User" }
                );
        }

        private static void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "9d6c5b06-d16c-43aa-939f-b2c0e6a9b031", UserId = "e629ed86-01f3-45f2-a5e2-af6913bf20b4" },
                new IdentityUserRole<string>() { RoleId = "ee6e369d-36f8-4220-943a-d42f680c2098", UserId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce" },
                new IdentityUserRole<string>() { RoleId = "ee6e369d-36f8-4220-943a-d42f680c2098", UserId = "f895175a-5bd7-4a95-8ffd-2be14fd3e787" },
                new IdentityUserRole<string>() { RoleId = "ee6e369d-36f8-4220-943a-d42f680c2098", UserId = "413d708c-623c-4be6-af1b-a52e7f120046" }
                );
        }
    }
}
