using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class UserUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("527a18ba-2562-4f92-b1fd-33348079160c"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("5ebdb58a-9e96-4bc2-b99f-0b34021cad8d"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("dd1c415b-34fd-4bb0-ab17-29d6bf3e32d0"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("aa642287-ef14-4464-a178-8994911eef8d"), "admin@utmm.com", null, null, "AS/RP/IyJp+fboy9nTN0FxuwSlvpEv8hePf/JcNwK78vrF4AwUaun2C7jHC85DFepQ==", null, new Guid("527a18ba-2562-4f92-b1fd-33348079160c"), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("c0c5f4f4-c890-4ea1-8699-130ab8c99e92"), "member@utmm.com", null, null, "ASnI+3a02jHBC0JV2346BTbDto11GUglHEL48tdMxRc3g7hfLA1CquCQcRkncs3/pQ==", null, new Guid("5ebdb58a-9e96-4bc2-b99f-0b34021cad8d"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dd1c415b-34fd-4bb0-ab17-29d6bf3e32d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa642287-ef14-4464-a178-8994911eef8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0c5f4f4-c890-4ea1-8699-130ab8c99e92"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("527a18ba-2562-4f92-b1fd-33348079160c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5ebdb58a-9e96-4bc2-b99f-0b34021cad8d"));

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
    }
}
