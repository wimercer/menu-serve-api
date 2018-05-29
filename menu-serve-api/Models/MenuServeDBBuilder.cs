using Microsoft.EntityFrameworkCore;

namespace menu_serve_api.Models
{
    /* Product */

    public class MenuServeDB
    {
        // Declare Each table model
        private MenuItemsDBTable menuItemsDBTable = new MenuItemsDBTable();
        private MenuCategoriesDBTable menuCategoriesDBTable = new MenuCategoriesDBTable();

        // Constructor 
        public MenuServeDB(MenuServeDBBuilder builder)
        {
            menuItemsDBTable = builder.menuItemsDBTable;         
            menuCategoriesDBTable = builder.menuCategoriesDBTable;         
        }
    }

    /* Interface */

    public interface IMenuServeDBBuilder
    {
        MenuServeDB Build();
    }

    /* Concrete builder */

    public class MenuServeDBBuilder : IMenuServeDBBuilder
    {
        /// Data entity model builder
        public ModelBuilder dbModelBuilder;

        // Declare each table model
        public MenuItemsDBTable menuItemsDBTable = new MenuItemsDBTable();
        public MenuCategoriesDBTable menuCategoriesDBTable = new MenuCategoriesDBTable();

        public MenuServeDBBuilder(ModelBuilder builder)
        {
            dbModelBuilder = builder;
        }

        private void CreateMenuItems()
        {
            menuItemsDBTable.Create(dbModelBuilder);
        }

        private void CreateMenuCategories()
        {
            menuCategoriesDBTable.Create(dbModelBuilder);
        }

        /* Director */

        public MenuServeDB Build()
        {
            // Create each table for model in order!
            this.CreateMenuCategories();
            this.CreateMenuItems();
            return new MenuServeDB(this);
        }
    }
} 
