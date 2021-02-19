using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedEmployeeRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "693e53fb-db38-494e-a32b-0bf3d7c27a66");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4778e354-ec31-4174-99e0-da1d5c38372b", "d5b05efe-f165-4734-8656-4d1f7a653688", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8fe1659f-6821-4571-9723-af0987b67598", "b6349698-77c6-4224-91ba-7a339fa0a900", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4778e354-ec31-4174-99e0-da1d5c38372b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fe1659f-6821-4571-9723-af0987b67598");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "693e53fb-db38-494e-a32b-0bf3d7c27a66", "473ccdb1-cac4-4f34-87ff-2416cdbcb739", "Customer", "CUSTOMER" });
        }
    }
}
