using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class UserDetailsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_UserDetails_UserDetailsId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserDetails_detailsId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDetails",
                table: "UserDetails");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("256ab49d-65e8-4690-acac-4b504aaa85f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4aafd7a6-efe3-4608-ae5e-4540a85bce76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5868c1b6-63d4-4800-9701-69b8548d01e4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("04b0b356-b31f-4df7-9779-60b0ba44088f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e549dfbb-3814-4626-b69c-7d183298948d"));

            migrationBuilder.RenameTable(
                name: "UserDetails",
                newName: "UsersDetails");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameTable(
                name: "UsersDetails",
                newName: "UserDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDetails",
                table: "UserDetails",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("e549dfbb-3814-4626-b69c-7d183298948d"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("04b0b356-b31f-4df7-9779-60b0ba44088f"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("256ab49d-65e8-4690-acac-4b504aaa85f5"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "RoleId", "detailsId" },
                values: new object[] { new Guid("5868c1b6-63d4-4800-9701-69b8548d01e4"), "admin@utmm.com", "AcBxtua1oJEO80wcbykTbK2dMdfjzbygxClOzuUnJf0ckGfpHPYny29O/I6pmDbA3A==", new Guid("e549dfbb-3814-4626-b69c-7d183298948d"), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "RoleId", "detailsId" },
                values: new object[] { new Guid("4aafd7a6-efe3-4608-ae5e-4540a85bce76"), "member.@utmm.com", "ARMyoyQwBgildBlkYEaaAAouIL1mlxBX8ZBe4C0dbQHVDwb5lJkwkwb9OJuAzEB8Og==", new Guid("04b0b356-b31f-4df7-9779-60b0ba44088f"), null });

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_UserDetails_UserDetailsId",
                table: "Resources",
                column: "UserDetailsId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserDetails_detailsId",
                table: "Users",
                column: "detailsId",
                principalTable: "UserDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
