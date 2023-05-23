using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cff23f9-e2a3-4ba7-ab5d-a94829389b1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fbee23d-df3c-4cc3-828b-57b702b3befa", "AQAAAAIAAYagAAAAEK06IAfiPwdq73w5K4WePyVlmaqDy0qnkI5ltQrth1HLbBuGCbmmdeqhnB8zarJkeg==", "92280426-a21e-493c-82bf-87119bd8733b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f01229c5-d122-4b3e-9082-f497c84eb08e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7995098-f6be-4a9e-9ea6-3c32cfae2cf8", "AQAAAAIAAYagAAAAEOeL/UAQJtzwHIh1kQNkVGCTVgbTPfAjiy4c7Rv/vkv6B7zR6VLrpRqVFYvOSbL1Fw==", "7b3646b6-f1bb-4215-8419-daddf11e15a7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
