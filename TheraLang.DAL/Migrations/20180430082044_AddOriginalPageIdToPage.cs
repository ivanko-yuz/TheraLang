using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class AddOriginalPageIdToPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OriginalPageId",
                table: "Piranha_Pages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalPageId",
                table: "Piranha_Pages");
        }
    }
}
