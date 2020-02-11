using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class AddedLikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("614df049-c120-4a28-ac9a-263579a022a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66e587b3-a509-450c-94a5-ce768bbf69c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a20409a7-a1d0-44da-b75d-d4ad823d824e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4983909f-1d61-4fcd-8942-12de5b8ecac2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("59754db9-96ef-4bad-b635-01febfa74305"));

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "Users",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("fbd4c7f4-f9e0-4b26-90c3-77d60dc6aaa8"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("e23173e3-0100-4168-8749-feac19cb67a6"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("a22a84c1-b521-4fdd-be82-d53af1678454"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NewsId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("626a13ae-dfea-4b1e-ade0-0559f03e3d09"), null, null, null, null, "AR5zhteUxeVRX0A79lIEV+uF+XAeH5l0Ua1XxziAyOc9LHTyraYVPh3b6Jk0O3cwWA==", null, new Guid("fbd4c7f4-f9e0-4b26-90c3-77d60dc6aaa8"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NewsId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("829e3ee1-7fe8-4e24-85ca-f17c4a9b2917"), null, null, null, null, "AXC2LWqMpJYop0oS86PocFR7RKTBwxUG33n11qheevKRbgrJpvmzcgQDFXICGqXL5g==", null, new Guid("e23173e3-0100-4168-8749-feac19cb67a6"), "Member" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_NewsId",
                table: "Users",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_News_NewsId",
                table: "Users",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_News_NewsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_NewsId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a22a84c1-b521-4fdd-be82-d53af1678454"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("626a13ae-dfea-4b1e-ade0-0559f03e3d09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("829e3ee1-7fe8-4e24-85ca-f17c4a9b2917"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e23173e3-0100-4168-8749-feac19cb67a6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fbd4c7f4-f9e0-4b26-90c3-77d60dc6aaa8"));

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("4983909f-1d61-4fcd-8942-12de5b8ecac2"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("59754db9-96ef-4bad-b635-01febfa74305"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("614df049-c120-4a28-ac9a-263579a022a7"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("a20409a7-a1d0-44da-b75d-d4ad823d824e"), null, null, null, "Ae8y7WJGRLzJugqwoIfs3Qv0yhkW6B0sAhPNzQyGUWyH4ouVE7hs3zBUObWvunRL3w==", null, new Guid("4983909f-1d61-4fcd-8942-12de5b8ecac2"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("66e587b3-a509-450c-94a5-ce768bbf69c0"), null, null, null, "AfC/uoIdAj/nDMBjTT/8NKdxr0WcdI1/TJl6lkRnTaIr2Ls5MmzYGRsL9WMXDcFIOQ==", null, new Guid("59754db9-96ef-4bad-b635-01febfa74305"), "Member" });
        }
    }
}
