using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class TheraLangBaseMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Projects",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Projects",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Projects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectEnd",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectStart",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Projects",
                maxLength: 250,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectId = table.Column<int>(),
                    DonationId = table.Column<string>(nullable: true),
                    Status = table.Column<string>(),
                    Amount = table.Column<decimal>(),
                    Currency = table.Column<string>(),
                    PaymentId = table.Column<int>(),
                    LiqpayOrderId = table.Column<string>(),
                    TransactionId = table.Column<int>(),
                    ReceiverCommission = table.Column<decimal>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donations_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectParticipations",
                columns: table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedById = table.Column<Guid>(),
                    UpdatedById = table.Column<Guid>(nullable: true),
                    CreatedDateUtc = table.Column<DateTime>(),
                    UpdatedDateUtc = table.Column<DateTime>(nullable: true),
                    Role = table.Column<int>(nullable: false, defaultValue: 0),
                    Status = table.Column<int>(nullable: false, defaultValue: 0),
                    ProjectId = table.Column<int>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectParticipations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectParticipations_Piranha_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Piranha_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectParticipations_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>()
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
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 50)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedById = table.Column<Guid>(),
                    UpdatedById = table.Column<Guid>(nullable: true),
                    CreatedDateUtc = table.Column<DateTime>(),
                    UpdatedDateUtc = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50),
                    Description = table.Column<string>(maxLength: 5000),
                    Url = table.Column<string>(nullable: true),
                    File = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>()
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
                        name: "FK_Resources_Piranha_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Piranha_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceToProject",
                columns: table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ResourceId = table.Column<int>(),
                    ProjectId = table.Column<int>()
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

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TypeId",
                table: "Projects",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_ProjectId",
                table: "Donations",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticipations_CreatedById",
                table: "ProjectParticipations",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticipations_ProjectId",
                table: "ProjectParticipations",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTypes_TypeName",
                table: "ProjectTypes",
                column: "TypeName",
                unique: true,
                filter: "[TypeName] IS NOT NULL");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectTypes_TypeId",
                table: "Projects",
                column: "TypeId",
                principalTable: "ProjectTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectTypes_TypeId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "ProjectParticipations");

            migrationBuilder.DropTable(
                name: "ProjectTypes");

            migrationBuilder.DropTable(
                name: "ResourceToProject");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "ResourceCategories");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TypeId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectEnd",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectStart",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Projects",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }
    }
}
