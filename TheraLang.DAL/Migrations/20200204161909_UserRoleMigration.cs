using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class UserRoleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("596a647c-935d-4cb5-8058-74597153e17e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71b94b87-6adc-4d65-8a3b-0fda35832570"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af79903b-146c-4a66-8f71-c6d836099b2c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("747d9ef8-404f-4999-86d7-0d6bcea10ebc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ff896ab5-138e-4475-b8b1-f21bd255f4ff"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("936da01f-9abd-4d9d-80c7-02af85c822a8"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("936da01f-9abd-4d9d-80c7-02af85c823b6"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("936da01f-9abd-4d9d-80c7-02af85c822a7"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("f7ad0e22-ac23-4d1e-b62e-f46f3b5d3557"), null, null, null, "AY7fV6SefchBqHN8Aynh1+Gn3QqRltu2gn52nTaZ29VgLF7+KAe51isAktuS1/NGKw==", null, new Guid("936da01f-9abd-4d9d-80c7-02af85c822a8"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("92d3da29-1a95-459a-841a-d40acc4e8682"), null, null, null, "AWM317kCDp031PAaPQaGvghupvdvViqI/FjZAXXEy+SiRELmiLkMvjDoMGsFLVIqQQ==", null, new Guid("936da01f-9abd-4d9d-80c7-02af85c823b6"), "Member" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("936da01f-9abd-4d9d-80c7-02af85c822a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92d3da29-1a95-459a-841a-d40acc4e8682"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7ad0e22-ac23-4d1e-b62e-f46f3b5d3557"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("936da01f-9abd-4d9d-80c7-02af85c822a8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("936da01f-9abd-4d9d-80c7-02af85c823b6"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("ff896ab5-138e-4475-b8b1-f21bd255f4ff"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("747d9ef8-404f-4999-86d7-0d6bcea10ebc"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("596a647c-935d-4cb5-8058-74597153e17e"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("71b94b87-6adc-4d65-8a3b-0fda35832570"), null, null, null, "ASWPUmOxP5OI7TreLwuaCctZa1gYGA+nHml6hvmh5/ic1g2JqhZlWK7OazjupFSUWw==", null, new Guid("ff896ab5-138e-4475-b8b1-f21bd255f4ff"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("af79903b-146c-4a66-8f71-c6d836099b2c"), null, null, null, "AQ9SW1m/2P3cBunWEb2S13ma46Owo2vvHnJgIZM+2tE7+DZG5Wp0JCQZqAIGEU3A7Q==", null, new Guid("747d9ef8-404f-4999-86d7-0d6bcea10ebc"), "Member" });
        }
    }
}
