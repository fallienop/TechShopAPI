using TechShop.Domain.Entities;

namespace TechShopAPI.Models
{
    public class AllDatasModel
    {
        public List<Cpu> Cpu { get; set; }
        public List<Gpu> Gpu { get; set; }
        public List<Laptop> Laptop { get; set; }
        public List<PC> PC { get; set; }
        public List<Screen> Screen { get; set; }
        public List<MobilePhones> Phones { get; set; }
         public List<GamingAccessories> Gaming { get; set; }
         public List<Accessories> Accessory { get; set; }
    }
}
