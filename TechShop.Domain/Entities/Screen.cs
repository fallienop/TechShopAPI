using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Domain.Entities
{
    public class Screen:IProduct
    {
  
        public string Size { get; set; }   
        public string Resolution { get; set; }  

        public int RefreshRate { get; set; }    
        public string Panel { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int CategoryId { get; set; }
        public byte[]? ImageData { get; set; }

    }
}
