using Microsoft.EntityFrameworkCore.Migrations;

namespace menuserveapi.Migrations
{
    public partial class removed_enum_type_added_menu_order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Menu_Categories",
                type: "INT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Menu_Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "DisplayOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Menu_Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "DisplayOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Menu_Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 5, "Drinks" });

            migrationBuilder.UpdateData(
                table: "Menu_Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "DisplayOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Menu_Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 3, "Deserts" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Menu_Categories");

            migrationBuilder.UpdateData(
                table: "Menu_Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Deserts");

            migrationBuilder.UpdateData(
                table: "Menu_Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "Drinks");
        }
    }
}
