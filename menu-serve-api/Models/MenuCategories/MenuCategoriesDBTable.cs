using Microsoft.EntityFrameworkCore;

namespace menu_serve_api.Models
{
    public class MenuCategoriesDBTable
    {
        public virtual DbSet<MenuCategory> MenuItems { get; set; }

        public void Create(ModelBuilder builder)
        {
            // Table for Menu_Categories
            builder.Entity<MenuCategory>().ToTable("Menu_Items");

            // Fields for Menu_Categories
            builder.Entity<MenuCategory>()
                    .Property(i => i.ID)
                        .HasColumnName("ID")
                        .IsRequired(true)
                    ;

            builder.Entity<MenuCategory>()
                    .Property(i => i.Name)
                        .HasColumnName("Name")
                        .IsRequired(true)
                    ;

            // Constraints for Menu_Categories
            builder.Entity<MenuCategory>().HasKey(i => i.ID);

            builder.Entity<MenuCategory>();

            // Seed data to Menu_Categories
            builder.Entity<MenuCategory>().HasData(
                new MenuCategory
            {
                ID = 1,
                Name = "Starters"
            }, new MenuCategory
            {
                ID = 2,
                Name = "Mains"
            }, new MenuCategory
            {
                ID = 3,
                Name = "Deserts"
            }, new MenuCategory
            {
                ID = 4,
                Name = "Drinks"
            }, new MenuCategory
            {
                ID = 5,
                Name = "Sides"
            });
        }
    }
}
