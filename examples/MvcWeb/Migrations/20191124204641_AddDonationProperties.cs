using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcWeb.Migrations
{
    public partial class AddDonationProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Donations",
                newName: "DonationId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Donations",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AddColumn<int>(
                name: "AcqId",
                table: "Donations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Donations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LiqpayOrderId",
                table: "Donations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Donations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ReceiverCommission",
                table: "Donations",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Donations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcqId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "LiqpayOrderId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "ReceiverCommission",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Donations");

            migrationBuilder.RenameColumn(
                name: "DonationId",
                table: "Donations",
                newName: "OrderId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Donations",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
