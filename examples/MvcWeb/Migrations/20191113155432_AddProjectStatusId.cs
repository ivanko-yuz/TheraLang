using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLangWeb.Migrations
{
    public partial class AddProjectStatusId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Projects",
                maxLength: 250,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Projects");
        }
    }
}
