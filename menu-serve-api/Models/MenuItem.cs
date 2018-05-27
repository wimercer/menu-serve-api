using System;

namespace menu_serve_api.Models
{
    public class MenuItem
    {
        public int ID { get; set; }
        
        public String ShortDescription { get; set; }

        public String Details { get; set; }

        public Decimal Price { get; set; }
    }    
}
