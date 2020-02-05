using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class SomeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("03658c2f-b0f0-404e-ae89-7a5c76e37da6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c0051f4-f85d-46af-ab9b-749891ff18de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83dc32b9-b867-4e61-bd23-7b3364dafd80"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3e969497-beb3-474a-966f-0e39be9579a2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("961ae623-f4f7-456c-bfd0-4592fb1d3e4b"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("9e3de11b-23ac-4036-b038-d68ff9366169"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("9157e0d4-0cbd-469a-b375-018e993645af"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("8bd10943-9f5a-4ac4-81f2-100b828b7cff"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("34043254-2eac-4ace-8594-99804f537c8b"), null, null, null, "AQ7TDd6XVVOOiXODA+x2H2jmF7A6auoK94Xn7nvoV4UuPBKyQW6VYWLVZ2x8aYJ3HQ==", null, new Guid("9e3de11b-23ac-4036-b038-d68ff9366169"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("b6ce2988-861f-4fe8-abf2-c6c0e8006d34"), null, null, null, "AfzMllahcIIIwY+RhhyBWwQ+j1wP9vMCeddWSGwRPRtBdq3Y9pQxBVqBOdOLAfpRVA==", null, new Guid("9157e0d4-0cbd-469a-b375-018e993645af"), "Member" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8bd10943-9f5a-4ac4-81f2-100b828b7cff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34043254-2eac-4ace-8594-99804f537c8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6ce2988-861f-4fe8-abf2-c6c0e8006d34"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9157e0d4-0cbd-469a-b375-018e993645af"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e3de11b-23ac-4036-b038-d68ff9366169"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("3e969497-beb3-474a-966f-0e39be9579a2"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("961ae623-f4f7-456c-bfd0-4592fb1d3e4b"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("03658c2f-b0f0-404e-ae89-7a5c76e37da6"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("83dc32b9-b867-4e61-bd23-7b3364dafd80"), null, null, null, "AT7vyEMX7OdDEwHF66pENDcXH/PRUKAH6TugtwMaAlwYPVmvSQvSk+DtfS4R0DGjGQ==", null, new Guid("3e969497-beb3-474a-966f-0e39be9579a2"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("0c0051f4-f85d-46af-ab9b-749891ff18de"), null, null, null, "AZnrD3HeGqXpR5HFec9HKcJuEC7gdoVKsXPXK981RHEcssiGb+jw/+/pSD4LWHfvZA==", null, new Guid("961ae623-f4f7-456c-bfd0-4592fb1d3e4b"), "Member" });
        }
    }
}
