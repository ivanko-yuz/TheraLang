using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DLL.Migrations
{
    public partial class Donation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Projects_ProjectId",
                table: "Donations");

            migrationBuilder.AddColumn<decimal>(
                name: "DonationTarget",
                table: "Projects",
                type: "decimal(5, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "ReceiverCommission",
                table: "Donations",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Donations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Donations",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<int>(
                name: "SocietyId",
                table: "Donations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Society",
                columns: table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>()
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
                name: "FK_Donations_Projects_ProjectId",
                table: "Donations",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Society_SocietyId",
                table: "Donations",
                column: "SocietyId",
                principalTable: "Society",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Projects_ProjectId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Society_SocietyId",
                table: "Donations");

            migrationBuilder.DropTable(
                name: "Society");

            migrationBuilder.DropIndex(
                name: "IX_Donations_SocietyId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DonationTarget",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "SocietyId",
                table: "Donations");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReceiverCommission",
                table: "Donations",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Donations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Donations",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

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
