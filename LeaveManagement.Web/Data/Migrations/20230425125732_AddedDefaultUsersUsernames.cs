using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersUsernames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7816115d-b21f-4a41-b9c2-119246b23f62", true, "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFrLASWMB2CJ6u7gx5s5gv0H97W0+UPYo+zihob/FIzK8AX0WodtUAwtcmnYN7PU3Q==", "0f229cc0-e1ed-447c-b890-a2cdc7030d51", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f01229c5-d122-4b3e-9082-f497c84eb08e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7586a4cb-4569-4205-97f7-1ff530fbabd9", true, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEM9AtTLQa7BJYn1akdKzlbAQPMQblHlmH1dlebYdmjoWPBxLlGo0cWf+R1wjjjJlnA==", "57b37b70-82bd-40cd-914a-a9eb7df7887f", "admin@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "173aecad-19df-4db8-b609-804e71144b2e", false, null, "AQAAAAIAAYagAAAAEI14BmHun1PaTQB1NX8V6eID8Dbz9d3iQk7ac5GeWeEOcKaSw+3ZC1TdHDRsQ2WT9A==", "3a1ca48b-9982-4e08-9369-94e2e1db5ff6", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f01229c5-d122-4b3e-9082-f497c84eb08e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "65204123-c827-496e-9c9c-4abb38471658", false, null, "AQAAAAIAAYagAAAAEOgYPNKctjpRdGP5t2a8x+u/GSi1mfXly6I0QH2ZNIiL018UG4IOmIOXNoNXHSvP6Q==", "5753c85b-2030-4092-bc59-8cbf3888c666", null });
        }
    }
}
