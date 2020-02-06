using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class FixNewsImagesRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UploadedFiles");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e21e329d-d718-434b-8eee-cb2f8bccb023"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ccdde82-b6ca-45fd-9dac-421d5def38c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f14f4be-91c7-4ffe-a86d-86928f702bb3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cdbbe497-131f-48a4-be4b-563b2427bd45"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f61cb741-580a-48a0-90b9-80101fc12b4c"));

            migrationBuilder.CreateTable(
                name: "UploadedNewsImages",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UploadedFiles",
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
                    table.PrimaryKey("PK_UploadedFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadedFiles_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("cdbbe497-131f-48a4-be4b-563b2427bd45"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("f61cb741-580a-48a0-90b9-80101fc12b4c"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("e21e329d-d718-434b-8eee-cb2f8bccb023"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("2ccdde82-b6ca-45fd-9dac-421d5def38c7"), null, null, null, "AVAN9CUtyFp6Y88EOkplbDcimOkojwIP9vK6F1veb79zM4w3ce1IBxCdMT7Lve0x3g==", null, new Guid("cdbbe497-131f-48a4-be4b-563b2427bd45"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("4f14f4be-91c7-4ffe-a86d-86928f702bb3"), null, null, null, "AUo8yVKmnBxjw9H4GgZg4Ue745ffWD+rIXGsIO7R7tp+4FNfDGZn74BFzR9Vn8B2Uw==", null, new Guid("f61cb741-580a-48a0-90b9-80101fc12b4c"), "Member" });

            migrationBuilder.CreateIndex(
                name: "IX_UploadedFiles_NewsId",
                table: "UploadedFiles",
                column: "NewsId");
        }
    }
}
