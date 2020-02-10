using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class added_Base_Entity_To_Projects : Migration
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

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "Projects",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateUtc",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDateUtc",
                table: "Projects",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("6476d59a-0a09-4793-8a31-43fb7ba95fdd"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("4e65282a-d95a-416c-a2d0-1730d6615a66"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("22c3c78b-c23b-4e90-887e-ffa55fe8b0fb"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("4308b11b-0e04-44ac-b868-299158c8c89e"), null, null, null, "AQqmtw2YBMdLhLxw397ANC3pfcJoqBCeCo6D1T6mpm0/2MlshHlFr7kz37NOvjeB/g==", null, new Guid("6476d59a-0a09-4793-8a31-43fb7ba95fdd"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("aa38c504-863f-4cbc-8ff8-c8ff15f9a907"), null, null, null, "AV5TbPf5vildetTnh93rO+lYsRpgXktFKlzN3+43e3IE6hyB7gWmcupMkeuYYBKLTQ==", null, new Guid("4e65282a-d95a-416c-a2d0-1730d6615a66"), "Member" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("22c3c78b-c23b-4e90-887e-ffa55fe8b0fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4308b11b-0e04-44ac-b868-299158c8c89e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa38c504-863f-4cbc-8ff8-c8ff15f9a907"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4e65282a-d95a-416c-a2d0-1730d6615a66"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6476d59a-0a09-4793-8a31-43fb7ba95fdd"));

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CreatedDateUtc",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UpdatedDateUtc",
                table: "Projects");

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
