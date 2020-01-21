using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DLL.Migrations
{
    public partial class AddBlogging : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Piranha_Pages",
                maxLength: 255,
                nullable: false,
                defaultValue: "Page");

            migrationBuilder.CreateTable(
                name: "Piranha_Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    BlogId = table.Column<Guid>(),
                    Created = table.Column<DateTime>(),
                    LastModified = table.Column<DateTime>(),
                    Slug = table.Column<string>(maxLength: 64),
                    Title = table.Column<string>(maxLength: 64)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_Categories_Piranha_Pages_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Piranha_Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_PostTypes",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 64),
                    Body = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(),
                    LastModified = table.Column<DateTime>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PostTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    BlogId = table.Column<Guid>(),
                    Created = table.Column<DateTime>(),
                    LastModified = table.Column<DateTime>(),
                    Slug = table.Column<string>(maxLength: 64),
                    Title = table.Column<string>(maxLength: 64)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_Tags_Piranha_Pages_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Piranha_Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    BlogId = table.Column<Guid>(),
                    CategoryId = table.Column<Guid>(),
                    Created = table.Column<DateTime>(),
                    LastModified = table.Column<DateTime>(),
                    MetaDescription = table.Column<string>(maxLength: 256, nullable: true),
                    MetaKeywords = table.Column<string>(maxLength: 128, nullable: true),
                    PostTypeId = table.Column<string>(maxLength: 64),
                    Published = table.Column<DateTime>(nullable: true),
                    RedirectType = table.Column<int>(),
                    RedirectUrl = table.Column<string>(maxLength: 256, nullable: true),
                    Route = table.Column<string>(maxLength: 256, nullable: true),
                    Slug = table.Column<string>(maxLength: 128),
                    Title = table.Column<string>(maxLength: 128)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_Posts_Piranha_Pages_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Piranha_Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Piranha_Posts_Piranha_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Piranha_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Piranha_Posts_Piranha_PostTypes_PostTypeId",
                        column: x => x.PostTypeId,
                        principalTable: "Piranha_PostTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_PostFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    CLRType = table.Column<string>(maxLength: 256),
                    FieldId = table.Column<string>(maxLength: 64),
                    PostId = table.Column<Guid>(),
                    RegionId = table.Column<string>(maxLength: 64),
                    SortOrder = table.Column<int>(),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PostFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_PostFields_Piranha_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Piranha_Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_PostTags",
                columns: table => new
                {
                    PostId = table.Column<Guid>(),
                    TagId = table.Column<Guid>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PostTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_Piranha_PostTags_Piranha_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Piranha_Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Piranha_PostTags_Piranha_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Piranha_Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Categories_BlogId_Slug",
                table: "Piranha_Categories",
                columns: new[] { "BlogId", "Slug" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PostFields_PostId_RegionId_FieldId_SortOrder",
                table: "Piranha_PostFields",
                columns: new[] { "PostId", "RegionId", "FieldId", "SortOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Posts_CategoryId",
                table: "Piranha_Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Posts_PostTypeId",
                table: "Piranha_Posts",
                column: "PostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Posts_BlogId_Slug",
                table: "Piranha_Posts",
                columns: new[] { "BlogId", "Slug" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PostTags_TagId",
                table: "Piranha_PostTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Tags_BlogId_Slug",
                table: "Piranha_Tags",
                columns: new[] { "BlogId", "Slug" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piranha_PostFields");

            migrationBuilder.DropTable(
                name: "Piranha_PostTags");

            migrationBuilder.DropTable(
                name: "Piranha_Posts");

            migrationBuilder.DropTable(
                name: "Piranha_Tags");

            migrationBuilder.DropTable(
                name: "Piranha_Categories");

            migrationBuilder.DropTable(
                name: "Piranha_PostTypes");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Piranha_Pages");
        }
    }
}
