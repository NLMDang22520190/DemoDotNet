using DemoDotNet.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDotNet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDataService _dataService;

        public DemoController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("data")]
        public async Task<IActionResult> GetData()
        {
            var data = await _dataService.GetData();
            return Ok(data);
        }
    }
}
