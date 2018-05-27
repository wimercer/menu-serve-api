using Microsoft.EntityFrameworkCore;

namespace menu_serve_api.Models
{
    public partial class MenuServeDBContext : DbContext
    {
        public virtual DbSet<MenuItem> MenuItems { get; set; }

        public MenuServeDBContext(DbContextOptions<MenuServeDBContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
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
                .HasColumnType("decimal(10, 2)");
                ;

            // Constraints for Menu_Items
            builder.Entity<MenuItem>().HasKey(i => i.ID);

            // Seed data to Menu_Items
            builder.Entity<MenuItem>().HasData(new MenuItem
            {
                ID = 1,
                ShortDescription = "Short description of item",
                Details = "A long description of what this menu item is",
                Price = 9.99M
            });


        }
    }
}
