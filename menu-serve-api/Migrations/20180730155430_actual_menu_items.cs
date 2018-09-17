using Microsoft.EntityFrameworkCore.Migrations;

namespace menuserveapi.Migrations
{
    public partial class actual_menu_items : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Details", "Price", "Short_Description" },
                values: new object[] { "Prawns with a tangy seafood sauce. Served with brown bread and butter.", 4.30m, "Prawn Cocktail" });

            migrationBuilder.UpdateData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Details", "MenuCategoryID", "Price", "Short_Description" },
                values: new object[] { "Button mushrooms in crispy golden breadcrumbs. Served with BBQ or garlic mayonnaise dip.", 1, 4.20m, "Golden Breaded Mushrooms" });

            migrationBuilder.InsertData(
                table: "Menu_Items",
                columns: new[] { "ID", "Details", "MenuCategoryID", "Price", "Short_Description" },
                values: new object[,]
                {
                    { 28, "Slices of banana and toffee sauce, in-between layers of banana and butterscotch, and vanilla flavour ice cream. Topped with squirty cream, caramel crunch pieces and a sugar curl.", 5, 4.00m, "Banana & Butterscotch Sundae" },
                    { 27, "Rich and gooey. Served cold or warm with vanilla flavour ice cream.", 5, 3.95m, "Chocolate Fudge Cake" },
                    { 26, "Rich cheesecake on a buttery biscuit base heaped with sweet peaches, tangy pineapple and blueberries, finished with a passion fruit glaze and dusted with toasted coconut. Served with vanilla flavour ice cream.", 5, 4.45m, "Summer Fruits Cheesecake" },
                    { 25, "Rocket, red onion, and cherry tomatoes. Served on a lettuce leaf with caesar dressing.", 4, 1.95m, "Side salad" },
                    { 24, "Skin-on fries topped with buttermilk chicken pieces, katsu curry sauce and finished with spring onions and crispy onions.", 4, 4.00m, "Chicken Katsu Fries" },
                    { 23, "Ciabatta bread mixed with garlic and herbs and baked.", 4, 2.00m, "Garlic Ciabatta Bread" },
                    { 22, "Stack of Beer battered onion rings cooked in olive oil.", 4, 1.75m, "Onion Rings" },
                    { 21, "Potato fries with the skin left on, cooked in olive oil.", 4, 2.75m, "Skin-on Fries" },
                    { 20, "Made from volcanic natural springs in France.", 3, 1.80m, "Bottled Water" },
                    { 19, "Diet Cola made in America.", 3, 1.80m, "Bottled Diet Cola" },
                    { 18, "Cola made in America.", 3, 2.00m, "Bottled Cola" },
                    { 17, "Finest apple cider made in Cornwall 6%.", 3, 3.00m, "Bottled Cider" },
                    { 16, "Finest beer brewed in Austria 5.5%.", 3, 3.10m, "Bottled Beer" },
                    { 15, "Pepperoni, Wiltshire ham, mini-meatballs, chipotle pulled chicken and Mozzarella.", 2, 15.25m, "Mighty Meaty Pizza" },
                    { 14, "Mozzarella and sliced tomatoes.", 2, 11.45m, "Lovely Rita Pizza" },
                    { 13, "A prime beef burger piled with fried onions, mushrooms and peppers, topped with melting Emmental cheese.", 2, 11.25m, "The Swiss Burger" },
                    { 12, "A classic combination of roasted chicken breast, sliced bacon and crispy garlic croutons. Mixed leaves, red onion, tomatoes, carrot, cucumber and a classic vinaigrette dressing on the side.", 2, 11.00m, "Chicken and Bacon Salad" },
                    { 11, "Grilled and crowned with a fried egg or pineapple ring. Served with chips and peas.", 2, 11.75m, "10oz Gammon Steak" },
                    { 10, "Garnished with onion rings and half a grilled tomato. Served with chips and peas.", 2, 13.95m, "10oz Rump Steak" },
                    { 9, " Beer battered fish served with chips, mushy peas and tartare sauce.", 2, 0.00m, "Beer Battered Fish & Chips" },
                    { 8, "Two half racks of sticky BBQ baby back pork ribs, covered in extra BBQ sauce. Served with chips, onion rings, corn on the cob and coleslaw.", 2, 13.95m, "Rack of Ribs" },
                    { 7, "Pork sausages on a bed of mashed potato, topped with red onion gravy. Served with garden peas.", 2, 10.00m, "Sausages & Mash" },
                    { 6, "Chicken breast in a mild tikka masala sauce. Served with rice, naan bread, a poppadum and mango chutney.", 2, 10.45m, "Chicken Tikka Masala" },
                    { 5, "Succulent strips of buttermilk chicken coated in crispy breadcrumbs, with sweet chilli sauce or garlic mayonnaise for dipping.", 1, 4.50m, "Crispy Buttermilk Chicken" },
                    { 4, "Cajun spiced popcorn chicken served with coleslaw and blue cheese sauce to dunk.", 1, 4.50m, "Cajun Popcorn Chicken" },
                    { 3, "Please ask for today’s choice. Served with half a baguette and butter.", 1, 3.30m, "Soup of the Day" },
                    { 29, "A slice of good old pie, served with custard.", 5, 3.70m, "Apple Pie" },
                    { 30, "Jam Roly Poly sponge served with custard.", 5, 3.95m, "Jam Roly Poly" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Details", "Price", "Short_Description" },
                values: new object[] { "A long description of what this menu item is", 9.99m, "Short description of item" });

            migrationBuilder.UpdateData(
                table: "Menu_Items",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Details", "MenuCategoryID", "Price", "Short_Description" },
                values: new object[] { "Another long description of what this menu item is", 2, 8.88m, "Another description" });
        }
    }
}
