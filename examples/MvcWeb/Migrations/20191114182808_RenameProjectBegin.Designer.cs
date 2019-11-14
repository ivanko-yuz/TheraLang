using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcWeb.Db;

namespace MvcWeb.Migrations
{
    [DbContext(typeof(IttmmDbContext))]
    [Migration("20191114182808_RenameProjectBegin")]
    partial class RenameProjectBegin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaAlias", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("AliasUrl")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("RedirectUrl")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<Guid>("SiteId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("SiteId", "AliasUrl")
                        .IsUnique();

                    b.ToTable("Piranha_Aliases");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaBlock", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("ClrType")
                        .IsRequired()
                        .HasColumnName("CLRType")
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<bool>("IsReusable");

                    b.Property<DateTime>("LastModified");

                    b.Property<Guid?>("ParentId");

                    b.Property<string>("Title")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Piranha_Blocks");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaBlockField", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<Guid>("BlockId");

                    b.Property<string>("ClrType")
                        .IsRequired()
                        .HasColumnName("CLRType")
                        .HasMaxLength(256);

                    b.Property<string>("FieldId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("BlockId", "FieldId", "SortOrder")
                        .IsUnique();

                    b.ToTable("Piranha_BlockFields");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaCategory", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<Guid>("BlogId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("BlogId", "Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Categories");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaMedia", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<Guid?>("FolderId");

                    b.Property<int?>("Height");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("PublicUrl");

                    b.Property<long>("Size");

                    b.Property<int>("Type");

                    b.Property<int?>("Width");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.ToTable("Piranha_Media");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaMediaFolder", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<Guid?>("ParentId");

                    b.HasKey("Id");

                    b.ToTable("Piranha_MediaFolders");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaMediaVersion", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("FileExtension")
                        .HasMaxLength(8);

                    b.Property<int?>("Height");

                    b.Property<Guid>("MediaId");

                    b.Property<long>("Size");

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.HasIndex("MediaId", "Width", "Height")
                        .IsUnique()
                        .HasFilter("[Height] IS NOT NULL");

                    b.ToTable("Piranha_MediaVersions");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPage", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(N'Page')")
                        .HasMaxLength(255);

                    b.Property<DateTime>("Created");

                    b.Property<bool>("IsHidden");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(256);

                    b.Property<string>("MetaKeywords")
                        .HasMaxLength(128);

                    b.Property<string>("NavigationTitle")
                        .HasMaxLength(128);

                    b.Property<Guid?>("OriginalPageId");

                    b.Property<string>("PageTypeId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<Guid?>("ParentId");

                    b.Property<DateTime?>("Published");

                    b.Property<int>("RedirectType");

                    b.Property<string>("RedirectUrl")
                        .HasMaxLength(256);

                    b.Property<string>("Route")
                        .HasMaxLength(256);

                    b.Property<Guid>("SiteId");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("PageTypeId");

                    b.HasIndex("ParentId");

                    b.HasIndex("SiteId", "Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Pages");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPageBlock", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<Guid>("BlockId");

                    b.Property<Guid>("PageId");

                    b.Property<Guid?>("ParentId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("BlockId");

                    b.HasIndex("PageId", "SortOrder")
                        .IsUnique();

                    b.ToTable("Piranha_PageBlocks");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPageField", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("ClrType")
                        .IsRequired()
                        .HasColumnName("CLRType")
                        .HasMaxLength(256);

                    b.Property<string>("FieldId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<Guid>("PageId");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("PageId", "RegionId", "FieldId", "SortOrder");

                    b.ToTable("Piranha_PageFields");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPageRevision", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Data");

                    b.Property<Guid>("PageId");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.ToTable("Piranha_PageRevisions");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPageType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(64);

                    b.Property<string>("Body");

                    b.Property<string>("ClrType")
                        .HasColumnName("CLRType")
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.HasKey("Id");

                    b.ToTable("Piranha_PageTypes");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaParam", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("Piranha_Params");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPost", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<Guid>("BlogId");

                    b.Property<Guid>("CategoryId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(256);

                    b.Property<string>("MetaKeywords")
                        .HasMaxLength(128);

                    b.Property<string>("PostTypeId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTime?>("Published");

                    b.Property<int>("RedirectType");

                    b.Property<string>("RedirectUrl")
                        .HasMaxLength(256);

                    b.Property<string>("Route")
                        .HasMaxLength(256);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PostTypeId");

                    b.HasIndex("BlogId", "Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Posts");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPostBlock", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<Guid>("BlockId");

                    b.Property<Guid?>("ParentId");

                    b.Property<Guid>("PostId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("BlockId");

                    b.HasIndex("PostId", "SortOrder")
                        .IsUnique();

                    b.ToTable("Piranha_PostBlocks");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPostField", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("ClrType")
                        .IsRequired()
                        .HasColumnName("CLRType")
                        .HasMaxLength(256);

                    b.Property<string>("FieldId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<Guid>("PostId");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("PostId", "RegionId", "FieldId", "SortOrder");

                    b.ToTable("Piranha_PostFields");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPostRevision", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Data");

                    b.Property<Guid>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Piranha_PostRevisions");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPostTag", b =>
                {
                    b.Property<Guid>("PostId");

                    b.Property<Guid>("TagId");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("Piranha_PostTags");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPostType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(64);

                    b.Property<string>("Body");

                    b.Property<string>("ClrType")
                        .HasColumnName("CLRType")
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.HasKey("Id");

                    b.ToTable("Piranha_PostTypes");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaRole", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("Piranha_Roles");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Piranha_RoleClaims");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaSite", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<DateTime?>("ContentLastModified");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Culture")
                        .HasMaxLength(6);

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<string>("Hostnames")
                        .HasMaxLength(256);

                    b.Property<string>("InternalId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<bool>("IsDefault");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("SiteTypeId")
                        .HasMaxLength(64);

                    b.Property<string>("Title")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("InternalId")
                        .IsUnique();

                    b.ToTable("Piranha_Sites");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaSiteField", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("ClrType")
                        .IsRequired()
                        .HasColumnName("CLRType")
                        .HasMaxLength(256);

                    b.Property<string>("FieldId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<Guid>("SiteId");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("SiteId", "RegionId", "FieldId", "SortOrder");

                    b.ToTable("Piranha_SiteFields");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaSiteType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(64);

                    b.Property<string>("Body");

                    b.Property<string>("ClrType")
                        .HasColumnName("CLRType")
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.HasKey("Id");

                    b.ToTable("Piranha_SiteTypes");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaTag", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<Guid>("BlogId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("BlogId", "Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Tags");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaUser", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("Piranha_Users");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Piranha_UserClaims");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaUserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("Piranha_UserLogins");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaUserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Piranha_UserRoles");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaUserToken", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("Piranha_UserTokens");
                });

            modelBuilder.Entity("MvcWeb.TheraLang.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.Property<string>("Details")
                        .HasMaxLength(5000);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("ProjectEnd");

                    b.Property<DateTime>("ProjectStart");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("MvcWeb.TheraLang.Entities.ProjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("projectTypes");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaAlias", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaSite", "Site")
                        .WithMany("PiranhaAliases")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaBlockField", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaBlock", "Block")
                        .WithMany("PiranhaBlockFields")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaCategory", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaPage", "Blog")
                        .WithMany("PiranhaCategories")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaMedia", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaMediaFolder", "Folder")
                        .WithMany("PiranhaMedia")
                        .HasForeignKey("FolderId");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaMediaVersion", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaMedia", "Media")
                        .WithMany("PiranhaMediaVersions")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPage", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaPageType", "PageType")
                        .WithMany("PiranhaPages")
                        .HasForeignKey("PageTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MvcWeb.Db.Entities.PiranhaPage", "Parent")
                        .WithMany("InverseParent")
                        .HasForeignKey("ParentId");

