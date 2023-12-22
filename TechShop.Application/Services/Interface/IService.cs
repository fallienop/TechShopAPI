using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Application.Models;
using TechShop.Domain.Entities;
using TechShopAPI.Models;

namespace TechShop.Application.Services.Interface
{
    public interface IService
    {
        Task<List<Gpu>> GetAllGPUs();
        Task<List<Cpu>> GetAllCPUs();
        Task<List<Laptop>> GetAllLaptops();
        Task<List<PC>> GetAllPCs();
        Task<List<GamingAccessories>> GetAllGamingAccesories();
        Task<List<MobilePhones>> GetAllPhones();
        Task<List<Screen>> GetAllMonitors();
        Task<AllDatasModel> GetAllDatas();
        Task<PCPartsModel> GetPcParts();
    }
}
