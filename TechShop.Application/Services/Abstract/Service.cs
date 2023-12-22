using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<Gpu>> GetAllGPUs()
        {
            var gpus = await _dbcontext.GPUs.ToListAsync();
            return gpus;
        }

        public async Task<List<Laptop>> GetAllLaptops()
        {
            var laptops = await _dbcontext.Laptops.ToListAsync();
            return laptops;
        }

        public async Task<List<Screen>> GetAllMonitors()
        {
            var monitors = await _dbcontext.Screens.ToListAsync();
            return monitors;
        }

        public async Task<List<PC>> GetAllPCs()
        {
            var PCs = await _dbcontext.PCs.ToListAsync();
            return PCs;
        }

        public async Task<List<MobilePhones>> GetAllPhones()
        {
            var phones = await _dbcontext.Phones.ToListAsync();
            return phones;
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
    }
}
