using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameForum.DAL.Migrations
{
    public partial class AddCategoryDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PostCategories",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413d708c-623c-4be6-af1b-a52e7f120046",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86caea62-a32e-4179-9325-88260a6acb82", "937a38ec-d59f-4019-b4b9-fea449e8d605" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22bcdaea-42a6-4e8a-827f-55f3ef7babdd", "c96f623b-9d6f-4ba1-aa96-7dd5e3199f99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e629ed86-01f3-45f2-a5e2-af6913bf20b4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a13303d0-493d-4c96-b2af-bd7b2fb5333d", "8c720c37-b01a-4c30-ad09-7b7256dcba50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b578723a-5ba8-4d2e-bf5d-20efbc3641d6", "d62325c0-f947-4ef2-a8c5-f77d36811bdc" });

            migrationBuilder.UpdateData(
                table: "PostCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Discuss all things related.");

            migrationBuilder.UpdateData(
                table: "PostCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Gameplay discussion for the game.");

            migrationBuilder.UpdateData(
                table: "PostCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Discuss our in-development content.");

            migrationBuilder.UpdateData(
                table: "PostCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "For all your non-game related discussions.");

            migrationBuilder.UpdateData(
                table: "PostCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Problem installing? In-game or account issues? Reporting bugs? Come and join us here in Support.");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 15, 9, 47, 97, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 11, 9, 47, 99, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 14, 9, 47, 99, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 9, 16, 9, 47, 99, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 15, 37, 47, 100, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 15, 54, 47, 100, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 16, 2, 47, 100, DateTimeKind.Local).AddTicks(1511));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PostCategories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413d708c-623c-4be6-af1b-a52e7f120046",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a3f48dbb-1a62-4345-a6e2-6d0aa06f695f", "f650f1d2-2ade-4875-b514-9f4d81f2174e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59cb368c-8d29-416f-be6c-4e235742342c", "f07a4865-1c01-43ef-b3df-42a73cec3683" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e629ed86-01f3-45f2-a5e2-af6913bf20b4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6738fff0-e289-4e9f-8f5e-9187ef22f24d", "3827baf1-c71a-4581-b114-5b34cee01ebf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6679f42c-b8c9-41e4-b76d-14bc91813e8d", "e60dad48-d072-4e8e-a6e4-ed58bdd97f99" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 17, 14, 59, 701, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 13, 14, 59, 703, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 16, 14, 59, 703, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 18, 14, 59, 703, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 17, 42, 59, 704, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 17, 59, 59, 704, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 10, 18, 7, 59, 704, DateTimeKind.Local).AddTicks(3729));
        }
    }
}
