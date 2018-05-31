using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace menu_serve_api.Models
{
    public class MenuCategory
    {
        // Primary key
        public int ID { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
