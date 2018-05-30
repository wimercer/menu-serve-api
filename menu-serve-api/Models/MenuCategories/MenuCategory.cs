using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace menu_serve_api.Models
{
    public enum MenuCategoryName
    {

        [Display(Name = "Starters")]
        Starters = 1,

        [Display(Name = "Mains")]
        Mains = 2,

        [Display(Name = "Deserts")]
        Deserts = 3,

        [Display(Name = "Sides")]
        Sides = 4,

        [Display(Name = "Drinks")]
        Drinks = 5
    }

    public class MenuCategory
    {
        // Primary key
        public int ID { get; set; }

        public MenuCategoryName? Name { get; set; }
    }
}
