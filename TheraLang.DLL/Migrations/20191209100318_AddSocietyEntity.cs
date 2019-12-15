using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DLL.Migrations
{
    public partial class AddSocietyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SocietyId",
                table: "Donations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Society",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Society", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donations_SocietyId",
                table: "Donations",
                column: "SocietyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Society_SocietyId",
                table: "Donations",
                column: "SocietyId",
                principalTable: "Society",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Society_SocietyId",
                table: "Donations");

            migrationBuilder.DropTable(
                name: "Society");

            migrationBuilder.DropIndex(
                name: "IX_Donations_SocietyId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "SocietyId",
                table: "Donations");
        }
    }
}
