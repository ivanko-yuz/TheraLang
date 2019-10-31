using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWeb.Migrations
{
    public partial class PiranhaInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Piranha_Blocks",
                table => new
                {
                    Id = table.Column<Guid>(),
                    CLRType = table.Column<string>(maxLength: 256),
                    Created = table.Column<DateTime>(),
                    IsReusable = table.Column<bool>(),
                    LastModified = table.Column<DateTime>(),
                    Title = table.Column<string>(maxLength: 128, nullable: true),
                    ParentId = table.Column<Guid>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Piranha_Blocks", x => x.Id); });

            migrationBuilder.CreateTable(
                "Piranha_MediaFolders",
                table => new
                {
                    Id = table.Column<Guid>(),
                    Created = table.Column<DateTime>(),
                    Name = table.Column<string>(maxLength: 128),
                    ParentId = table.Column<Guid>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Piranha_MediaFolders", x => x.Id); });

            migrationBuilder.CreateTable(
                "Piranha_PageTypes",
                table => new
                {
                    Id = table.Column<string>(maxLength: 64),
                    Body = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(),
                    LastModified = table.Column<DateTime>(),
                    CLRType = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Piranha_PageTypes", x => x.Id); });

            migrationBuilder.CreateTable(
                "Piranha_Params",
                table => new
                {
                    Id = table.Column<Guid>(),
                    Created = table.Column<DateTime>(),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    Key = table.Column<string>(maxLength: 64),
                    LastModified = table.Column<DateTime>(),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Piranha_Params", x => x.Id); });

            migrationBuilder.CreateTable(
                "Piranha_PostTypes",
                table => new
                {
                    Id = table.Column<string>(maxLength: 64),
                    Body = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(),
                    LastModified = table.Column<DateTime>(),
                    CLRType = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Piranha_PostTypes", x => x.Id); });

            migrationBuilder.CreateTable(
                "Piranha_Roles",
                table => new
                {
                    Id = table.Column<Guid>(),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Piranha_Roles", x => x.Id); });

            migrationBuilder.CreateTable(
                "Piranha_Sites",
                table => new
                {
                    Id = table.Column<Guid>(),
                    Created = table.Column<DateTime>(),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    Hostnames = table.Column<string>(maxLength: 256, nullable: true),
                    InternalId = table.Column<string>(maxLength: 64),
                    IsDefault = table.Column<bool>(),
                    LastModified = table.Column<DateTime>(),
                    Title = table.Column<string>(maxLength: 128, nullable: true),
                    SiteTypeId = table.Column<string>(maxLength: 64, nullable: true),
                    ContentLastModified = table.Column<DateTime>(nullable: true),
                    Culture = table.Column<string>(maxLength: 6, nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Piranha_Sites", x => x.Id); });

            migrationBuilder.CreateTable(
                "Piranha_SiteTypes",
                table => new
                {
                    Id = table.Column<string>(maxLength: 64),
                    Body = table.Column<string>(nullable: true),
                    CLRType = table.Column<string>(maxLength: 256, nullable: true),
                    Created = table.Column<DateTime>(),
                    LastModified = table.Column<DateTime>()
                },
                constraints: table => { table.PrimaryKey("PK_Piranha_SiteTypes", x => x.Id); });

            migrationBuilder.CreateTable(
                "Piranha_Users",
                table => new
                {
                    Id = table.Column<Guid>(),
                    AccessFailedCount = table.Column<int>(),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(),
                    LockoutEnabled = table.Column<bool>(),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Piranha_Users", x => x.Id); });

            migrationBuilder.CreateTable(
                "Piranha_BlockFields",
                table => new
                {
                    Id = table.Column<Guid>(),
                    BlockId = table.Column<Guid>(),
                    CLRType = table.Column<string>(maxLength: 256),
                    FieldId = table.Column<string>(maxLength: 64),
                    SortOrder = table.Column<int>(),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_BlockFields", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_BlockFields_Piranha_Blocks_BlockId",
                        x => x.BlockId,
                        "Piranha_Blocks",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_Media",
                table => new
                {
                    Id = table.Column<Guid>(),
                    ContentType = table.Column<string>(maxLength: 256),
                    Created = table.Column<DateTime>(),
                    Filename = table.Column<string>(maxLength: 128),
                    FolderId = table.Column<Guid>(nullable: true),
                    LastModified = table.Column<DateTime>(),
                    PublicUrl = table.Column<string>(nullable: true),
                    Size = table.Column<long>(),
                    Type = table.Column<int>(),
                    Height = table.Column<int>(nullable: true),
                    Width = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Media", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_Media_Piranha_MediaFolders_FolderId",
                        x => x.FolderId,
                        "Piranha_MediaFolders",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Piranha_RoleClaims",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<Guid>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_RoleClaims_Piranha_Roles_RoleId",
                        x => x.RoleId,
                        "Piranha_Roles",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_Aliases",
                table => new
                {
                    Id = table.Column<Guid>(),
                    AliasUrl = table.Column<string>(maxLength: 256),
                    Created = table.Column<DateTime>(),
                    LastModified = table.Column<DateTime>(),
                    RedirectUrl = table.Column<string>(maxLength: 256),
                    SiteId = table.Column<Guid>(),
                    Type = table.Column<int>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Aliases", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_Aliases_Piranha_Sites_SiteId",
                        x => x.SiteId,
                        "Piranha_Sites",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_Pages",
                table => new
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
                    Title = table.Column<string>(maxLength: 128),
                    ContentType = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "(N'Page')"),
                    OriginalPageId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Pages", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_Pages_Piranha_PageTypes_PageTypeId",
                        x => x.PageTypeId,
                        "Piranha_PageTypes",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Piranha_Pages_Piranha_Pages_ParentId",
                        x => x.ParentId,
                        "Piranha_Pages",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_Piranha_Pages_Piranha_Sites_SiteId",
                        x => x.SiteId,
                        "Piranha_Sites",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_SiteFields",
                table => new
                {
                    Id = table.Column<Guid>(),
                    CLRType = table.Column<string>(maxLength: 256),
                    FieldId = table.Column<string>(maxLength: 64),
                    RegionId = table.Column<string>(maxLength: 64),
                    SiteId = table.Column<Guid>(),
                    SortOrder = table.Column<int>(),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_SiteFields", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_SiteFields_Piranha_Sites_SiteId",
                        x => x.SiteId,
                        "Piranha_Sites",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_UserClaims",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_UserClaims", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_UserClaims_Piranha_Users_UserId",
                        x => x.UserId,
                        "Piranha_Users",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_UserLogins",
                table => new
                {
                    LoginProvider = table.Column<string>(),
                    ProviderKey = table.Column<string>(),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_UserLogins", x => new {x.LoginProvider, x.ProviderKey});
                    table.ForeignKey(
                        "FK_Piranha_UserLogins_Piranha_Users_UserId",
                        x => x.UserId,
                        "Piranha_Users",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_UserRoles",
                table => new
                {
                    UserId = table.Column<Guid>(),
                    RoleId = table.Column<Guid>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_UserRoles", x => new {x.UserId, x.RoleId});
                    table.ForeignKey(
                        "FK_Piranha_UserRoles_Piranha_Roles_RoleId",
                        x => x.RoleId,
                        "Piranha_Roles",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Piranha_UserRoles_Piranha_Users_UserId",
                        x => x.UserId,
                        "Piranha_Users",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_UserTokens",
                table => new
                {
                    UserId = table.Column<Guid>(),
                    LoginProvider = table.Column<string>(),
                    Name = table.Column<string>(),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_UserTokens", x => new {x.UserId, x.LoginProvider, x.Name});
                    table.ForeignKey(
                        "FK_Piranha_UserTokens_Piranha_Users_UserId",
                        x => x.UserId,
                        "Piranha_Users",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_MediaVersions",
                table => new
                {
                    Id = table.Column<Guid>(),
                    Height = table.Column<int>(nullable: true),
                    MediaId = table.Column<Guid>(),
                    Size = table.Column<long>(),
                    Width = table.Column<int>(),
                    FileExtension = table.Column<string>(maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_MediaVersions", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_MediaVersions_Piranha_Media_MediaId",
                        x => x.MediaId,
                        "Piranha_Media",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_Categories",
                table => new
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
                        "FK_Piranha_Categories_Piranha_Pages_BlogId",
                        x => x.BlogId,
                        "Piranha_Pages",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_PageBlocks",
                table => new
                {
                    Id = table.Column<Guid>(),
                    BlockId = table.Column<Guid>(),
                    PageId = table.Column<Guid>(),
                    SortOrder = table.Column<int>(),
                    ParentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PageBlocks", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_PageBlocks_Piranha_Blocks_BlockId",
                        x => x.BlockId,
                        "Piranha_Blocks",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Piranha_PageBlocks_Piranha_Pages_PageId",
                        x => x.PageId,
                        "Piranha_Pages",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_PageFields",
                table => new
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
                        "FK_Piranha_PageFields_Piranha_Pages_PageId",
                        x => x.PageId,
                        "Piranha_Pages",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_PageRevisions",
                table => new
                {
                    Id = table.Column<Guid>(),
                    Data = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(),
                    PageId = table.Column<Guid>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PageRevisions", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_PageRevisions_Piranha_Pages_PageId",
                        x => x.PageId,
                        "Piranha_Pages",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_Tags",
                table => new
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
                        "FK_Piranha_Tags_Piranha_Pages_BlogId",
                        x => x.BlogId,
                        "Piranha_Pages",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_Posts",
                table => new
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
                        "FK_Piranha_Posts_Piranha_Pages_BlogId",
                        x => x.BlogId,
                        "Piranha_Pages",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Piranha_Posts_Piranha_Categories_CategoryId",
                        x => x.CategoryId,
                        "Piranha_Categories",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_Piranha_Posts_Piranha_PostTypes_PostTypeId",
                        x => x.PostTypeId,
                        "Piranha_PostTypes",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_PostBlocks",
                table => new
                {
                    Id = table.Column<Guid>(),
                    BlockId = table.Column<Guid>(),
                    PostId = table.Column<Guid>(),
                    SortOrder = table.Column<int>(),
                    ParentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PostBlocks", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_PostBlocks_Piranha_Blocks_BlockId",
                        x => x.BlockId,
                        "Piranha_Blocks",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Piranha_PostBlocks_Piranha_Posts_PostId",
                        x => x.PostId,
                        "Piranha_Posts",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_PostFields",
                table => new
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
                        "FK_Piranha_PostFields_Piranha_Posts_PostId",
                        x => x.PostId,
                        "Piranha_Posts",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_PostRevisions",
                table => new
                {
                    Id = table.Column<Guid>(),
                    Data = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(),
                    PostId = table.Column<Guid>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PostRevisions", x => x.Id);
                    table.ForeignKey(
                        "FK_Piranha_PostRevisions_Piranha_Posts_PostId",
                        x => x.PostId,
                        "Piranha_Posts",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Piranha_PostTags",
                table => new
                {
                    PostId = table.Column<Guid>(),
                    TagId = table.Column<Guid>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_PostTags", x => new {x.PostId, x.TagId});
                    table.ForeignKey(
                        "FK_Piranha_PostTags_Piranha_Posts_PostId",
                        x => x.PostId,
                        "Piranha_Posts",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Piranha_PostTags_Piranha_Tags_TagId",
                        x => x.TagId,
                        "Piranha_Tags",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_Piranha_Aliases_SiteId_AliasUrl",
                "Piranha_Aliases",
                new[] {"SiteId", "AliasUrl"},
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Piranha_BlockFields_BlockId_FieldId_SortOrder",
                "Piranha_BlockFields",
                new[] {"BlockId", "FieldId", "SortOrder"},
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Piranha_Categories_BlogId_Slug",
                "Piranha_Categories",
                new[] {"BlogId", "Slug"},
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Piranha_Media_FolderId",
                "Piranha_Media",
                "FolderId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_MediaVersions_MediaId_Width_Height",
                "Piranha_MediaVersions",
                new[] {"MediaId", "Width", "Height"},
                unique: true,
                filter: "[Height] IS NOT NULL");

            migrationBuilder.CreateIndex(
                "IX_Piranha_PageBlocks_BlockId",
                "Piranha_PageBlocks",
                "BlockId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_PageBlocks_PageId_SortOrder",
                "Piranha_PageBlocks",
                new[] {"PageId", "SortOrder"},
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Piranha_PageFields_PageId_RegionId_FieldId_SortOrder",
                "Piranha_PageFields",
                new[] {"PageId", "RegionId", "FieldId", "SortOrder"});

            migrationBuilder.CreateIndex(
                "IX_Piranha_PageRevisions_PageId",
                "Piranha_PageRevisions",
                "PageId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_Pages_PageTypeId",
                "Piranha_Pages",
                "PageTypeId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_Pages_ParentId",
                "Piranha_Pages",
                "ParentId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_Pages_SiteId_Slug",
                "Piranha_Pages",
                new[] {"SiteId", "Slug"},
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Piranha_Params_Key",
                "Piranha_Params",
                "Key",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Piranha_PostBlocks_BlockId",
                "Piranha_PostBlocks",
                "BlockId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_PostBlocks_PostId_SortOrder",
                "Piranha_PostBlocks",
                new[] {"PostId", "SortOrder"},
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Piranha_PostFields_PostId_RegionId_FieldId_SortOrder",
                "Piranha_PostFields",
                new[] {"PostId", "RegionId", "FieldId", "SortOrder"});

            migrationBuilder.CreateIndex(
                "IX_Piranha_PostRevisions_PostId",
                "Piranha_PostRevisions",
                "PostId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_Posts_CategoryId",
                "Piranha_Posts",
                "CategoryId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_Posts_PostTypeId",
                "Piranha_Posts",
                "PostTypeId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_Posts_BlogId_Slug",
                "Piranha_Posts",
                new[] {"BlogId", "Slug"},
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Piranha_PostTags_TagId",
                "Piranha_PostTags",
                "TagId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_RoleClaims_RoleId",
                "Piranha_RoleClaims",
                "RoleId");

            migrationBuilder.CreateIndex(
                "RoleNameIndex",
                "Piranha_Roles",
                "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                "IX_Piranha_SiteFields_SiteId_RegionId_FieldId_SortOrder",
                "Piranha_SiteFields",
                new[] {"SiteId", "RegionId", "FieldId", "SortOrder"});

            migrationBuilder.CreateIndex(
                "IX_Piranha_Sites_InternalId",
                "Piranha_Sites",
                "InternalId",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Piranha_Tags_BlogId_Slug",
                "Piranha_Tags",
                new[] {"BlogId", "Slug"},
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Piranha_UserClaims_UserId",
                "Piranha_UserClaims",
                "UserId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_UserLogins_UserId",
                "Piranha_UserLogins",
                "UserId");

            migrationBuilder.CreateIndex(
                "IX_Piranha_UserRoles_RoleId",
                "Piranha_UserRoles",
                "RoleId");

            migrationBuilder.CreateIndex(
                "EmailIndex",
                "Piranha_Users",
                "NormalizedEmail");

            migrationBuilder.CreateIndex(
                "UserNameIndex",
                "Piranha_Users",
                "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Piranha_Aliases");

            migrationBuilder.DropTable(
                "Piranha_BlockFields");

            migrationBuilder.DropTable(
                "Piranha_MediaVersions");

            migrationBuilder.DropTable(
                "Piranha_PageBlocks");

            migrationBuilder.DropTable(
                "Piranha_PageFields");

            migrationBuilder.DropTable(
                "Piranha_PageRevisions");

            migrationBuilder.DropTable(
                "Piranha_Params");

            migrationBuilder.DropTable(
                "Piranha_PostBlocks");

            migrationBuilder.DropTable(
                "Piranha_PostFields");

            migrationBuilder.DropTable(
                "Piranha_PostRevisions");

            migrationBuilder.DropTable(
                "Piranha_PostTags");

            migrationBuilder.DropTable(
                "Piranha_RoleClaims");

            migrationBuilder.DropTable(
                "Piranha_SiteFields");

            migrationBuilder.DropTable(
                "Piranha_SiteTypes");

            migrationBuilder.DropTable(
                "Piranha_UserClaims");

            migrationBuilder.DropTable(
                "Piranha_UserLogins");

            migrationBuilder.DropTable(
                "Piranha_UserRoles");

            migrationBuilder.DropTable(
                "Piranha_UserTokens");

            migrationBuilder.DropTable(
                "Piranha_Media");

            migrationBuilder.DropTable(
                "Piranha_Blocks");

            migrationBuilder.DropTable(
                "Piranha_Posts");

            migrationBuilder.DropTable(
                "Piranha_Tags");

            migrationBuilder.DropTable(
                "Piranha_Roles");

            migrationBuilder.DropTable(
                "Piranha_Users");

            migrationBuilder.DropTable(
                "Piranha_MediaFolders");

            migrationBuilder.DropTable(
                "Piranha_Categories");

            migrationBuilder.DropTable(
                "Piranha_PostTypes");

            migrationBuilder.DropTable(
                "Piranha_Pages");

            migrationBuilder.DropTable(
                "Piranha_PageTypes");

            migrationBuilder.DropTable(
                "Piranha_Sites");
        }
    }
}