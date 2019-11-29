﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.Web.Migrations
{
    public partial class AddMediaVersionExtension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "Piranha_MediaVersions",
                maxLength: 8,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "Piranha_MediaVersions");
        }
    }
}
