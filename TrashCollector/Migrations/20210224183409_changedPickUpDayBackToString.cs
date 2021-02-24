using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class changedPickUpDayBackToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb120adc-0385-4500-8321-1937e1db7d19", "c53b5a5e-110b-4f02-8992-ea53bbacf54c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10e27ab1-b8e7-49ca-8e1b-e080a0cc31c7", "a357a6e4-4e93-4959-b883-d37005ad4793", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10e27ab1-b8e7-49ca-8e1b-e080a0cc31c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb120adc-0385-4500-8321-1937e1db7d19");

            migrationBuilder.AlterColumn<int>(
                name: "PickupDay",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
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
    }
}
