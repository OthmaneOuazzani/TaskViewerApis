using Microsoft.AspNetCore.Mvc;
using TaskViewerApis.Interfaces;
using TaskViewerApis.Models;

namespace TaskViewerApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaController : ControllerBase
    {
        private readonly ILaService _laService;
        private readonly ILogger<TaskController> _logger;



        public LaController(ILaService laService, ILogger<TaskController> logger)
        {
            _laService = laService;
            _logger = logger;
        }


        [HttpGet ("Las")]
        public async Task<IActionResult> GetAllLas()
        {
            return Ok(await _laService.GetAllLas());
        }
        

        [HttpGet("LaById")]
        public async Task<IActionResult> GetLa(string id)
        {
        return Ok(await _laService.GetLa(id));
        }

        [HttpGet("page")]
        public async Task<IActionResult> GetLaPage(int page , int pageSize)
        {
            return Ok(await _laService.GetLaPage(page, pageSize));
        }
    }
}
