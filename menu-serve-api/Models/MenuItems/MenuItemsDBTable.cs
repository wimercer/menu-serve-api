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
                        .IsRequired(true)
                    ;

            builder.Entity<MenuItem>()
                    .Property(i => i.ShortDescription)
                        .HasColumnName("Short_Description")
                    ;

            builder.Entity<MenuItem>()
                    .Property(i => i.Details)
                        .HasColumnName("Details")
                    ;

            builder.Entity<MenuItem>()
                    .Property(i => i.Price)
                        .HasColumnName("Price")
                        .HasColumnType("decimal(10, 2)")
                    ;

            builder.Entity<MenuItem>()
                    .Property(i => i.MenuCategory)
                        .HasColumnName("Menu_Category_ID")
                    ;


            // Constraints for Menu_Items
            builder.Entity<MenuItem>().HasKey(i => i.ID);
            //builder.Entity<MenuItem>().HasKey(c => c.MenuCategory);

            // GRRR....
            builder.Entity<MenuItem>()
                .OwnsOne(c => c.MenuCategory).HasForeignKey(c => c.ID)
                ;



            //builder.Entity<MenuItem>().HasAlternateKey(c => new { c.MenuCategory.ID });

            // Relationships

            //builder.Entity<MenuItem>()
            //    .HasOne(c => c.MenuCategory);



            // Seed data to Menu_Items
            //builder.Entity<MenuItem>().HasData(
            //    new MenuItem
            //    {
            //        ID = 1,
            //        ShortDescription = "Short description of item",
            //        Details = "A long description of what this menu item is",
            //        Price = 9.99M,
            //        MenuCategory = new MenuCategory
            //        {
            //            ID = 1,
            //            Name = "Starters" //what happens when not declared
            //        }
            //});
        }
    }
}
