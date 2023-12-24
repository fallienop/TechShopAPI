using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Domain.Entities
{
    public class GamingAccessories : IProduct
    {
        public int Id { get ; set ; }
        public string? Company { get; set; }
        public string? Name { get ; set ; }
        public string? Description { get ; set ; }
        public decimal? Price { get ; set ; }
        public int CategoryId { get ; set ; }
        public byte[]? ImageData { get ; set ; }
     
    }
}
