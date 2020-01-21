using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DLL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Piranha_MediaFolders",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Created = table.Column<DateTime>(),
                    Name = table.Column<string>(maxLength: 128),
                    ParentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_MediaFolders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_PageTypes",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 64),
                    Body = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(),
                    LastModified = table.Column<DateTime>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Params",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Created = table.Column<DateTime>(),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    Key = table.Column<string>(maxLength: 64),
                    LastModified = table.Column<DateTime>(),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Params", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Sites",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Created = table.Column<DateTime>(),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    Hostnames = table.Column<string>(maxLength: 256, nullable: true),
                    InternalId = table.Column<string>(maxLength: 64),
                    IsDefault = table.Column<bool>(),
                    LastModified = table.Column<DateTime>(),
                    Title = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Sites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Media",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    ContentType = table.Column<string>(maxLength: 256),
                    Created = table.Column<DateTime>(),
                    Filename = table.Column<string>(maxLength: 128),
                    FolderId = table.Column<Guid>(nullable: true),
                    LastModified = table.Column<DateTime>(),
                    PublicUrl = table.Column<string>(nullable: true),
                    Size = table.Column<long>(),
                    Type = table.Column<int>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_Media_Piranha_MediaFolders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "Piranha_MediaFolders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Pages",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Created = table.Column<DateTime>(),
                    IsHidden = table.Column<bool>(),
                    LastModified = table.Column<DateTime>(),
                    MetaDescription = table.Column<string>(maxLength: 256, nullable: true),
                    MetaKeywords = table.Column<string>(maxLength: 128, nullable: true),
                    NavigationTitle = table.Column<string>(maxLength: 128, nullable: true),
                    PageTypeId = table.Column<string>(maxLength: 64),
                    ParentId = table.Column<Guid>(nullable: true),
                    Published = table.Column<DateTime>(nullable: true),
                    RedirectType = table.Column<int>(),
                    RedirectUrl = table.Column<string>(maxLength: 256, nullable: true),
                    Route = table.Column<string>(maxLength: 256, nullable: true),
                    SiteId = table.Column<Guid>(),
                    Slug = table.Column<string>(maxLength: 128),
                    SortOrder = table.Column<int>(),
                    Title = table.Column<string>(maxLength: 128)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_Pages_Piranha_PageTypes_PageTypeId",
                        column: x => x.PageTypeId,
                        principalTable: "Piranha_PageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Piranha_Pages_Piranha_Pages_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Piranha_Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Piranha_Pages_Piranha_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Piranha_Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_PageFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    CLRType = table.Column<string>(maxLength: 256),
                    FieldId = table.Column<string>(maxLength: 64),
                    PageId = table.Column<Guid>(),
                    RegionId = table.Column<string>(maxLength: 64),
                    SortOrder = table.Column<int>(),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PageFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_PageFields_Piranha_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Piranha_Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Media_FolderId",
                table: "Piranha_Media",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PageFields_PageId_RegionId_FieldId_SortOrder",
                table: "Piranha_PageFields",
                columns: new[] { "PageId", "RegionId", "FieldId", "SortOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Pages_PageTypeId",
                table: "Piranha_Pages",
                column: "PageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Pages_ParentId",
                table: "Piranha_Pages",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Pages_SiteId_Slug",
                table: "Piranha_Pages",
                columns: new[] { "SiteId", "Slug" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Params_Key",
                table: "Piranha_Params",
                column: "Key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Sites_InternalId",
                table: "Piranha_Sites",
                column: "InternalId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piranha_Media");

            migrationBuilder.DropTable(
                name: "Piranha_PageFields");

            migrationBuilder.DropTable(
                name: "Piranha_Params");

            migrationBuilder.DropTable(
                name: "Piranha_MediaFolders");

            migrationBuilder.DropTable(
                name: "Piranha_Pages");

            migrationBuilder.DropTable(
                name: "Piranha_PageTypes");

            migrationBuilder.DropTable(
                name: "Piranha_Sites");
        }
    }
}
