using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechShop.Application.Services.Interface;

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

        [HttpGet("/gpu")]
        public async Task<IActionResult> GetAllGPUs()
        {
            var data=await _service.GetAllGPUs();
            return Ok(data);
        }

        [HttpGet("/cpu")]
        public async Task<IActionResult> GetAllCPUs()
        {
            var data = await _service.GetAllCPUs();
            return Ok(data);
        }

        [HttpGet("/laptop")]
        public async Task<IActionResult> GetAllLaptops()    
        {
            var data = await _service.GetAllLaptops();
            return Ok(data);
        }

        [HttpGet("/pc")]
        public async Task<IActionResult> GetAllPCs()
        {
            var data = await _service.GetAllPCs();
            return Ok(data);
        }

        [HttpGet("/screen")]
        public async Task<IActionResult> GetAllMonitors()
        {
            var data = await _service.GetAllMonitors();
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

        [HttpGet("/mobile")]
        public async Task<IActionResult> GetPhones()
        {
            var data = await _service.GetAllPhones();
            return Ok(data);
        }
        [HttpGet("/gaming")]
        public async Task<IActionResult> GetGamingAccesories()
        {
            var data = await _service.GetAllGamingAccesories();
            return Ok(data);
        }
    }
}
