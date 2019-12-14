using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DLL.Migrations
{
    public partial class attachFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResourceAttachment_Resources_ResourceId",
                table: "ResourceAttachment");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceAttachment_Resources_ResourceId",
                table: "ResourceAttachment",
                column: "ResourceId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResourceAttachment_Resources_ResourceId",
                table: "ResourceAttachment");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceAttachment_Resources_ResourceId",
                table: "ResourceAttachment",
                column: "ResourceId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
