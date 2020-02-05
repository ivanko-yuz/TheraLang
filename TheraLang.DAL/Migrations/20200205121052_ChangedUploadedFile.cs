using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class ChangedUploadedFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("cdbbe497-131f-48a4-be4b-563b2427bd45"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("f61cb741-580a-48a0-90b9-80101fc12b4c"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("e21e329d-d718-434b-8eee-cb2f8bccb023"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("2ccdde82-b6ca-45fd-9dac-421d5def38c7"), null, null, null, "AVAN9CUtyFp6Y88EOkplbDcimOkojwIP9vK6F1veb79zM4w3ce1IBxCdMT7Lve0x3g==", null, new Guid("cdbbe497-131f-48a4-be4b-563b2427bd45"), "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("4f14f4be-91c7-4ffe-a86d-86928f702bb3"), null, null, null, "AUo8yVKmnBxjw9H4GgZg4Ue745ffWD+rIXGsIO7R7tp+4FNfDGZn74BFzR9Vn8B2Uw==", null, new Guid("f61cb741-580a-48a0-90b9-80101fc12b4c"), "Member" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e21e329d-d718-434b-8eee-cb2f8bccb023"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ccdde82-b6ca-45fd-9dac-421d5def38c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f14f4be-91c7-4ffe-a86d-86928f702bb3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cdbbe497-131f-48a4-be4b-563b2427bd45"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f61cb741-580a-48a0-90b9-80101fc12b4c"));

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
        }
    }
}
