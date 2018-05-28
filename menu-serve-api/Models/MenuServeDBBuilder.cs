using Microsoft.EntityFrameworkCore;

namespace menu_serve_api.Models
{
    /* Product */

    public class MenuServeDB
    {
        // Declare Each table model
        private MenuItemsDBTable menuItemsDBTable = new MenuItemsDBTable();

        // Constructor 
        public MenuServeDB(MenuServeDBBuilder builder)
        {
            menuItemsDBTable = builder.menuItemsDBTable;         
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

        public MenuServeDBBuilder(ModelBuilder builder)
        {
            dbModelBuilder = builder;
        }

        private void CreateMenuItems()
        {
            menuItemsDBTable.Create(dbModelBuilder);
        }

        /* Director */

        public MenuServeDB Build()
        {
            // Create each table for model
            this.CreateMenuItems();
            return new MenuServeDB(this);
        }
    }
} 
