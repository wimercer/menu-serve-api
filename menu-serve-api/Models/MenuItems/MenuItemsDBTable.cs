using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace menu_serve_api.Models
{
    public class MenuItemsDBTable
    {
        public virtual DbSet<MenuItem> MenuItems { get; set; }

        public void Create(ModelBuilder builder)
        {
            // Table for Menu_Items
            builder.Entity<MenuItem>().ToTable("Menu_Items");

            // Fields for Menu_Items
            builder.Entity<MenuItem>()
                    .Property(i => i.ID)
                        .HasColumnName("ID")
                        .HasColumnType("INT")
                        .IsRequired(true)
                    ;

            builder.Entity<MenuItem>()
                    .Property(i => i.ShortDescription)
                        .HasColumnName("Short_Description")
                        .HasColumnType("NVARCHAR(MAX)")
                        .IsRequired(true)
                    ;

            builder.Entity<MenuItem>()
                    .Property(i => i.Details)
                        .HasColumnName("Details")
                        .HasColumnType("NVARCHAR(MAX)")
                        .IsRequired(true)
                    ;

            builder.Entity<MenuItem>()
                    .Property(i => i.Price)
                        .HasColumnName("Price")
                        .HasColumnType("DECIMAL(10, 2)")
                        .IsRequired(true)
                    ;

            // Constraints for Menu_Items
            builder.Entity<MenuItem>().HasKey(i => i.ID);

            //TODO find a way to seed data using a sequence
            //int idCounter = 0;

            // Seed data to Menu_Items
            /* Data taken from: https://www.goldeneaglemansfield.co.uk/menus/ln18-main-menu-pizza/ */
            builder.Entity<MenuItem>().HasData(
                
                /* Starters (ID = 1) */
                
                new
                {
                    ID = 1,
                    ShortDescription = "Prawn Cocktail",
                    Details = "Prawns with a tangy seafood sauce. Served with brown bread and butter.",
                    Price = 4.30M,
                    MenuCategoryID  = 1,
                    Image = GetMenuItemImage(1)
                },
                new
                {
                    ID = 2,
                    ShortDescription = "Golden Breaded Mushrooms",
                    Details = "Button mushrooms in crispy golden breadcrumbs. Served with BBQ or garlic mayonnaise dip.",
                    Price = 4.20M,
                    MenuCategoryID = 1,
                    Image = GetMenuItemImage(2)
                },
                new
                {
                    ID = 3,
                    ShortDescription = "Soup of the Day",
                    Details = "Please ask for today’s choice. Served with half a baguette and butter.",
                    Price = 3.30M,
                    MenuCategoryID = 1,
                    Image = GetMenuItemImage(3)
                },
                new
                {
                    ID = 4,
                    ShortDescription = "Cajun Popcorn Chicken",
                    Details = "Cajun spiced popcorn chicken served with coleslaw and blue cheese sauce to dunk.",
                    Price = 4.50M,
                    MenuCategoryID = 1,
                    Image = GetMenuItemImage(4)
                },
                new
                {
                    ID = 5,
                    ShortDescription = "Crispy Buttermilk Chicken",
                    Details = "Succulent strips of buttermilk chicken coated in crispy breadcrumbs, with sweet chilli sauce or garlic mayonnaise for dipping.",
                    Price = 4.50M,
                    MenuCategoryID = 1,
                    Image = GetMenuItemImage(5)
                },

                /* Mains (ID = 2) */

                new
                {
                    ID = 6,
                    ShortDescription = "Chicken Tikka Masala",
                    Details = "Chicken breast in a mild tikka masala sauce. Served with rice, naan bread, a poppadum and mango chutney.",
                    Price = 10.45M,
                    MenuCategoryID = 2,
                    Image = GetMenuItemImage(6)
                },
                new
                {
                    ID = 7,
                    ShortDescription = "Sausages & Mash",
                    Details = "Pork sausages on a bed of mashed potato, topped with red onion gravy. Served with garden peas.",
                    Price = 10.00M,
                    MenuCategoryID = 2,
                    Image = GetMenuItemImage(7)
                },
                new
                {
                    ID = 8,
                    ShortDescription = "Rack of Ribs",
                    Details = "Two half racks of sticky BBQ baby back pork ribs, covered in extra BBQ sauce. Served with chips, onion rings, corn on the cob and coleslaw.",
                    Price = 13.95M,
                    MenuCategoryID = 2,
                    Image = GetMenuItemImage(8)
                },
                new
                {
                    ID = 9,
                    ShortDescription = "Beer Battered Fish & Chips",
                    Details = " Beer battered fish served with chips, mushy peas and tartare sauce.",
                    Price = 0.00M,
                    MenuCategoryID = 2,
                    Image = GetMenuItemImage(9)
                },
                new
                {
                    ID = 10,
                    ShortDescription = "10oz Rump Steak",
                    Details = "Garnished with onion rings and half a grilled tomato. Served with chips and peas.",
                    Price = 13.95M,
                    MenuCategoryID = 2,
                    Image = GetMenuItemImage(10)
                },
                new
                {
                    ID = 11,
                    ShortDescription = "10oz Gammon Steak",
                    Details = "Grilled and crowned with a fried egg or pineapple ring. Served with chips and peas.",
                    Price = 11.75M,
                    MenuCategoryID = 2,
                    Image = GetMenuItemImage(11)
                },
                new
                {
                    ID = 12,
                    ShortDescription = "Chicken and Bacon Salad",
                    Details = "A classic combination of roasted chicken breast, sliced bacon and crispy garlic croutons. Mixed leaves, red onion, tomatoes, carrot, cucumber and a classic vinaigrette dressing on the side.",
                    Price = 11.00M,
                    MenuCategoryID = 2,
                    Image = GetMenuItemImage(12)
                },
                new
                {
                    ID = 13,
                    ShortDescription = "The Swiss Burger",
                    Details = "A prime beef burger piled with fried onions, mushrooms and peppers, topped with melting Emmental cheese.",
                    Price = 11.25M,
                    MenuCategoryID = 2,
                    Image = GetMenuItemImage(13)
                },
                new
                {
                    ID = 14,
                    ShortDescription = "Lovely Rita Pizza",
                    Details = "Mozzarella and sliced tomatoes.",
                    Price = 11.45M,
                    MenuCategoryID = 2,
                    Image = GetMenuItemImage(14)
                },
                new
                {
                    ID = 15,
                    ShortDescription = "Mighty Meaty Pizza",
                    Details = "Pepperoni, Wiltshire ham, mini-meatballs, chipotle pulled chicken and Mozzarella.",
                    Price = 15.25M,
                    MenuCategoryID = 2,
                    Image = GetMenuItemImage(15)
                },

                /* Drinks (ID = 3) */

                new
                {
                    ID = 16,
                    ShortDescription = "Bottled Beer",
                    Details = "Finest beer brewed in Austria 5.5%.",
                    Price = 3.10M,
                    MenuCategoryID = 3,
                    Image = GetMenuItemImage(16)
                },
                new
                {
                    ID = 17,
                    ShortDescription = "Bottled Cider",
                    Details = "Finest apple cider made in Cornwall 6%.",
                    Price = 3.00M,
                    MenuCategoryID = 3,
                    Image = GetMenuItemImage(17)
                },
                new
                {
                    ID = 18,
                    ShortDescription = "Bottled Cola",
                    Details = "Cola made in America.",
                    Price = 2.00M,
                    MenuCategoryID = 3,
                    Image = GetMenuItemImage(18)
                },
                new
                {
                    ID = 19,
                    ShortDescription = "Bottled Diet Cola",
                    Details = "Diet Cola made in America.",
                    Price = 1.80M,
                    MenuCategoryID = 3,
                    Image = GetMenuItemImage(19)
                },
                new
                {
                    ID = 20,
                    ShortDescription = "Bottled Water",
                    Details = "Made from volcanic natural springs in France.",
                    Price = 1.80M,
                    MenuCategoryID = 3,
                    Image = GetMenuItemImage(20)
                },

                /* Sides (ID = 4) */

                new
                {
                    ID = 21,
                    ShortDescription = "Skin-on Fries",
                    Details = "Potato fries with the skin left on, cooked in olive oil.",
                    Price = 2.75M,
                    MenuCategoryID = 4,
                    Image = GetMenuItemImage(21)
                },
                new
                {
                    ID = 22,
                    ShortDescription = "Onion Rings",
                    Details = "Stack of Beer battered onion rings cooked in olive oil.",
                    Price = 1.75M,
                    MenuCategoryID = 4,
                    Image = GetMenuItemImage(22)
                },
                new
                {
                    ID = 23,
                    ShortDescription = "Garlic Ciabatta Bread",
                    Details = "Ciabatta bread mixed with garlic and herbs and baked.",
                    Price = 2.00M,
                    MenuCategoryID = 4,
                    Image = GetMenuItemImage(23)
                },
                new
                {
                    ID = 24,
                    ShortDescription = "Chicken Katsu Fries",
                    Details = "Skin-on fries topped with buttermilk chicken pieces, katsu curry sauce and finished with spring onions and crispy onions.",
                    Price = 4.00M,
                    MenuCategoryID = 4,
                    Image = GetMenuItemImage(24)
                },
                new
                {
                    ID = 25,
                    ShortDescription = "Side salad",
                    Details = "Rocket, red onion, and cherry tomatoes. Served on a lettuce leaf with caesar dressing.",
                    Price = 1.95M,
                    MenuCategoryID = 4,
                    Image = GetMenuItemImage(25)
                },

                /* Deserts (ID = 5) */

                new
                {
                    ID = 26,
                    ShortDescription = "Summer Fruits Cheesecake",
                    Details = "Rich cheesecake on a buttery biscuit base heaped with sweet peaches, tangy pineapple and blueberries, finished with a passion fruit glaze and dusted with toasted coconut. Served with vanilla flavour ice cream.",
                    Price = 4.45M,
                    MenuCategoryID = 5,
                    Image = GetMenuItemImage(26)
                },
                new
                {
                    ID = 27,
                    ShortDescription = "Chocolate Fudge Cake",
                    Details = "Rich and gooey. Served cold or warm with vanilla flavour ice cream.",
                    Price = 3.95M,
                    MenuCategoryID = 5,
                    Image = GetMenuItemImage(27)
                },
                new
                {
                    ID = 28,
                    ShortDescription = "Banana & Butterscotch Sundae",
                    Details = "Slices of banana and toffee sauce, in-between layers of banana and butterscotch, and vanilla flavour ice cream. Topped with squirty cream, caramel crunch pieces and a sugar curl.",
                    Price = 4.00M,
                    MenuCategoryID = 5,
                    Image = GetMenuItemImage(28)
                },
                new
                {
                    ID = 29,
                    ShortDescription = "Apple Pie",
                    Details = "A slice of good old pie, served with custard.",
                    Price = 3.70M,
                    MenuCategoryID = 5,
                    Image = GetMenuItemImage(29)
                },
                new
                {
                    ID = 30,
                    ShortDescription = "Jam Roly Poly",
                    Details = "Jam Roly Poly sponge served with custard.",
                    Price = 3.95M,
                    MenuCategoryID = 5,
                    Image = GetMenuItemImage(30)
                }
            );
        }

        public byte[] GetMenuItemImage(int id)
        {
            String imageLocation =  Directory.GetCurrentDirectory() + "/Images/MI-" + id + ".jpg";

            return System.IO.File.ReadAllBytes(imageLocation);
        }
    }
}
