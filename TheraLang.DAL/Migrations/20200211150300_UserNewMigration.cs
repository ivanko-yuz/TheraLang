using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class UserNewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_UsersDetails_UserDetailsId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UsersDetails_detailsId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersDetails",
                table: "UsersDetails");

            migrationBuilder.DropIndex(
                name: "IX_Users_detailsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "Roles");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e42c3b16-d85a-4062-818d-60803b01eb68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39e59d3e-587d-40be-a9c4-bf1791c27ca5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a445be14-2d59-4acf-a348-859e1bd0172f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2623434f-59a6-4e47-a1de-4604dd23cc24"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4b7c185a-7400-4f58-b589-dca06adbfc79"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UsersDetails");

            migrationBuilder.DropColumn(
                name: "detailsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "Roles");

            migrationBuilder.AddColumn<Guid>(
                name: "UserDetailsId",
                table: "UsersDetails",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersDetails",
                table: "UsersDetails",
                column: "UserDetailsId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_UsersDetails_UserDetailsId",
                table: "Resources",
                column: "UserDetailsId",
                principalTable: "UsersDetails",
                principalColumn: "UserDetailsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersDetails_Users_UserDetailsId",
                table: "UsersDetails",
                column: "UserDetailsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_UsersDetails_UserDetailsId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersDetails_Users_UserDetailsId",
                table: "UsersDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersDetails",
                table: "UsersDetails");

            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

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

            migrationBuilder.DropColumn(
                name: "UserDetailsId",
                table: "UsersDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UsersDetails",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "detailsId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "Roles",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersDetails",
                table: "UsersDetails",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("2623434f-59a6-4e47-a1de-4604dd23cc24"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("4b7c185a-7400-4f58-b589-dca06adbfc79"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("e42c3b16-d85a-4062-818d-60803b01eb68"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "RoleId", "detailsId" },
                values: new object[] { new Guid("a445be14-2d59-4acf-a348-859e1bd0172f"), "admin", "AVIeJ5eWM+T7zd/NSYt9LuRJXfubjaFPpU/Jfy4PFkThmglmZKerapidYATtMXy/CQ==", new Guid("2623434f-59a6-4e47-a1de-4604dd23cc24"), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "RoleId", "detailsId" },
                values: new object[] { new Guid("39e59d3e-587d-40be-a9c4-bf1791c27ca5"), "member", "AXOgjF7xf921FD+mPlaICj23gsc9LOqkm+1YF9c22wfM7v2SLNSmSGcUFrV36+Gj7A==", new Guid("4b7c185a-7400-4f58-b589-dca06adbfc79"), null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_detailsId",
                table: "Users",
                column: "detailsId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_UsersDetails_UserDetailsId",
                table: "Resources",
                column: "UserDetailsId",
                principalTable: "UsersDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UsersDetails_detailsId",
                table: "Users",
                column: "detailsId",
                principalTable: "UsersDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
