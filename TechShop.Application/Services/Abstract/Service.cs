using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechShop.Application.Models;
using TechShop.Application.Services.Interface;
using TechShop.Domain.Entities;
using TechShop.Infrastructure;
using TechShopAPI.Models;

namespace TechShop.Application.Services.Abstract
{
    public class Service : IService
    {
        private readonly AppDbContext _dbcontext;

        public Service(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Cpu>> GetAllCPUs()
        {

            var cpus = await _dbcontext.CPUs.ToListAsync();
            return cpus;

        }

        public async Task<Cpu> GetCPUById(int id)
        {

            var cpu = await _dbcontext.CPUs.FindAsync(id);
            return cpu;
        }


        public async Task<List<Gpu>> GetAllGPUs()
        {
            var gpus = await _dbcontext.GPUs.ToListAsync();
          
            return gpus;
        }

        public async Task<Gpu> GetGPUById(int id)
        {

            var gpu = await _dbcontext.GPUs.FindAsync(id);
            return gpu;
        }

        public async Task<List<Laptop>> GetAllLaptops()
        {
            var laptops = await _dbcontext.Laptops.ToListAsync();
            return laptops;
        }
        public async Task<Laptop> GetLaptopById(int id)
        {

            var laptop = await _dbcontext.Laptops.FindAsync(id);
            return laptop;
        }

        public async Task<List<Screen>> GetAllMonitors()
        {
            var monitors = await _dbcontext.Screens.ToListAsync();
            return monitors;
        }
        public async Task<Screen> GetScreenById(int id)
        {

            var screen = await _dbcontext.Screens.FindAsync(id);
            return screen;
        }

        public async Task<List<PC>> GetAllPCs()
        {
            var PCs = await _dbcontext.PCs.ToListAsync();
            return PCs;
        }
        public async Task<PC> GetPCById(int id)
        {
            var pc = await _dbcontext.PCs.FindAsync(id);
            return pc;
        }



        public async Task<List<MobilePhones>> GetAllPhones()
        {
            var phones = await _dbcontext.Phones.ToListAsync();
            return phones;
        }
        public async Task<MobilePhones> GetPhoneById(int id)
        {
            var phone = await _dbcontext.Phones.FindAsync(id);
            return phone;
        }

        public async Task<AllDatasModel> GetAllDatas()
        {
            var cpus = await _dbcontext.CPUs.ToListAsync();
            var gpus = await _dbcontext.GPUs.ToListAsync();
            var laptops = await _dbcontext.Laptops.ToListAsync();
            var monitors = await _dbcontext.Screens.ToListAsync();
            var PCs = await _dbcontext.PCs.ToListAsync();
            var phones = await _dbcontext.Phones.ToListAsync();
            var gamingaccesory = await _dbcontext.Gaming.ToListAsync();

            var alldatamodel = new AllDatasModel
            {
                Cpu = cpus,
                Gpu = gpus,
                Laptop = laptops,
                Screen = monitors,
                PC = PCs,
                Phones = phones,
                Gaming=gamingaccesory
            };
            return alldatamodel;
        }   
        public async Task<PCPartsModel> GetPcParts()
        {
            var cpus = await _dbcontext.CPUs.ToListAsync();
            var gpus = await _dbcontext.GPUs.ToListAsync();
            var pcpartmodel = new PCPartsModel
            {
                Cpu = cpus,
                Gpu = gpus
            };
            return pcpartmodel;
        }

        public async Task<List<GamingAccessories>> GetAllGamingAccesories()
        {
            var gamingaccesory=await _dbcontext.Gaming.ToListAsync();
            return gamingaccesory;
        }
        public async Task<GamingAccessories> GetGamingById(int id)
        {
            var gaming = await _dbcontext.Gaming.FindAsync(id);
            return gaming;
        }

        public async Task<IList<object>> GetBySearch(string search)
        {

            var cpus = await _dbcontext.CPUs.Where(x=>x.ImageData!=null).ToListAsync();
            var gpus = await _dbcontext.GPUs.Where(x => x.ImageData != null).ToListAsync();
            var laptops = await _dbcontext.Laptops.ToListAsync();
            var monitors = await _dbcontext.Screens.Where(x => x.ImageData != null).ToListAsync();
            var PCs = await _dbcontext.PCs.ToListAsync();
            var phones = await _dbcontext.Phones.ToListAsync();
            var gamingaccesory = await _dbcontext.Gaming.ToListAsync();

            var alldatamodel = new AllDatasModel
            {
                Cpu = cpus,
                Gpu = gpus,
                Laptop = laptops,
                Screen = monitors,
                PC = PCs,
                Phones = phones,
                Gaming = gamingaccesory
            };

            Type myType = alldatamodel.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            IList<object> searchList= new List<object>();
            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(alldatamodel);
               
                if (propValue is IEnumerable<object> collection)
                {
                    foreach (var item in collection)
                    {
                     
                        var itemName = item.GetType().GetProperty("Name")?.GetValue(item).ToString();
                        var itemDescription = item.GetType().GetProperty("Description")?.GetValue(item).ToString();
                        var color = item.GetType().GetProperty("Color")?.GetValue(item).ToString();
                        var company = item.GetType().GetProperty("Company")?.GetValue(item).ToString();
                        var storage = item.GetType().GetProperty("Storage")?.GetValue(item).ToString();
                        var laptoptype = item.GetType().GetProperty("LaptopType")?.GetValue(item).ToString();

                        if (IsMatch(search, itemName) || IsMatch(search, itemDescription) || IsMatch(search, color) || IsMatch(search, company) || IsMatch(search, storage) || IsMatch(search, laptoptype))
                        {
                           
                          searchList.Add(item);
                        }


                    }
                }
                else
                {
                    Console.WriteLine($"  {propValue}");
                }
            }

            return searchList;
             
        }
        private bool IsMatch(string search, string value)
        {
            // İsteğe bağlı olarak büyük-küçük harf duyarlılığı olmadan karşılaştırma yapabilirsiniz.
            return value != null && value.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0;
        }

 

       
     

       
     

       

        

    }
}
