using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestinEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bab794e-6523-4e94-9cda-ba9269a5e17b", "AQAAAAIAAYagAAAAEDOz8Ht5J9xgpcVN07cu9k4Qjr8S8UYJpLMIff2kCgB31gbnXCPOrhVhpVWTXqWqdA==", "255f9f00-5b64-46c9-9aa7-ad3f0a629edb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f01229c5-d122-4b3e-9082-f497c84eb08e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ee249e1-5c7a-4e41-b7d1-ffb7ec9a03b2", "AQAAAAIAAYagAAAAEHNFMdUWZK4NE7zowNyQvn3SoLL+uhzsU/pLSXyBUmsuwry4pJCr8u//WWORLq1Ivg==", "7d8b0c92-4ad7-4f75-85ac-bb9d3c15e2f2" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2037d89-eab1-44dd-b257-a61ab9f143ed", "AQAAAAIAAYagAAAAEMOGvelKrurvWJnqht0AVOkzufNL5SjrmQ7GruW9bR45+cSW92CqUeq5x+BpzYKvGA==", "6f5e60b6-e738-4689-a10b-952bb89213ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f01229c5-d122-4b3e-9082-f497c84eb08e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05a5cd2d-2b88-4065-b195-d1acdac18c9b", "AQAAAAIAAYagAAAAEIlw3Wl4XXNcfWWsYzjN4rTNV/9+PZPkeeqSWRyvHnGGJ+yYYyZubykgn3vnl4fSYg==", "0e912d06-cd58-4af5-9de4-0fda6299aaf8" });
        }
    }
}
