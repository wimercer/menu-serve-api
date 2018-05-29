using System.Collections.Generic;

namespace menu_serve_api.Models
{
    public enum MenuCategoryName
    {
        Starters = 1,
        Mains = 2,
        Deserts = 3,
        Sides = 4,
        Drinks = 5
    }

    public class MenuCategory
    {
        // Primary key
        public int ID { get; set; }

        public MenuCategoryName? Name { get; set; }

        // Has many
        public virtual List<MenuItem> MenuItems { get; set; }
    }
}
