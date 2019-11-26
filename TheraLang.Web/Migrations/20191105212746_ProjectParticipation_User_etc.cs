using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWeb.Migrations
{
    public partial class ProjectParticipation_User_etc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedbyId",
                table: "Resources",
                newName: "UpdatedById");

            migrationBuilder.RenameColumn(
                name: "UpdatedDateUTC",
                table: "Resources",
                newName: "UpdatedDateUtc");

            migrationBuilder.RenameColumn(
                name: "URL",
                table: "Resources",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "CreatedbyId",
                table: "Resources",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "CreatedDateUTC",
                table: "Resources",
                newName: "CreatedDateUtc");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "File",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Resources",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    IsEmailConfirmed = table.Column<bool>(nullable: false),
                    PhooneNumber = table.Column<string>(nullable: false),
                    IsPhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectParticipations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedById = table.Column<int>(nullable: false),
                    UpdatedById = table.Column<int>(nullable: true),
                    CreatedDateUtc = table.Column<DateTime>(nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
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

            migrationBuilder.CreateIndex(
                name: "IX_Resources_UserId",
                table: "Resources",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticipations_ProjectId",
                table: "ProjectParticipations",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticipations_UserId",
                table: "ProjectParticipations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Users_UserId",
                table: "Resources",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Users_UserId",
                table: "Resources");

            migrationBuilder.DropTable(
                name: "ProjectParticipations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Resources_UserId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Resources");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Resources",
                newName: "URL");

            migrationBuilder.RenameColumn(
                name: "UpdatedDateUtc",
                table: "Resources",
                newName: "UpdatedDateUTC");

            migrationBuilder.RenameColumn(
                name: "UpdatedById",
                table: "Resources",
                newName: "UpdatedbyId");

            migrationBuilder.RenameColumn(
                name: "CreatedDateUtc",
                table: "Resources",
                newName: "CreatedDateUTC");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Resources",
                newName: "CreatedbyId");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "File",
                table: "Resources",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
