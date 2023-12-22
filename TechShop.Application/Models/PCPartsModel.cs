using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Domain.Entities;

namespace TechShop.Application.Models
{
    public class PCPartsModel
    {
        public List<Cpu> Cpu { get; set; }
        public List<Gpu> Gpu { get; set; }
    }
}
