using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class AddedUploadedFiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UploadedFile_News_NewsId",
                table: "UploadedFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UploadedFile",
                table: "UploadedFile");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8bd10943-9f5a-4ac4-81f2-100b828b7cff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34043254-2eac-4ace-8594-99804f537c8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6ce2988-861f-4fe8-abf2-c6c0e8006d34"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9157e0d4-0cbd-469a-b375-018e993645af"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e3de11b-23ac-4036-b038-d68ff9366169"));

            migrationBuilder.RenameTable(
                name: "UploadedFile",
                newName: "UploadedFiles");

            migrationBuilder.RenameIndex(
                name: "IX_UploadedFile_NewsId",
                table: "UploadedFiles",
                newName: "IX_UploadedFiles_NewsId");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "UploadedFiles",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UploadedFiles",
                table: "UploadedFiles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("b4dd1e09-1c4e-4708-b42c-3762e19fe5b5"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("321f7920-529e-4071-9218-c9cb00eb8186"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("dfb7c800-7da2-47c4-8721-eca17ba93ae8"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("51946971-129d-4875-b952-b05339d7e1a9"), null, null, null, "Aan3hRIbng3X5/PqcRAFM6vHFNeIIxAdGH6q4PmZ6R/G0w1fNDPVVMRZ8Myn2Ze5bA==", null, new Guid("b4dd1e09-1c4e-4708-b42c-3762e19fe5b5"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("18375a95-e1a3-4250-9d8c-be33ba7b34d0"), null, null, null, "AfTi2L5K/awzRI0angTcr7iMInC1erhh8YZ7O56oSP7KTLPMV34c/9q6nugcTRXgUQ==", null, new Guid("321f7920-529e-4071-9218-c9cb00eb8186"), "Member" });

            migrationBuilder.AddForeignKey(
                name: "FK_UploadedFiles_News_NewsId",
                table: "UploadedFiles",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UploadedFiles_News_NewsId",
                table: "UploadedFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UploadedFiles",
                table: "UploadedFiles");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dfb7c800-7da2-47c4-8721-eca17ba93ae8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18375a95-e1a3-4250-9d8c-be33ba7b34d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51946971-129d-4875-b952-b05339d7e1a9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("321f7920-529e-4071-9218-c9cb00eb8186"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b4dd1e09-1c4e-4708-b42c-3762e19fe5b5"));

            migrationBuilder.RenameTable(
                name: "UploadedFiles",
                newName: "UploadedFile");

            migrationBuilder.RenameIndex(
                name: "IX_UploadedFiles_NewsId",
                table: "UploadedFile",
                newName: "IX_UploadedFile_NewsId");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "UploadedFile",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UploadedFile",
                table: "UploadedFile",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("9e3de11b-23ac-4036-b038-d68ff9366169"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("9157e0d4-0cbd-469a-b375-018e993645af"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("8bd10943-9f5a-4ac4-81f2-100b828b7cff"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("34043254-2eac-4ace-8594-99804f537c8b"), null, null, null, "AQ7TDd6XVVOOiXODA+x2H2jmF7A6auoK94Xn7nvoV4UuPBKyQW6VYWLVZ2x8aYJ3HQ==", null, new Guid("9e3de11b-23ac-4036-b038-d68ff9366169"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("b6ce2988-861f-4fe8-abf2-c6c0e8006d34"), null, null, null, "AfzMllahcIIIwY+RhhyBWwQ+j1wP9vMCeddWSGwRPRtBdq3Y9pQxBVqBOdOLAfpRVA==", null, new Guid("9157e0d4-0cbd-469a-b375-018e993645af"), "Member" });

            migrationBuilder.AddForeignKey(
                name: "FK_UploadedFile_News_NewsId",
                table: "UploadedFile",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
