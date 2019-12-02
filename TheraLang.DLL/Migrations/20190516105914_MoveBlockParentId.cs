﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DLL.Migrations
{
    public partial class MoveBlockParentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Piranha_Blocks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Piranha_Blocks");
        }
    }
}
