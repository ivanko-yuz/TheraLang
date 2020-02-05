using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piranha_Aliases");

            migrationBuilder.DropTable(
                name: "Piranha_BlockFields");

            migrationBuilder.DropTable(
                name: "Piranha_MediaVersions");

            migrationBuilder.DropTable(
                name: "Piranha_PageBlocks");

            migrationBuilder.DropTable(
                name: "Piranha_PageFields");

            migrationBuilder.DropTable(
                name: "Piranha_PageRevisions");

            migrationBuilder.DropTable(
                name: "Piranha_Params");

            migrationBuilder.DropTable(
                name: "Piranha_PostBlocks");

            migrationBuilder.DropTable(
                name: "Piranha_PostFields");

            migrationBuilder.DropTable(
                name: "Piranha_PostRevisions");

            migrationBuilder.DropTable(
                name: "Piranha_PostTags");

            migrationBuilder.DropTable(
                name: "Piranha_SiteFields");

            migrationBuilder.DropTable(
                name: "Piranha_SiteTypes");

            migrationBuilder.DropTable(
                name: "Piranha_Media");

            migrationBuilder.DropTable(
                name: "Piranha_Blocks");

            migrationBuilder.DropTable(
                name: "Piranha_Posts");

            migrationBuilder.DropTable(
                name: "Piranha_Tags");

            migrationBuilder.DropTable(
                name: "Piranha_MediaFolders");

            migrationBuilder.DropTable(
                name: "Piranha_Categories");

            migrationBuilder.DropTable(
                name: "Piranha_PostTypes");

            migrationBuilder.DropTable(
                name: "Piranha_Pages");

            migrationBuilder.DropTable(
                name: "Piranha_PageTypes");

            migrationBuilder.DropTable(
                name: "Piranha_Sites");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "Roles");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6d60bcdd-c677-4298-a582-7eff3f51156b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05e7702e-8b66-4915-8108-fd3c8afd9497"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8338bb32-32d6-459f-8354-efce289346b2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0c186cd2-3ea3-4be3-bf22-91999eedf7fd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0e8b3fda-74cf-4c46-a21b-08a29c66aaf1"));

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "Roles",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "Roles",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Piranha_Blocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CLRType = table.Column<string>(maxLength: 256, nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    IsReusable = table.Column<bool>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: true),
                    Title = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Blocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_MediaFolders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
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
                    Id = table.Column<string>(maxLength: 64, nullable: false),
                    Body = table.Column<string>(nullable: true),
                    CLRType = table.Column<string>(maxLength: 256, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Params",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    Key = table.Column<string>(maxLength: 64, nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Params", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_PostTypes",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 64, nullable: false),
                    Body = table.Column<string>(nullable: true),
                    CLRType = table.Column<string>(maxLength: 256, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PostTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Sites",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ContentLastModified = table.Column<DateTime>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Culture = table.Column<string>(maxLength: 6, nullable: true),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    Hostnames = table.Column<string>(maxLength: 256, nullable: true),
                    InternalId = table.Column<string>(maxLength: 64, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    SiteTypeId = table.Column<string>(maxLength: 64, nullable: true),
                    Title = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Sites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_SiteTypes",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 64, nullable: false),
                    Body = table.Column<string>(nullable: true),
                    CLRType = table.Column<string>(maxLength: 256, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_SiteTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_BlockFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BlockId = table.Column<Guid>(nullable: false),
                    CLRType = table.Column<string>(maxLength: 256, nullable: false),
                    FieldId = table.Column<string>(maxLength: 64, nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_BlockFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_BlockFields_Piranha_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Piranha_Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Media",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ContentType = table.Column<string>(maxLength: 256, nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Filename = table.Column<string>(maxLength: 128, nullable: false),
                    FolderId = table.Column<Guid>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    PublicUrl = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: true)
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
                name: "Piranha_Aliases",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AliasUrl = table.Column<string>(maxLength: 256, nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    RedirectUrl = table.Column<string>(maxLength: 256, nullable: false),
                    SiteId = table.Column<Guid>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Aliases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_Aliases_Piranha_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Piranha_Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Pages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ContentType = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "(N'Page')"),
                    Created = table.Column<DateTime>(nullable: false),
                    IsHidden = table.Column<bool>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    MetaDescription = table.Column<string>(maxLength: 256, nullable: true),
                    MetaKeywords = table.Column<string>(maxLength: 128, nullable: true),
                    NavigationTitle = table.Column<string>(maxLength: 128, nullable: true),
                    OriginalPageId = table.Column<Guid>(nullable: true),
                    PageTypeId = table.Column<string>(maxLength: 64, nullable: false),
                    ParentId = table.Column<Guid>(nullable: true),
                    Published = table.Column<DateTime>(nullable: true),
                    RedirectType = table.Column<int>(nullable: false),
                    RedirectUrl = table.Column<string>(maxLength: 256, nullable: true),
                    Route = table.Column<string>(maxLength: 256, nullable: true),
                    SiteId = table.Column<Guid>(nullable: false),
                    Slug = table.Column<string>(maxLength: 128, nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 128, nullable: false)
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
                name: "Piranha_SiteFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CLRType = table.Column<string>(maxLength: 256, nullable: false),
                    FieldId = table.Column<string>(maxLength: 64, nullable: false),
                    RegionId = table.Column<string>(maxLength: 64, nullable: false),
                    SiteId = table.Column<Guid>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_SiteFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_SiteFields_Piranha_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Piranha_Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_MediaVersions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FileExtension = table.Column<string>(maxLength: 8, nullable: true),
                    Height = table.Column<int>(nullable: true),
                    MediaId = table.Column<Guid>(nullable: false),
                    Size = table.Column<long>(nullable: false),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_MediaVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_MediaVersions_Piranha_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Piranha_Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BlogId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Slug = table.Column<string>(maxLength: 64, nullable: false),
                    Title = table.Column<string>(maxLength: 64, nullable: false)
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
                name: "Piranha_PageBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BlockId = table.Column<Guid>(nullable: false),
                    PageId = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PageBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_PageBlocks_Piranha_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Piranha_Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Piranha_PageBlocks_Piranha_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Piranha_Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_PageFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CLRType = table.Column<string>(maxLength: 256, nullable: false),
                    FieldId = table.Column<string>(maxLength: 64, nullable: false),
                    PageId = table.Column<Guid>(nullable: false),
                    RegionId = table.Column<string>(maxLength: 64, nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Piranha_PageRevisions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Data = table.Column<string>(nullable: true),
                    PageId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PageRevisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_PageRevisions_Piranha_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Piranha_Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BlogId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Slug = table.Column<string>(maxLength: 64, nullable: false),
                    Title = table.Column<string>(maxLength: 64, nullable: false)
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
                    Id = table.Column<Guid>(nullable: false),
                    BlogId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    MetaDescription = table.Column<string>(maxLength: 256, nullable: true),
                    MetaKeywords = table.Column<string>(maxLength: 128, nullable: true),
                    PostTypeId = table.Column<string>(maxLength: 64, nullable: false),
                    Published = table.Column<DateTime>(nullable: true),
                    RedirectType = table.Column<int>(nullable: false),
                    RedirectUrl = table.Column<string>(maxLength: 256, nullable: true),
                    Route = table.Column<string>(maxLength: 256, nullable: true),
                    Slug = table.Column<string>(maxLength: 128, nullable: false),
                    Title = table.Column<string>(maxLength: 128, nullable: false)
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
                name: "Piranha_PostBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BlockId = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: true),
                    PostId = table.Column<Guid>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PostBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_PostBlocks_Piranha_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Piranha_Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Piranha_PostBlocks_Piranha_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Piranha_Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_PostFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CLRType = table.Column<string>(maxLength: 256, nullable: false),
                    FieldId = table.Column<string>(maxLength: 64, nullable: false),
                    PostId = table.Column<Guid>(nullable: false),
                    RegionId = table.Column<string>(maxLength: 64, nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
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
                name: "Piranha_PostRevisions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Data = table.Column<string>(nullable: true),
                    PostId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PostRevisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_PostRevisions_Piranha_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Piranha_Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piranha_PostTags",
                columns: table => new
                {
                    PostId = table.Column<Guid>(nullable: false),
                    TagId = table.Column<Guid>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("0c186cd2-3ea3-4be3-bf22-91999eedf7fd"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("0e8b3fda-74cf-4c46-a21b-08a29c66aaf1"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("6d60bcdd-c677-4298-a582-7eff3f51156b"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("8338bb32-32d6-459f-8354-efce289346b2"), null, null, null, "ATGm5z/PTsyiYB6Xvy6bOD+sAADNyhgKA4XGVI12OyStnHYiwONmPwxS83xNn90AHg==", null, new Guid("0c186cd2-3ea3-4be3-bf22-91999eedf7fd"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("05e7702e-8b66-4915-8108-fd3c8afd9497"), null, null, null, "AeZhgmE11aks9P3CKm5/hgK3d9KWV0ectKJzAO5La4I5DBfuFsJ++RaGTSwoShqCAw==", null, new Guid("0e8b3fda-74cf-4c46-a21b-08a29c66aaf1"), "Member" });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Aliases_SiteId_AliasUrl",
                table: "Piranha_Aliases",
                columns: new[] { "SiteId", "AliasUrl" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_BlockFields_BlockId_FieldId_SortOrder",
                table: "Piranha_BlockFields",
                columns: new[] { "BlockId", "FieldId", "SortOrder" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Categories_BlogId_Slug",
                table: "Piranha_Categories",
                columns: new[] { "BlogId", "Slug" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Media_FolderId",
                table: "Piranha_Media",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_MediaVersions_MediaId_Width_Height",
                table: "Piranha_MediaVersions",
                columns: new[] { "MediaId", "Width", "Height" },
                unique: true,
                filter: "[Height] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PageBlocks_BlockId",
                table: "Piranha_PageBlocks",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PageBlocks_PageId_SortOrder",
                table: "Piranha_PageBlocks",
                columns: new[] { "PageId", "SortOrder" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PageFields_PageId_RegionId_FieldId_SortOrder",
                table: "Piranha_PageFields",
                columns: new[] { "PageId", "RegionId", "FieldId", "SortOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PageRevisions_PageId",
                table: "Piranha_PageRevisions",
                column: "PageId");

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
                name: "IX_Piranha_PostBlocks_BlockId",
                table: "Piranha_PostBlocks",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PostBlocks_PostId_SortOrder",
                table: "Piranha_PostBlocks",
                columns: new[] { "PostId", "SortOrder" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PostFields_PostId_RegionId_FieldId_SortOrder",
                table: "Piranha_PostFields",
                columns: new[] { "PostId", "RegionId", "FieldId", "SortOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PostRevisions_PostId",
                table: "Piranha_PostRevisions",
                column: "PostId");

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
                name: "IX_Piranha_SiteFields_SiteId_RegionId_FieldId_SortOrder",
                table: "Piranha_SiteFields",
                columns: new[] { "SiteId", "RegionId", "FieldId", "SortOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Sites_InternalId",
                table: "Piranha_Sites",
                column: "InternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Tags_BlogId_Slug",
                table: "Piranha_Tags",
                columns: new[] { "BlogId", "Slug" },
                unique: true);
        }
    }
}
