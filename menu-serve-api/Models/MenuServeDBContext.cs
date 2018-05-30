using Microsoft.EntityFrameworkCore;

namespace menu_serve_api.Models
{
    public partial class MenuServeDBContext : DbContext
    {
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<MenuCategory> MenuCategories { get; set; }

        public MenuServeDBContext(DbContextOptions<MenuServeDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            MenuServeDB menuServeDB = (new MenuServeDBBuilder(builder)).Build();
        }
    }
}
