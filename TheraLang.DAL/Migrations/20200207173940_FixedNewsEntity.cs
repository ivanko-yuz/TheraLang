using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class FixedNewsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UploadedNewsImages");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0bf6113c-cad9-4294-b579-d74bbc7a320d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47c98f46-c131-4cab-82bb-94e34354fad0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ffafd4e-d81f-416d-9941-53ea75d65e05"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2e32fd16-2103-4ec2-bd15-77c98342afab"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("88aa029e-fe8a-48ae-99d8-f5cabafad8b6"));

            migrationBuilder.AddColumn<string>(
                name: "MainImageUrl",
                table: "News",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "UploadedNewsContentImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedById = table.Column<Guid>(nullable: false),
                    UpdatedById = table.Column<Guid>(nullable: true),
                    CreatedDateUtc = table.Column<DateTime>(nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: false),
                    NewsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadedNewsContentImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadedNewsContentImages_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_News_CreatedById",
                table: "News",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UploadedNewsContentImages_NewsId",
                table: "UploadedNewsContentImages",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_CreatedById",
                table: "News",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_CreatedById",
                table: "News");

            migrationBuilder.DropTable(
                name: "UploadedNewsContentImages");

            migrationBuilder.DropIndex(
                name: "IX_News_CreatedById",
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

            migrationBuilder.DropColumn(
                name: "MainImageUrl",
                table: "News");

            migrationBuilder.CreateTable(
                name: "UploadedNewsImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedById = table.Column<Guid>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(nullable: false),
                    NewsId = table.Column<int>(nullable: true),
                    UpdatedById = table.Column<Guid>(nullable: true),
                    UpdatedDateUtc = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadedNewsImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadedNewsImages_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("88aa029e-fe8a-48ae-99d8-f5cabafad8b6"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("2e32fd16-2103-4ec2-bd15-77c98342afab"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("0bf6113c-cad9-4294-b579-d74bbc7a320d"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("8ffafd4e-d81f-416d-9941-53ea75d65e05"), null, null, null, "ASayMdptiyl8AYiz5cB+yNEh8jh+ZTAlB84sjI9PWMvbLk5WwoVYOAuj4LNqGYw1Hg==", null, new Guid("88aa029e-fe8a-48ae-99d8-f5cabafad8b6"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("47c98f46-c131-4cab-82bb-94e34354fad0"), null, null, null, "ARwlsTImQoKnf4Dyra6uLVY0ClcSSYiTLJiQfb7xVJ10Ya9aGcsctJC58Mey3IdF5g==", null, new Guid("2e32fd16-2103-4ec2-bd15-77c98342afab"), "Member" });

            migrationBuilder.CreateIndex(
                name: "IX_UploadedNewsImages_NewsId",
                table: "UploadedNewsImages",
                column: "NewsId");
        }
    }
}
