using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechShop.Application.Services.Interface;
using TechShop.Domain.Entities;

namespace TechShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainContoller : ControllerBase
    {
        private readonly IService _service;

        public MainContoller(IService service)
        {
            _service = service;
        }

        [HttpGet("/getbysearch/{searchTerm}")]
        public async Task<IActionResult> Search(string searchTerm)
        {
            var data = await _service.GetBySearch(searchTerm);
            //foreach(var item in data) { 
            //Console.WriteLine(item);
            //}
          
            return Ok(data);
        }


        [HttpGet("/gpu")]
        public async Task<IActionResult> GetAllGPUs()
        {
            var data=await _service.GetAllGPUs();
            var g = data.Select(x => x.Name).ToList();
            Console.WriteLine(string.Join("\n",g));
            return Ok(data);
        }

        [HttpGet("/gpu/{id}")]
        public async Task<IActionResult> GetGPUById(int id)
        {
            var data = await _service.GetGPUById(id);
            return Ok(data);
        }



        [HttpGet("/cpu")]
        public async Task<IActionResult> GetAllCPUs()
        {
            var data = await _service.GetAllCPUs();
            return Ok(data);
        }
        [HttpGet("/cpu/{id}")]
        public async Task<IActionResult> GetCPUById(int id)
        {
            var data = await _service.GetCPUById(id);
            return Ok(data);
        }


        [HttpGet("/laptop")]
        public async Task<IActionResult> GetAllLaptops()    
        {
            var data = await _service.GetAllLaptops();
            return Ok(data);
        }

        [HttpGet("/laptop/{id}")]
        public async Task<IActionResult> GetLaptopById(int id)
        {
            var data = await _service.GetLaptopById(id);
            return Ok(data);
        }

        [HttpGet("/pc")]
        public async Task<IActionResult> GetAllPCs()
        {
            var data = await _service.GetAllPCs();
            return Ok(data);
        }

        [HttpGet("/pc/{id}")]
        public async Task<IActionResult> GetPCById(int id)
        {
            var data = await _service.GetPCById(id);
            return Ok(data);
        }


        [HttpGet("/screen")]
        public async Task<IActionResult> GetAllMonitors()
        {
            var data = await _service.GetAllMonitors();
            return Ok(data);
        }


        [HttpGet("/screen/{id}")]
        public async Task<IActionResult> GetScreenById(int id)
        {
            var data = await _service.GetScreenById(id);
            return Ok(data);
        }


        [HttpGet("/getall")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllDatas();
            return Ok(data);
        }

        [HttpGet("/parts")]
        public async Task<IActionResult> GetPCParts()
        {
            var data = await _service.GetPcParts();
            return Ok(data);
        }

        [HttpGet("/phone")]
        public async Task<IActionResult> GetPhones()
        {
            var data = await _service.GetAllPhones();
            return Ok(data);
        }
        [HttpGet("/phone/{id}")]
        public async Task<IActionResult> GetPhoneById(int id)
        {
            var data = await _service.GetPhoneById(id);
            return Ok(data);
        }

        [HttpGet("/gaming")]
        public async Task<IActionResult> GetGamingAccesories()
        {
            var data = await _service.GetAllGamingAccesories();
            return Ok(data);
        }
        [HttpGet("/gaming/{id}")]
        public async Task<IActionResult> GetGamingAccesoryById(int id)
        {
            var data = await _service.GetGamingById(id);
            return Ok(data);
        }

        [HttpGet("/accessories/")]
        public async Task<IActionResult> GetAccesories()
        {
            var data = await _service.GetAllAccessories();
            return Ok(data);
        }
        [HttpGet("/accessories/{id}")]
        public async Task<IActionResult> GetAccesoryById(int id)
        {
            var data = await _service.GetAccessoryById(id);
            return Ok(data);
        }




        [HttpGet("/gpuidnames/{id}")]
        public async Task<IActionResult> GetAllGPUnames(int id)
        {
            var data = await _service.GetAllGPUs();
            var name = data.Find(x => x.Id == id)?.Name;
            return Ok(name);
        }

        [HttpGet("/cpuidnames/{id}")]
        public async Task<IActionResult> GetAllCPUnames(int id)                                 
        {
            var data = await _service.GetAllCPUs();
            var name = data.Find(x=>x.Id==id)?.Name;    

            return Ok(name);
        }

        [HttpGet("/screenidnames/{id}")]
        public async Task<IActionResult> GetAllScreenNames(int id)
        {
            var data = await _service.GetAllMonitors();
            var description = data.Find(x => x.Id == id)?.Description;

            return Ok(description);
        }

      
    }
}
