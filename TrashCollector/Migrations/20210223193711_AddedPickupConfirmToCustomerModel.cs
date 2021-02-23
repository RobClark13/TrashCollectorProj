using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedPickupConfirmToCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1078b590-52e3-458b-b233-7c7b89a978b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "def34c29-ee53-42a0-b679-906691b33ec1");

            migrationBuilder.AddColumn<bool>(
                name: "PickupConfirm",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29b28e72-33a5-4b67-8d7a-8cf9db1bbe81", "6aeca553-230a-4570-99bf-d09824789513", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30471bdc-1e31-4ec4-9e20-662382ffc51e", "92926316-ca2c-420b-918d-d98eb4e366c4", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29b28e72-33a5-4b67-8d7a-8cf9db1bbe81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30471bdc-1e31-4ec4-9e20-662382ffc51e");

            migrationBuilder.DropColumn(
                name: "PickupConfirm",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1078b590-52e3-458b-b233-7c7b89a978b2", "5187da60-e71f-45cf-b996-021c531c455b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "def34c29-ee53-42a0-b679-906691b33ec1", "1a5d6cb6-7a4b-4f6d-983e-4fdad9d1197f", "Employee", "EMPLOYEE" });
        }
    }
}
