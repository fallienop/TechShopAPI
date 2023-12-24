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
        Task<Gpu> GetGPUById(int id);

        Task<List<Cpu>> GetAllCPUs();
        Task<Cpu> GetCPUById(int id);

        Task<List<Laptop>> GetAllLaptops();
        Task<Laptop> GetLaptopById(int id);

        Task<List<PC>> GetAllPCs();
        Task<PC> GetPCById(int id);

        Task<List<GamingAccessories>> GetAllGamingAccesories();
        Task<GamingAccessories> GetGamingById(int id);

        Task<List<MobilePhones>> GetAllPhones();
        Task<MobilePhones> GetPhoneById(int id);

        Task<List<Screen>> GetAllMonitors();
        Task<Screen> GetScreenById(int id);


        Task<AllDatasModel> GetAllDatas();
        Task<PCPartsModel> GetPcParts();
        Task<IList<object>> GetBySearch(string search);
    }
}
