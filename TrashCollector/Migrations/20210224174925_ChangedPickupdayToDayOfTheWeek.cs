using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class ChangedPickupdayToDayOfTheWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29b28e72-33a5-4b67-8d7a-8cf9db1bbe81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30471bdc-1e31-4ec4-9e20-662382ffc51e");

            migrationBuilder.AlterColumn<int>(
                name: "PickupDay",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da594351-2c44-4686-9d7d-b5c4462a5b78", "5c5f5230-6d51-4fa5-99f8-596713768cc5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9818226-74f9-486b-a470-3b6b11edf265", "3c95aaad-14e2-491a-b6d1-0fcef8ad9214", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9818226-74f9-486b-a470-3b6b11edf265");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da594351-2c44-4686-9d7d-b5c4462a5b78");

            migrationBuilder.AlterColumn<string>(
                name: "PickupDay",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29b28e72-33a5-4b67-8d7a-8cf9db1bbe81", "6aeca553-230a-4570-99bf-d09824789513", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30471bdc-1e31-4ec4-9e20-662382ffc51e", "92926316-ca2c-420b-918d-d98eb4e366c4", "Employee", "EMPLOYEE" });
        }
    }
}
