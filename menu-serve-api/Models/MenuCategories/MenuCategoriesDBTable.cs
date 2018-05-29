using Microsoft.EntityFrameworkCore;

namespace menu_serve_api.Models
{
    public class MenuCategoriesDBTable
    {
        public virtual DbSet<MenuCategory> MenuItems { get; set; }

        public void Create(ModelBuilder builder)
        {
            // Table for Menu_Categories
            builder.Entity<MenuCategory>().ToTable("Menu_Categories");

            // Fields for Menu_Categories
            builder.Entity<MenuCategory>()
                    .Property(i => i.ID)
                        .HasColumnType("INT")
                        .IsRequired(true)
                    ;

            builder.Entity<MenuCategory>()
                    .Property(i => i.Name)
                        .HasColumnName("Name")
                        .HasColumnType("NVARCHAR(MAX)")
                        .IsRequired(true)
                    ;

            // Constraints for Menu_Categories
            builder.Entity<MenuCategory>().HasKey(i => i.ID);

            // Seed data to Menu_Categories
            builder.Entity<MenuCategory>().HasData(
                new MenuCategory
            {
                ID = MenuCategoryName.Starters.GetHashCode(),
                Name = MenuCategoryName.Starters
            }, new MenuCategory
            {
                ID = MenuCategoryName.Mains.GetHashCode(),
                Name = MenuCategoryName.Mains
            }, new MenuCategory
            {
                ID = MenuCategoryName.Deserts.GetHashCode(),
                Name = MenuCategoryName.Deserts
            }, new MenuCategory
            {
                ID = MenuCategoryName.Sides.GetHashCode(),
                Name = MenuCategoryName.Sides
            }, new MenuCategory
            {
                ID = MenuCategoryName.Drinks.GetHashCode(),
                Name = MenuCategoryName.Drinks
            });
        }
    }
}
