using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class RemovingSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0bee0b57-4565-40b8-bf86-8e69de19faeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("207ee89c-f9a3-4298-8222-1313f3b51763"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b43bfb40-9b4c-43ad-ae20-fb97e9ae2bd8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("87cdb9e5-d045-4bf5-bdc8-1aeb0775ce0f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e2f83ba7-18c7-4e9d-b76a-4e9c6308f33d"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UsersDetails",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UsersDetails",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UsersDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UsersDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("87cdb9e5-d045-4bf5-bdc8-1aeb0775ce0f"), "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e2f83ba7-18c7-4e9d-b76a-4e9c6308f33d"), "Member" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0bee0b57-4565-40b8-bf86-8e69de19faeb"), "Guest" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "RoleId" },
                values: new object[] { new Guid("207ee89c-f9a3-4298-8222-1313f3b51763"), "admin", "AQSTnm4Y8SWCVvp45rNsMVXtRXvY5wb3GdAXWJNwV4oPYzw2bVOmpTjGj8LYgbtvYA==", new Guid("87cdb9e5-d045-4bf5-bdc8-1aeb0775ce0f") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "RoleId" },
                values: new object[] { new Guid("b43bfb40-9b4c-43ad-ae20-fb97e9ae2bd8"), "member", "AeteLx1PMZZaAJQBTKb5U1w3oyLzMg5l4wAsG4oea4Xx4z8znHEKSIk3K/m+0A0grQ==", new Guid("e2f83ba7-18c7-4e9d-b76a-4e9c6308f33d") });
        }
    }
}
