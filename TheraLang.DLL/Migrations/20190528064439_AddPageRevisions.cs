using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DLL.Migrations
{
    public partial class AddPageRevisions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Piranha_PageRevisions",
                columns: table => new
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
                        name: "FK_Piranha_PageRevisions_Piranha_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Piranha_Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_PageRevisions_PageId",
                table: "Piranha_PageRevisions",
                column: "PageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piranha_PageRevisions");
        }
    }
}
