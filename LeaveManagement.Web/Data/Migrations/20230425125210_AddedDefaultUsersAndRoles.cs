using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4691f418-660f-41ab-a9b6-4bbd24c7c76d", null, "User", "USER" },
                    { "f072ffe7-ace9-4ea6-986c-39a821cbb0d7", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c", 0, "173aecad-19df-4db8-b609-804e71144b2e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEI14BmHun1PaTQB1NX8V6eID8Dbz9d3iQk7ac5GeWeEOcKaSw+3ZC1TdHDRsQ2WT9A==", null, false, "3a1ca48b-9982-4e08-9369-94e2e1db5ff6", null, false, null },
                    { "f01229c5-d122-4b3e-9082-f497c84eb08e", 0, "65204123-c827-496e-9c9c-4abb38471658", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEOgYPNKctjpRdGP5t2a8x+u/GSi1mfXly6I0QH2ZNIiL018UG4IOmIOXNoNXHSvP6Q==", null, false, "5753c85b-2030-4092-bc59-8cbf3888c666", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4691f418-660f-41ab-a9b6-4bbd24c7c76d", "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c" },
                    { "f072ffe7-ace9-4ea6-986c-39a821cbb0d7", "f01229c5-d122-4b3e-9082-f497c84eb08e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4691f418-660f-41ab-a9b6-4bbd24c7c76d", "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f072ffe7-ace9-4ea6-986c-39a821cbb0d7", "f01229c5-d122-4b3e-9082-f497c84eb08e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4691f418-660f-41ab-a9b6-4bbd24c7c76d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f072ffe7-ace9-4ea6-986c-39a821cbb0d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f01229c5-d122-4b3e-9082-f497c84eb08e");
        }
    }
}
