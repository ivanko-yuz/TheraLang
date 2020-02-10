using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class FixedNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("67d5f889-7b57-44e5-a22c-5c9ac7016892"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02360fe1-e470-49fc-8e4d-843520c81196"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("973fd9ff-d3f9-42d8-8c6e-5a5ea14c36d2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3982c8bb-ced6-4538-b5d7-94d025a1a2eb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("88a04f5f-b493-4eaa-a82e-13fd903692e5"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("3982c8bb-ced6-4538-b5d7-94d025a1a2eb"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("88a04f5f-b493-4eaa-a82e-13fd903692e5"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("67d5f889-7b57-44e5-a22c-5c9ac7016892"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("973fd9ff-d3f9-42d8-8c6e-5a5ea14c36d2"), null, null, null, "AbJ3qO9Lgv6eTbklGeRCDdZuH67ylEcszOe+BGc+MiiIc8cCBezM3fNqwmK+i4K/gQ==", null, new Guid("3982c8bb-ced6-4538-b5d7-94d025a1a2eb"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("02360fe1-e470-49fc-8e4d-843520c81196"), null, null, null, "AaYl2XN7Eq9Y1S+Z/PIWEtSEBDZyN2UhZL0ZPDahmoIN+/n9/GVbghqnXzJu+955qQ==", null, new Guid("88a04f5f-b493-4eaa-a82e-13fd903692e5"), "Member" });
        }
    }
}
