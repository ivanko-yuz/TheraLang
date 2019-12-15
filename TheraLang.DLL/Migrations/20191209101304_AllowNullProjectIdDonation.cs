using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DLL.Migrations
{
    public partial class AllowNullProjectIdDonation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Projects_ProjectId",
                table: "Donations");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Donations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Projects_ProjectId",
                table: "Donations",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Projects_ProjectId",
                table: "Donations");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Donations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Projects_ProjectId",
                table: "Donations",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
