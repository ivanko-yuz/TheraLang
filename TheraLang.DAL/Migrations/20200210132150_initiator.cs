using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class initiator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResourceCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Society",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Society", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    StatusId = table.Column<int>(maxLength: 250, nullable: false, defaultValue: 0),
                    Description = table.Column<string>(maxLength: 5000, nullable: false),
                    Details = table.Column<string>(maxLength: 5000, nullable: true),
                    ProjectStart = table.Column<DateTime>(nullable: false),
                    ProjectEnd = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    DonationTarget = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_ProjectTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ProjectTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectId = table.Column<int>(nullable: true),
                    SocietyId = table.Column<int>(nullable: true),
                    DonationId = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Currency = table.Column<string>(nullable: false),
                    PaymentId = table.Column<int>(nullable: false),
                    LiqpayOrderId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donations_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Donations_Society_SocietyId",
                        column: x => x.SocietyId,
                        principalTable: "Society",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectParticipations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedById = table.Column<Guid>(nullable: false),
                    UpdatedById = table.Column<Guid>(nullable: true),
                    CreatedDateUtc = table.Column<DateTime>(nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    Role = table.Column<int>(nullable: false, defaultValue: 0),
                    Status = table.Column<int>(nullable: false, defaultValue: 0),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectParticipations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectParticipations_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectParticipations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedById = table.Column<Guid>(nullable: false),
                    UpdatedById = table.Column<Guid>(nullable: true),
                    CreatedDateUtc = table.Column<DateTime>(nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 5000, nullable: false),
                    Url = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    File = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resources_ResourceCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ResourceCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resources_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ResourceId = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(maxLength: 250, nullable: true),
                    Path = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceAttachments_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceToProject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ResourceId = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceToProject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceToProject_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResourceToProject_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("726c101d-6403-4f00-9f88-329c46c1db75"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("c8f7d31e-5f2f-4393-b0e7-e4a940ef6c19"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("a39b771b-7ebe-4613-a898-28e2a6186c8c"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("7c3ef144-4d17-448e-aabd-ca67d75ec526"), null, null, null, "AZC4tItUQgQOn1MxSeQFseGq72TgPddobEkwVo+dLVKSB00KtcBHoGi21D3hEhB0tQ==", null, new Guid("726c101d-6403-4f00-9f88-329c46c1db75"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("f7ec2eaa-cd4c-4940-bfb3-6dca7a6c2afa"), null, null, null, "AUAIURZDnkclU4bVjsmkSgJBgAkWuYcDFxCqcFd1yAHEeMnyEb9G7Gl/JBqWSPcgfQ==", null, new Guid("c8f7d31e-5f2f-4393-b0e7-e4a940ef6c19"), "Member" });

            migrationBuilder.CreateIndex(
                name: "IX_Donations_ProjectId",
                table: "Donations",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_SocietyId",
                table: "Donations",
                column: "SocietyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticipations_ProjectId",
                table: "ProjectParticipations",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticipations_UserId",
                table: "ProjectParticipations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TypeId",
                table: "Projects",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTypes_TypeName",
                table: "ProjectTypes",
                column: "TypeName",
                unique: true,
                filter: "[TypeName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAttachments_ResourceId",
                table: "ResourceAttachments",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CategoryId",
                table: "Resources",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CreatedById",
                table: "Resources",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_Name",
                table: "Resources",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResourceToProject_ProjectId",
                table: "ResourceToProject",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceToProject_ResourceId",
                table: "ResourceToProject",
                column: "ResourceId");

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
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "ProjectParticipations");

            migrationBuilder.DropTable(
                name: "ResourceAttachments");

            migrationBuilder.DropTable(
                name: "ResourceToProject");

            migrationBuilder.DropTable(
                name: "Society");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "ProjectTypes");

            migrationBuilder.DropTable(
                name: "ResourceCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
