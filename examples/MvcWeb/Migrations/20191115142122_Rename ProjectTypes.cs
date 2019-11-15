using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWeb.Migrations
{
    public partial class RenameProjectTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_projectTypes_Id",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projectTypes",
                table: "projectTypes");

            migrationBuilder.RenameTable(
                name: "projectTypes",
                newName: "Types");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Types_Id",
                table: "Projects",
                column: "Id",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Types_Id",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.RenameTable(
                name: "Types",
                newName: "projectTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projectTypes",
                table: "projectTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_projectTypes_Id",
                table: "Projects",
                column: "Id",
                principalTable: "projectTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
