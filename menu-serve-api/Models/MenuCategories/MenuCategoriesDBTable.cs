using Microsoft.EntityFrameworkCore;

namespace menu_serve_api.Models
{
    public class MenuCategoriesDBTable
    {
        public virtual DbSet<MenuCategory> MenuCategories { get; set; }

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

            // Fields for Menu_Categories
            builder.Entity<MenuCategory>()
                    .Property(i => i.DisplayOrder)
                        .HasColumnType("INT")
                        .IsRequired(true)
                    ;

            // Constraints for Menu_Categories
            builder.Entity<MenuCategory>().HasKey(i => i.ID);

            // Seed data to Menu_Categories
            builder.Entity<MenuCategory>().HasData(
                new MenuCategory
            {
                ID = 1,
                Name = "Starters",
                DisplayOrder = 1
            }, new MenuCategory
            {
                ID = 2,
                Name = "Mains",
                DisplayOrder = 2
            }, new MenuCategory
            {
                ID = 3,
                Name = "Drinks",
                DisplayOrder = 5
            }, new MenuCategory
            {
                ID = 4,
                Name = "Sides",
                DisplayOrder = 4
            }, new MenuCategory
            {
                ID = 5,
                Name = "Deserts",
                DisplayOrder = 3
            });
        }
    }
}
