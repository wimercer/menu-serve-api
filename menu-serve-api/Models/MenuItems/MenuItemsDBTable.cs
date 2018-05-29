using Microsoft.EntityFrameworkCore;

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
            
            // Seed data to Menu_Items
            builder.Entity<MenuItem>().HasData(
                new
                {
                    ID = 1,
                    ShortDescription = "Short description of item",
                    Details = "A long description of what this menu item is",
                    Price = 9.99M,
                    MenuCategoryID  = 1 // Starters
                },
                new
                {
                    ID = 2,
                    ShortDescription = "Another description",
                    Details = "Another long description of what this menu item is",
                    Price = 8.88M,
                    MenuCategoryID = 2 // Mains
                });
        }
    }
}
