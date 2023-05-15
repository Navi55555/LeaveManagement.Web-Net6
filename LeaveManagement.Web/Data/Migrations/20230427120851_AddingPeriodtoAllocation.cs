using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodtoAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7816115d-b21f-4a41-b9c2-119246b23f62", "AQAAAAIAAYagAAAAEFrLASWMB2CJ6u7gx5s5gv0H97W0+UPYo+zihob/FIzK8AX0WodtUAwtcmnYN7PU3Q==", "0f229cc0-e1ed-447c-b890-a2cdc7030d51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f01229c5-d122-4b3e-9082-f497c84eb08e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7586a4cb-4569-4205-97f7-1ff530fbabd9", "AQAAAAIAAYagAAAAEM9AtTLQa7BJYn1akdKzlbAQPMQblHlmH1dlebYdmjoWPBxLlGo0cWf+R1wjjjJlnA==", "57b37b70-82bd-40cd-914a-a9eb7df7887f" });
        }
    }
}
