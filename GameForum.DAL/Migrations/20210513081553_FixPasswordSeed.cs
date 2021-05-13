using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameForum.DAL.Migrations
{
    public partial class FixPasswordSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413d708c-623c-4be6-af1b-a52e7f120046",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32aae79b-33ee-40be-b683-6cc11c77f9d1", "AQAAAAEAACcQAAAAECPb8nv6I+vM9aMVbrzqUJNnSTVUu+l7E3KR84Lgg1ubzlpx4b5eqgbfn9bxOGyZEQ==", "cf036d1e-1399-4981-94df-6bc6bf89cd12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "467c89ec-4e6d-40e2-89e2-116b979fd14f", "AQAAAAEAACcQAAAAEGpLP6oQ1UHZPEZ6TRWpDVMpbwMPHaTehWPgMAQimUxZ0RTRyRHoFXqTPr3sNTtI6Q==", "ac97b719-9170-4cdf-8992-080ba78d7e40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e629ed86-01f3-45f2-a5e2-af6913bf20b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30d46c7d-4604-4eaa-a6e6-ee48d49d199c", "AQAAAAEAACcQAAAAEM6A0tw7uGB/7gw/oGBE981llUj82VuhEoAw6cSQqF/ZE4fAImtPRa2NBvWhaGNEcw==", "f5f05395-4a7c-455e-addd-48bedc05a16b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27b0683b-3dce-4a7b-aa3f-92b26baffa9e", "AQAAAAEAACcQAAAAEB4xrMT1zC8M5flxrSlJeTHRDJxgeWrSpcC8alOH0MotPK4NOaV8kYEckX2kktbJaA==", "40630993-394f-4ac1-935b-7d578ce4cdf2" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 9, 15, 52, 716, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 5, 15, 52, 718, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 8, 15, 52, 718, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 10, 15, 52, 718, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 9, 43, 52, 718, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 10, 0, 52, 718, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 10, 8, 52, 718, DateTimeKind.Local).AddTicks(7504));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413d708c-623c-4be6-af1b-a52e7f120046",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16898aae-2b7a-48dd-ba34-c728d54b71d6", null, "f0536d71-e496-4c1b-a98c-123aedc677e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "790f79dd-f8d2-439c-a8dd-89bca80c41c3", null, "7fd9741e-d96c-4e3b-9ad1-174d13a0a980" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e629ed86-01f3-45f2-a5e2-af6913bf20b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32a80abf-9ccb-4844-a12b-cb13238ed6bc", null, "5d18a408-63fd-40fa-98cb-12c4f608340d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d654cbde-98a5-44d9-8fc2-b2f0ea8d2e4f", null, "49899c38-cf7f-4659-881d-25471179b2c4" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 8, 31, 10, 945, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 4, 31, 10, 947, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 7, 31, 10, 947, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 9, 31, 10, 947, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 8, 59, 10, 948, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 9, 16, 10, 948, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 13, 9, 24, 10, 948, DateTimeKind.Local).AddTicks(1432));
        }
    }
}
