using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GameForum.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEdited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_PostCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "PostCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostLikes_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEdited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    AuthorID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Replies_AspNetUsers_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Replies_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ReplyLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReplyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReplyLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReplyLikes_Replies_ReplyId",
                        column: x => x.ReplyId,
                        principalTable: "Replies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9d6c5b06-d16c-43aa-939f-b2c0e6a9b031", "1", "Admin", "Admin" },
                    { "ee6e369d-36f8-4220-943a-d42f680c2098", "2", "User", "Standard User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e629ed86-01f3-45f2-a5e2-af6913bf20b4", 0, "89396fa2-0fc4-490a-a5ac-169b898f505a", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEO64oXBTjdz2JRdcdOmhNx5Mxf5xRNA/+E8A9mfVg7W/MVwux99Ft0IutGYcJE9seQ==", "1234567890", false, "4976d8f3-fc0b-42aa-86f1-bce0a7ec4cf0", false, "Admin" },
                    { "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce", 0, "24fa0ae1-f552-45a7-8910-27cf3df205f5", "john123@gmail.com", true, false, null, "JOHN123@GMAIL.COM", "JOHN123", "AQAAAAEAACcQAAAAELi/l/UY0PyGFYqUj6OSaQt8EK6uLvT9XD+vVCxPKxYM/7KUGBHGC7qdTF54QU//nQ==", "1234567890", false, "dcec1d83-e117-402f-b51f-38c55c07c34b", false, "John123" },
                    { "f895175a-5bd7-4a95-8ffd-2be14fd3e787", 0, "4f14c72a-f8c5-409f-8a64-5069ba89367e", "ann123@gmail.com", true, false, null, "ANN123@GMAIL.COM", "ANN123", "AQAAAAEAACcQAAAAEPq3n6ZiRsamKwZxHgFTdiBfVtGOJskatpKTuYMNMlJcve0VdMST5NStLdC7g4Q7Mg==", "1234567890", false, "8ab1273b-8199-4b0a-b7dd-5aaf47d3abdd", false, "Ann123" },
                    { "413d708c-623c-4be6-af1b-a52e7f120046", 0, "1b6451fb-61d2-49c9-89b3-31e6f5d67b2a", "mark123@gmail.com", true, false, null, "MARK123@GMAIL.COM", "MARK123", "AQAAAAEAACcQAAAAEOEGBscI2gd5mD9l1cqgWl54v27jFVXO8Q8F168FsxXZpmy/eUoyYZqWTbKTNL+v0Q==", "1234567890", false, "3186ed79-d1d3-4201-8b44-57083daf2712", false, "Mark123" }
                });

            migrationBuilder.InsertData(
                table: "PostCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Discuss all things related.", "General Discussion" },
                    { 2, "Gameplay discussion for the game.", "Gameplay" },
                    { 3, "Discuss our in-development content.", "Development" },
                    { 4, "For all your non-game related discussions.", "Off-Topic" },
                    { 5, "Problem installing? In-game or account issues? Reporting bugs? Come and join us here in Support.", "Support" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9d6c5b06-d16c-43aa-939f-b2c0e6a9b031", "e629ed86-01f3-45f2-a5e2-af6913bf20b4" },
                    { "ee6e369d-36f8-4220-943a-d42f680c2098", "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce" },
                    { "ee6e369d-36f8-4220-943a-d42f680c2098", "f895175a-5bd7-4a95-8ffd-2be14fd3e787" },
                    { "ee6e369d-36f8-4220-943a-d42f680c2098", "413d708c-623c-4be6-af1b-a52e7f120046" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Content", "DateCreated", "DateEdited", "Title" },
                values: new object[,]
                {
                    { 1, "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce", 1, "There have been so many awesome armor sets available in the game that I’ve passed up because the color palates didn’t fit the look I was going for. Game really needs to allow the player to customize their armor with armor dyes. Why is this not a thing yet?", new DateTime(2021, 5, 13, 10, 56, 48, 48, DateTimeKind.Local).AddTicks(8262), null, "We Need Armor Dyes" },
                    { 2, "f895175a-5bd7-4a95-8ffd-2be14fd3e787", 1, "So my server is pretty much dead, it’s combined with a bunch of other servers but yet I can’t find a guild that isn’t almost full with 90% of people offline all the time. Where would I find a good server to roll on and find a guild?\n\rNot sure if this is the right location for this post, if it isn’t just let me know where to post it and I’ll post it there.", new DateTime(2021, 5, 13, 6, 56, 48, 50, DateTimeKind.Local).AddTicks(8305), null, "Need a New Server" },
                    { 3, "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce", 2, "Tank aggro this xpac has felt awful for me. I strongly dislike the idea of having to fight my dps for aggro on every pack of mobs that they have cds on. This gets significantly worse for when I swap between my main and the other 3 tanks that I currently run. When I swap to a dps spec and join a group I always inspect the tank now to see if I am going to be the one ripping aggro when I have cds up. These of course are the problems that arise as I do my m+ for the week and not really during raiding which has its own frustrations. Fighting with my co-tank for aggro is also just a giant pain in the butt. I personally derive zero enjoyment from all the aggro issues I encounter this xpac and would like to see the aggro gen of tanks go way up and and maybe some kind of bonus aggro in tank spec if you are currently tanking so I don;t have to constantly afk when I pop too much dmg verses my co-tank or vice versa.", new DateTime(2021, 5, 13, 9, 56, 48, 50, DateTimeKind.Local).AddTicks(8354), null, "Tank Aggro" },
                    { 4, "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce", 3, "Character is stuck falling. I have done a ton of stuff and do not want to delete.", new DateTime(2021, 5, 11, 11, 56, 48, 50, DateTimeKind.Local).AddTicks(8374), null, "Can’t login" }
                });

            migrationBuilder.InsertData(
                table: "PostLikes",
                columns: new[] { "Id", "PostId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "f895175a-5bd7-4a95-8ffd-2be14fd3e787" },
                    { 2, 1, "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce" },
                    { 3, 3, "f895175a-5bd7-4a95-8ffd-2be14fd3e787" }
                });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "Id", "AuthorID", "Content", "DateCreated", "DateEdited", "PostId" },
                values: new object[,]
                {
                    { 1, "413d708c-623c-4be6-af1b-a52e7f120046", "Can’t say anything but yes we do", new DateTime(2021, 5, 13, 11, 24, 48, 51, DateTimeKind.Local).AddTicks(2783), null, 1 },
                    { 2, "f895175a-5bd7-4a95-8ffd-2be14fd3e787", "As long as hot pink is an available color for everything.", new DateTime(2021, 5, 13, 11, 41, 48, 51, DateTimeKind.Local).AddTicks(3612), null, 1 },
                    { 3, "f895175a-5bd7-4a95-8ffd-2be14fd3e787", "They love making money / saving money so they should just start removing majority of low pop realms and freely transfer the remaining players to the remaining low pop realms. This way they spend less money on servers.", new DateTime(2021, 5, 13, 11, 49, 48, 51, DateTimeKind.Local).AddTicks(3624), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "ReplyLikes",
                columns: new[] { "Id", "ReplyId", "UserId" },
                values: new object[] { 1, 1, "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce" });

            migrationBuilder.InsertData(
                table: "ReplyLikes",
                columns: new[] { "Id", "ReplyId", "UserId" },
                values: new object[] { 2, 1, "f895175a-5bd7-4a95-8ffd-2be14fd3e787" });

            migrationBuilder.InsertData(
                table: "ReplyLikes",
                columns: new[] { "Id", "ReplyId", "UserId" },
                values: new object[] { 3, 2, "413d708c-623c-4be6-af1b-a52e7f120046" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_PostId",
                table: "PostLikes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_UserId",
                table: "PostLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_AuthorID",
                table: "Replies",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_PostId",
                table: "Replies",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyLikes_ReplyId",
                table: "ReplyLikes",
                column: "ReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyLikes_UserId",
                table: "ReplyLikes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PostLikes");

            migrationBuilder.DropTable(
                name: "ReplyLikes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PostCategories");
        }
    }
}
