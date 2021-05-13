﻿// <auto-generated />
using System;
using GameForum.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameForum.DAL.Migrations
{
    [DbContext(typeof(ForumDbContext))]
    [Migration("20210513073111_NullableEditDateTime")]
    partial class NullableEditDateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameForum.Model.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "e629ed86-01f3-45f2-a5e2-af6913bf20b4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "32a80abf-9ccb-4844-a12b-cb13238ed6bc",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5d18a408-63fd-40fa-98cb-12c4f608340d",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "790f79dd-f8d2-439c-a8dd-89bca80c41c3",
                            Email = "john123@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7fd9741e-d96c-4e3b-9ad1-174d13a0a980",
                            TwoFactorEnabled = false,
                            UserName = "John123"
                        },
                        new
                        {
                            Id = "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d654cbde-98a5-44d9-8fc2-b2f0ea8d2e4f",
                            Email = "ann123@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "49899c38-cf7f-4659-881d-25471179b2c4",
                            TwoFactorEnabled = false,
                            UserName = "Ann123"
                        },
                        new
                        {
                            Id = "413d708c-623c-4be6-af1b-a52e7f120046",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "16898aae-2b7a-48dd-ba34-c728d54b71d6",
                            Email = "mark123@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f0536d71-e496-4c1b-a98c-123aedc677e1",
                            TwoFactorEnabled = false,
                            UserName = "Mark123"
                        });
                });

            modelBuilder.Entity("GameForum.Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                            CategoryId = 1,
                            Content = "There have been so many awesome armor sets available in the game that I’ve passed up because the color palates didn’t fit the look I was going for. Game really needs to allow the player to customize their armor with armor dyes. Why is this not a thing yet?",
                            DateCreated = new DateTime(2021, 5, 13, 8, 31, 10, 945, DateTimeKind.Local).AddTicks(6420),
                            Title = "We Need Armor Dyes"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                            CategoryId = 1,
                            Content = "So my server is pretty much dead, it’s combined with a bunch of other servers but yet I can’t find a guild that isn’t almost full with 90% of people offline all the time. Where would I find a good server to roll on and find a guild?\n\rNot sure if this is the right location for this post, if it isn’t just let me know where to post it and I’ll post it there.",
                            DateCreated = new DateTime(2021, 5, 13, 4, 31, 10, 947, DateTimeKind.Local).AddTicks(6451),
                            Title = "Need a New Server"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                            CategoryId = 2,
                            Content = "Tank aggro this xpac has felt awful for me. I strongly dislike the idea of having to fight my dps for aggro on every pack of mobs that they have cds on. This gets significantly worse for when I swap between my main and the other 3 tanks that I currently run. When I swap to a dps spec and join a group I always inspect the tank now to see if I am going to be the one ripping aggro when I have cds up. These of course are the problems that arise as I do my m+ for the week and not really during raiding which has its own frustrations. Fighting with my co-tank for aggro is also just a giant pain in the butt. I personally derive zero enjoyment from all the aggro issues I encounter this xpac and would like to see the aggro gen of tanks go way up and and maybe some kind of bonus aggro in tank spec if you are currently tanking so I don;t have to constantly afk when I pop too much dmg verses my co-tank or vice versa.",
                            DateCreated = new DateTime(2021, 5, 13, 7, 31, 10, 947, DateTimeKind.Local).AddTicks(6499),
                            Title = "Tank Aggro"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                            CategoryId = 3,
                            Content = "Character is stuck falling. I have done a ton of stuff and do not want to delete.",
                            DateCreated = new DateTime(2021, 5, 11, 9, 31, 10, 947, DateTimeKind.Local).AddTicks(6519),
                            Title = "Can’t login"
                        });
                });

            modelBuilder.Entity("GameForum.Model.PostCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PostCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Discuss all things related.",
                            Name = "General Discussion"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Gameplay discussion for the game.",
                            Name = "Gameplay"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Discuss our in-development content.",
                            Name = "Development"
                        },
                        new
                        {
                            Id = 4,
                            Description = "For all your non-game related discussions.",
                            Name = "Off-Topic"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Problem installing? In-game or account issues? Reporting bugs? Come and join us here in Support.",
                            Name = "Support"
                        });
                });

            modelBuilder.Entity("GameForum.Model.PostLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostLikes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PostId = 1,
                            UserId = "f895175a-5bd7-4a95-8ffd-2be14fd3e787"
                        },
                        new
                        {
                            Id = 2,
                            PostId = 1,
                            UserId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce"
                        },
                        new
                        {
                            Id = 3,
                            PostId = 3,
                            UserId = "f895175a-5bd7-4a95-8ffd-2be14fd3e787"
                        });
                });

            modelBuilder.Entity("GameForum.Model.Reply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateEdited")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorID");

                    b.HasIndex("PostId");

                    b.ToTable("Replies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorID = "413d708c-623c-4be6-af1b-a52e7f120046",
                            Content = "Can’t say anything but yes we do",
                            DateCreated = new DateTime(2021, 5, 13, 8, 59, 10, 948, DateTimeKind.Local).AddTicks(636),
                            PostId = 1
                        },
                        new
                        {
                            Id = 2,
                            AuthorID = "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                            Content = "As long as hot pink is an available color for everything.",
                            DateCreated = new DateTime(2021, 5, 13, 9, 16, 10, 948, DateTimeKind.Local).AddTicks(1420),
                            PostId = 1
                        },
                        new
                        {
                            Id = 3,
                            AuthorID = "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                            Content = "They love making money / saving money so they should just start removing majority of low pop realms and freely transfer the remaining players to the remaining low pop realms. This way they spend less money on servers.",
                            DateCreated = new DateTime(2021, 5, 13, 9, 24, 10, 948, DateTimeKind.Local).AddTicks(1432),
                            PostId = 2
                        });
                });

            modelBuilder.Entity("GameForum.Model.ReplyLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReplyId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ReplyId");

                    b.HasIndex("UserId");

                    b.ToTable("ReplyLikes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ReplyId = 1,
                            UserId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce"
                        },
                        new
                        {
                            Id = 2,
                            ReplyId = 1,
                            UserId = "f895175a-5bd7-4a95-8ffd-2be14fd3e787"
                        },
                        new
                        {
                            Id = 3,
                            ReplyId = 2,
                            UserId = "413d708c-623c-4be6-af1b-a52e7f120046"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "9d6c5b06-d16c-43aa-939f-b2c0e6a9b031",
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "ee6e369d-36f8-4220-943a-d42f680c2098",
                            ConcurrencyStamp = "2",
                            Name = "User",
                            NormalizedName = "Standard User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "e629ed86-01f3-45f2-a5e2-af6913bf20b4",
                            RoleId = "9d6c5b06-d16c-43aa-939f-b2c0e6a9b031"
                        },
                        new
                        {
                            UserId = "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                            RoleId = "ee6e369d-36f8-4220-943a-d42f680c2098"
                        },
                        new
                        {
                            UserId = "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                            RoleId = "ee6e369d-36f8-4220-943a-d42f680c2098"
                        },
                        new
                        {
                            UserId = "413d708c-623c-4be6-af1b-a52e7f120046",
                            RoleId = "ee6e369d-36f8-4220-943a-d42f680c2098"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GameForum.Model.Post", b =>
                {
                    b.HasOne("GameForum.Model.ApplicationUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameForum.Model.PostCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("GameForum.Model.PostLike", b =>
                {
                    b.HasOne("GameForum.Model.Post", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameForum.Model.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GameForum.Model.Reply", b =>
                {
                    b.HasOne("GameForum.Model.ApplicationUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameForum.Model.Post", "Post")
                        .WithMany("Replies")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("GameForum.Model.ReplyLike", b =>
                {
                    b.HasOne("GameForum.Model.Reply", "Reply")
                        .WithMany("Likes")
                        .HasForeignKey("ReplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameForum.Model.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reply");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GameForum.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GameForum.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameForum.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GameForum.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameForum.Model.Post", b =>
                {
                    b.Navigation("Likes");

                    b.Navigation("Replies");
                });

            modelBuilder.Entity("GameForum.Model.Reply", b =>
                {
                    b.Navigation("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}