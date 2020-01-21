using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DLL.Migrations
{
    public partial class AddAliases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Piranha_Aliases",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    AliasUrl = table.Column<string>(maxLength: 256),
                    Created = table.Column<DateTime>(),
                    LastModified = table.Column<DateTime>(),
                    RedirectUrl = table.Column<string>(maxLength: 256),
                    SiteId = table.Column<Guid>(),
                    Type = table.Column<int>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piranha_Aliases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piranha_Aliases_Piranha_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Piranha_Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Piranha_Aliases_SiteId_AliasUrl",
                table: "Piranha_Aliases",
                columns: new[] { "SiteId", "AliasUrl" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piranha_Aliases");
        }
    }
}
