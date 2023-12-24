using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Domain.Entities
{
    public class PC:IProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Company { get; set; }
        public int CpuId { get; set; }
        
        public string MotherBoard { get; set; }
        
        public string Ram { get; set; }
        public string Pcu { get; set; }
        public string Storage { get; set; }

        public byte[]? ImageData { get; set; }

        public int? GpuId { get; set; }
       
        public string? Description { get ; set ; }
        public decimal? Price      { get ; set ; }
        public int CategoryId      { get ; set ; }
    
    }
}
