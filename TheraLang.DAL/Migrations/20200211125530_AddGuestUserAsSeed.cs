using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheraLang.DAL.Migrations
{
    public partial class AddGuestUserAsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dd1c415b-34fd-4bb0-ab17-29d6bf3e32d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa642287-ef14-4464-a178-8994911eef8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0c5f4f4-c890-4ea1-8699-130ab8c99e92"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("527a18ba-2562-4f92-b1fd-33348079160c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5ebdb58a-9e96-4bc2-b99f-0b34021cad8d"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("9bd021a0-1ea1-4ca6-9ffb-f322fb4adbca"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("9e4cd935-fa8d-445d-ab1d-d95f51228c5e"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("6d5e494b-11c8-4157-9f07-db0d6163a7cc"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("5271c9d4-7972-40b4-a20c-d2a819286db6"), "admin@utmm.com", null, null, "AUuvMmdpiB8Db4+MU7PIGhXQTxYVuFgvEtEdkeCfFWC0tM5MLb2x3A1MzuYI2MTMlA==", null, new Guid("9bd021a0-1ea1-4ca6-9ffb-f322fb4adbca"), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("eed41e36-1a35-4aea-8a7f-fe1566286a02"), "member@utmm.com", null, null, "AdlkuDR0yhe573bDxEfTVTaRvcF2vFCO+A3dAr5SZjbB0fas0NWyw18kHkM3P8nIaw==", null, new Guid("9e4cd935-fa8d-445d-ab1d-d95f51228c5e"), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("675d347e-8f40-40d8-8f6c-0dabce4a43ad"), "guest@utmm.com", null, null, "AedtQuBC1U9j2udunZ9W+ta40lPA+ZFm6E/bN1fOpxLjXDMUxuY4ONtDVqdOyQw2Cw==", null, new Guid("6d5e494b-11c8-4157-9f07-db0d6163a7cc"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5271c9d4-7972-40b4-a20c-d2a819286db6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("675d347e-8f40-40d8-8f6c-0dabce4a43ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eed41e36-1a35-4aea-8a7f-fe1566286a02"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6d5e494b-11c8-4157-9f07-db0d6163a7cc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9bd021a0-1ea1-4ca6-9ffb-f322fb4adbca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e4cd935-fa8d-445d-ab1d-d95f51228c5e"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("527a18ba-2562-4f92-b1fd-33348079160c"), "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("5ebdb58a-9e96-4bc2-b99f-0b34021cad8d"), "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[] { new Guid("dd1c415b-34fd-4bb0-ab17-29d6bf3e32d0"), "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("aa642287-ef14-4464-a178-8994911eef8d"), "admin@utmm.com", null, null, "AS/RP/IyJp+fboy9nTN0FxuwSlvpEv8hePf/JcNwK78vrF4AwUaun2C7jHC85DFepQ==", null, new Guid("527a18ba-2562-4f92-b1fd-33348079160c"), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { new Guid("c0c5f4f4-c890-4ea1-8699-130ab8c99e92"), "member@utmm.com", null, null, "ASnI+3a02jHBC0JV2346BTbDto11GUglHEL48tdMxRc3g7hfLA1CquCQcRkncs3/pQ==", null, new Guid("5ebdb58a-9e96-4bc2-b99f-0b34021cad8d"), null });
        }
    }
}
