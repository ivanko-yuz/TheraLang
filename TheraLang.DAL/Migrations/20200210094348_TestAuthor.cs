using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class TestAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_CreatedById",
                table: "News");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("40ab11ac-b962-4293-a080-faf308bba3e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81377f78-beaa-41a7-926b-ea4a6022055f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e2c9c8d-0386-4dd3-ba92-c4ae0b4aaab9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ca32fd4-4739-44e3-a423-819930401a2a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd1f5a76-fbad-43f8-a023-468b0e792fa5"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("3982c8bb-ced6-4538-b5d7-94d025a1a2eb"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("88a04f5f-b493-4eaa-a82e-13fd903692e5"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("67d5f889-7b57-44e5-a22c-5c9ac7016892"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("973fd9ff-d3f9-42d8-8c6e-5a5ea14c36d2"), null, null, null, "AbJ3qO9Lgv6eTbklGeRCDdZuH67ylEcszOe+BGc+MiiIc8cCBezM3fNqwmK+i4K/gQ==", null, new Guid("3982c8bb-ced6-4538-b5d7-94d025a1a2eb"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("02360fe1-e470-49fc-8e4d-843520c81196"), null, null, null, "AaYl2XN7Eq9Y1S+Z/PIWEtSEBDZyN2UhZL0ZPDahmoIN+/n9/GVbghqnXzJu+955qQ==", null, new Guid("88a04f5f-b493-4eaa-a82e-13fd903692e5"), "Member" });

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_CreatedById",
                table: "News",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_CreatedById",
                table: "News");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("67d5f889-7b57-44e5-a22c-5c9ac7016892"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02360fe1-e470-49fc-8e4d-843520c81196"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("973fd9ff-d3f9-42d8-8c6e-5a5ea14c36d2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3982c8bb-ced6-4538-b5d7-94d025a1a2eb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("88a04f5f-b493-4eaa-a82e-13fd903692e5"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("bd1f5a76-fbad-43f8-a023-468b0e792fa5"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("6ca32fd4-4739-44e3-a423-819930401a2a"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("40ab11ac-b962-4293-a080-faf308bba3e7"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("8e2c9c8d-0386-4dd3-ba92-c4ae0b4aaab9"), null, null, null, "AQU5HEZ0E/ho4sJ+V/sybzl1aH4PpDT/k2+EptCoecLOu7O4eHL5uy1RQQYgL/tP9w==", null, new Guid("bd1f5a76-fbad-43f8-a023-468b0e792fa5"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("81377f78-beaa-41a7-926b-ea4a6022055f"), null, null, null, "AfHQh/I/xILRi+tXvhgPs9LfGsb/mNiLUrN93aW42pv5Ts5D/qWruORU3b0ZIen1ug==", null, new Guid("6ca32fd4-4739-44e3-a423-819930401a2a"), "Member" });

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_CreatedById",
                table: "News",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
