﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Domain.Entities
{
    public class Laptop:IProduct
    {
        public string Color { get; set; }
        public int CpuId { get; set; }  
        public int ScreenId { get; set; }   
        public string LaptopType { get; set; }
        public string Ram { get; set; }
        public string Battery { get; set; }
        public int? GpuId { get; set; }
        public byte[]? ImageData { get;set; }
        public string Storage { get; set;}

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int CategoryId { get; set; }
    }
}