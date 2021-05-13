using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameForum.DAL.Migrations
{
    public partial class NullableEditDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEdited",
                table: "Replies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEdited",
                table: "Posts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413d708c-623c-4be6-af1b-a52e7f120046",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16898aae-2b7a-48dd-ba34-c728d54b71d6", "f0536d71-e496-4c1b-a98c-123aedc677e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a3836ea-2188-49c1-99c9-3c7fb9e0d8ce",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "790f79dd-f8d2-439c-a8dd-89bca80c41c3", "7fd9741e-d96c-4e3b-9ad1-174d13a0a980" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e629ed86-01f3-45f2-a5e2-af6913bf20b4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32a80abf-9ccb-4844-a12b-cb13238ed6bc", "5d18a408-63fd-40fa-98cb-12c4f608340d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f895175a-5bd7-4a95-8ffd-2be14fd3e787",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d654cbde-98a5-44d9-8fc2-b2f0ea8d2e4f", "49899c38-cf7f-4659-881d-25471179b2c4" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 13, 8, 31, 10, 945, DateTimeKind.Local).AddTicks(6420), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 13, 4, 31, 10, 947, DateTimeKind.Local).AddTicks(6451), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 13, 7, 31, 10, 947, DateTimeKind.Local).AddTicks(6499), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 11, 9, 31, 10, 947, DateTimeKind.Local).AddTicks(6519), null });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 13, 8, 59, 10, 948, DateTimeKind.Local).AddTicks(636), null });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 13, 9, 16, 10, 948, DateTimeKind.Local).AddTicks(1420), null });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 13, 9, 24, 10, 948, DateTimeKind.Local).AddTicks(1432), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEdited",
                table: "Replies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEdited",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 9, 47, 97, DateTimeKind.Local).AddTicks(3833), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 11, 11, 9, 47, 99, DateTimeKind.Local).AddTicks(6035), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 11, 14, 9, 47, 99, DateTimeKind.Local).AddTicks(6086), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 9, 16, 9, 47, 99, DateTimeKind.Local).AddTicks(6106), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 37, 47, 100, DateTimeKind.Local).AddTicks(645), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 54, 47, 100, DateTimeKind.Local).AddTicks(1499), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateEdited" },
                values: new object[] { new DateTime(2021, 5, 11, 16, 2, 47, 100, DateTimeKind.Local).AddTicks(1511), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
