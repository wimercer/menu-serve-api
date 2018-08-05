using System;

namespace menu_serve_api.Models
{
    public class MenuItem
    {
        // Primary key
        public int ID { get; set; }
        
        public String ShortDescription { get; set; }

        public String Details { get; set; }

        public Decimal Price { get; set; }

        // Has one
        public virtual MenuCategory MenuCategory { get; set; }
    }    
}
