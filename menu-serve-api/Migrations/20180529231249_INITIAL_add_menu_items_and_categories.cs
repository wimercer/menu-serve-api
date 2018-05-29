using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace menuserveapi.Migrations
{
    public partial class INITIAL_add_menu_items_and_categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menu_Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menu_Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Short_Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Details = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Price = table.Column<decimal>(type: "DECIMAL(10, 2)", nullable: false),
                    MenuCategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu_Items", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menu_Items_Menu_Categories_MenuCategoryID",
                        column: x => x.MenuCategoryID,
                        principalTable: "Menu_Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Menu_Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Starters" },
                    { 2, "Mains" },
                    { 3, "Deserts" },
                    { 4, "Sides" },
                    { 5, "Drinks" }
                });

            migrationBuilder.InsertData(
                table: "Menu_Items",
                columns: new[] { "ID", "Details", "MenuCategoryID", "Price", "Short_Description" },
                values: new object[] { 1, "A long description of what this menu item is", 1, 9.99m, "Short description of item" });

            migrationBuilder.InsertData(
                table: "Menu_Items",
                columns: new[] { "ID", "Details", "MenuCategoryID", "Price", "Short_Description" },
                values: new object[] { 2, "Another long description of what this menu item is", 2, 8.88m, "Another description" });

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Items_MenuCategoryID",
                table: "Menu_Items",
                column: "MenuCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu_Items");

            migrationBuilder.DropTable(
                name: "Menu_Categories");
        }
    }
}
