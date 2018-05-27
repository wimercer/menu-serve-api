using Microsoft.EntityFrameworkCore.Migrations;

namespace menuserveapi.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menu_Items",
                columns: new[] { "ID", "Details", "Price", "Short_Description" },
                values: new object[] { 1, "A long description of what this menu item is", 9.99m, "Short description of item" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
