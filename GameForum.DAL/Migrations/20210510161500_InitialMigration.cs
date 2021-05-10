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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    DateEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    DateEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    { "e629ed86-01f3-45f2-a5e2-af6913bf20b4", 0, "6738fff0-e289-4e9f-8f5e-9187ef22f24d", "admin@gmail.com", false, false, null, null, null, null, "1234567890", false, "3827baf1-c71a-4581-b114-5b34cee01ebf", false, "Admin" },
                    { "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce", 0, "59cb368c-8d29-416f-be6c-4e235742342c", "john123@gmail.com", false, false, null, null, null, null, "1234567890", false, "f07a4865-1c01-43ef-b3df-42a73cec3683", false, "John123" },
                    { "f895175a-5bd7-4a95-8ffd-2be14fd3e787", 0, "6679f42c-b8c9-41e4-b76d-14bc91813e8d", "ann123@gmail.com", false, false, null, null, null, null, "1234567890", false, "e60dad48-d072-4e8e-a6e4-ed58bdd97f99", false, "Ann123" },
                    { "413d708c-623c-4be6-af1b-a52e7f120046", 0, "a3f48dbb-1a62-4345-a6e2-6d0aa06f695f", "mark123@gmail.com", false, false, null, null, null, null, "1234567890", false, "f650f1d2-2ade-4875-b514-9f4d81f2174e", false, "Mark123" }
                });

            migrationBuilder.InsertData(
                table: "PostCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "General Discussion" },
                    { 2, "Gameplay" },
                    { 3, "Development" },
                    { 4, "Off-Topic" },
                    { 5, "Support" }
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
                    { 1, "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce", 1, "There have been so many awesome armor sets available in the game that I’ve passed up because the color palates didn’t fit the look I was going for. Game really needs to allow the player to customize their armor with armor dyes. Why is this not a thing yet?", new DateTime(2021, 5, 10, 17, 14, 59, 701, DateTimeKind.Local).AddTicks(8165), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We Need Armor Dyes" },
                    { 2, "f895175a-5bd7-4a95-8ffd-2be14fd3e787", 1, "So my server is pretty much dead, it’s combined with a bunch of other servers but yet I can’t find a guild that isn’t almost full with 90% of people offline all the time. Where would I find a good server to roll on and find a guild?\n\rNot sure if this is the right location for this post, if it isn’t just let me know where to post it and I’ll post it there.", new DateTime(2021, 5, 10, 13, 14, 59, 703, DateTimeKind.Local).AddTicks(8539), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Need a New Server" },
                    { 3, "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce", 2, "Tank aggro this xpac has felt awful for me. I strongly dislike the idea of having to fight my dps for aggro on every pack of mobs that they have cds on. This gets significantly worse for when I swap between my main and the other 3 tanks that I currently run. When I swap to a dps spec and join a group I always inspect the tank now to see if I am going to be the one ripping aggro when I have cds up. These of course are the problems that arise as I do my m+ for the week and not really during raiding which has its own frustrations. Fighting with my co-tank for aggro is also just a giant pain in the butt. I personally derive zero enjoyment from all the aggro issues I encounter this xpac and would like to see the aggro gen of tanks go way up and and maybe some kind of bonus aggro in tank spec if you are currently tanking so I don;t have to constantly afk when I pop too much dmg verses my co-tank or vice versa.", new DateTime(2021, 5, 10, 16, 14, 59, 703, DateTimeKind.Local).AddTicks(8593), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tank Aggro" },
                    { 4, "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce", 3, "Character is stuck falling. I have done a ton of stuff and do not want to delete.", new DateTime(2021, 5, 8, 18, 14, 59, 703, DateTimeKind.Local).AddTicks(8613), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Can’t login" }
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
                    { 1, "413d708c-623c-4be6-af1b-a52e7f120046", "Can’t say anything but yes we do", new DateTime(2021, 5, 10, 17, 42, 59, 704, DateTimeKind.Local).AddTicks(2925), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "f895175a-5bd7-4a95-8ffd-2be14fd3e787", "As long as hot pink is an available color for everything.", new DateTime(2021, 5, 10, 17, 59, 59, 704, DateTimeKind.Local).AddTicks(3717), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "f895175a-5bd7-4a95-8ffd-2be14fd3e787", "They love making money / saving money so they should just start removing majority of low pop realms and freely transfer the remaining players to the remaining low pop realms. This way they spend less money on servers.", new DateTime(2021, 5, 10, 18, 7, 59, 704, DateTimeKind.Local).AddTicks(3729), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
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