                    b.HasOne("MvcWeb.Db.Entities.PiranhaSite", "Site")
                        .WithMany("PiranhaPages")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPageBlock", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaBlock", "Block")
                        .WithMany("PiranhaPageBlocks")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MvcWeb.Db.Entities.PiranhaPage", "Page")
                        .WithMany("PiranhaPageBlocks")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPageField", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaPage", "Page")
                        .WithMany("PiranhaPageFields")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPageRevision", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaPage", "Page")
                        .WithMany("PiranhaPageRevisions")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPost", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaPage", "Blog")
                        .WithMany("PiranhaPosts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MvcWeb.Db.Entities.PiranhaCategory", "Category")
                        .WithMany("PiranhaPosts")
                        .HasForeignKey("CategoryId");

                    b.HasOne("MvcWeb.Db.Entities.PiranhaPostType", "PostType")
                        .WithMany("PiranhaPosts")
                        .HasForeignKey("PostTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPostBlock", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaBlock", "Block")
                        .WithMany("PiranhaPostBlocks")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MvcWeb.Db.Entities.PiranhaPost", "Post")
                        .WithMany("PiranhaPostBlocks")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPostField", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaPost", "Post")
                        .WithMany("PiranhaPostFields")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPostRevision", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaPost", "Post")
                        .WithMany("PiranhaPostRevisions")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaPostTag", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaPost", "Post")
                        .WithMany("PiranhaPostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MvcWeb.Db.Entities.PiranhaTag", "Tag")
                        .WithMany("PiranhaPostTags")
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaRoleClaim", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaRole", "Role")
                        .WithMany("PiranhaRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaSiteField", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaSite", "Site")
                        .WithMany("PiranhaSiteFields")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaTag", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaPage", "Blog")
                        .WithMany("PiranhaTags")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaUserClaim", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaUser", "User")
                        .WithMany("PiranhaUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaUserLogin", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaUser", "User")
                        .WithMany("PiranhaUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaUserRole", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaRole", "Role")
                        .WithMany("PiranhaUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MvcWeb.Db.Entities.PiranhaUser", "User")
                        .WithMany("PiranhaUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.Db.Entities.PiranhaUserToken", b =>
                {
                    b.HasOne("MvcWeb.Db.Entities.PiranhaUser", "User")
                        .WithMany("PiranhaUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcWeb.TheraLang.Entities.Project", b =>
                {
                    b.HasOne("MvcWeb.TheraLang.Entities.ProjectType", "Type")
                        .WithMany("Projects")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
