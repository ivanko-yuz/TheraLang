using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class UserUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Users_CreatedById",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Resources_CreatedById",
                table: "Resources");

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

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "detailsId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserDetailsId",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    ShortInformation = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    ImageURl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("e549dfbb-3814-4626-b69c-7d183298948d"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("04b0b356-b31f-4df7-9779-60b0ba44088f"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("256ab49d-65e8-4690-acac-4b504aaa85f5"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "RoleId", "detailsId" },
                values: new object[] { new Guid("5868c1b6-63d4-4800-9701-69b8548d01e4"), "admin@utmm.com", "AcBxtua1oJEO80wcbykTbK2dMdfjzbygxClOzuUnJf0ckGfpHPYny29O/I6pmDbA3A==", new Guid("e549dfbb-3814-4626-b69c-7d183298948d"), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "RoleId", "detailsId" },
                values: new object[] { new Guid("4aafd7a6-efe3-4608-ae5e-4540a85bce76"), "member.@utmm.com", "ARMyoyQwBgildBlkYEaaAAouIL1mlxBX8ZBe4C0dbQHVDwb5lJkwkwb9OJuAzEB8Og==", new Guid("04b0b356-b31f-4df7-9779-60b0ba44088f"), null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_detailsId",
                table: "Users",
                column: "detailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_UserDetailsId",
                table: "Resources",
                column: "UserDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_UserId",
                table: "Resources",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_UserDetails_UserDetailsId",
                table: "Resources",
                column: "UserDetailsId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Users_UserId",
                table: "Resources",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserDetails_detailsId",
                table: "Users",
                column: "detailsId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_UserDetails_UserDetailsId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Users_UserId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserDetails_detailsId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropIndex(
                name: "IX_Users_detailsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Resources_UserDetailsId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_UserId",
                table: "Resources");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("256ab49d-65e8-4690-acac-4b504aaa85f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4aafd7a6-efe3-4608-ae5e-4540a85bce76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5868c1b6-63d4-4800-9701-69b8548d01e4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("04b0b356-b31f-4df7-9779-60b0ba44088f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e549dfbb-3814-4626-b69c-7d183298948d"));

            migrationBuilder.DropColumn(
                name: "detailsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserDetailsId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Resources");

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                maxLength: 256,
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CreatedById",
                table: "Resources",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Users_CreatedById",
                table: "Resources",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
