using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Domain.Entities
{
    public class Cpu : IProduct
    {

        public string Company { get; set; }
   
        public decimal Speed { get; set; }
        public byte Cores { get; set; } 
        public byte Threads { get; set; }
        public byte Generation { get; set; }    

        public string Socket { get; set; }

        public string Caches { get;set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int CategoryId { get; set; }
        public byte[]? ImageData { get; set; }

    }
}
