using Microsoft.AspNetCore.Mvc;
using TaskViewerApis.Interfaces;
using TaskViewerApis.Models;
using TaskViewerApis.Services;
using TaskViewerApis.Dtos;
namespace TaskViewerApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorsController : ControllerBase
    {

        private readonly IErrorService _errorService;
        private readonly ILogger<TaskController> _logger;

        public ErrorsController(ILogger<TaskController> logger, IErrorService errorService)
        {
            _logger = logger;
            _errorService = errorService;
        }

        [HttpGet("ErrorById")]
        public async Task<IActionResult> GetErrorById(string id)
        {
            return Ok(await _errorService.getError(id));
        }

        [HttpGet("Errors")]
        public async Task<IActionResult> GetErrors()
        {
            return Ok(await _errorService.getErrors());
        }

        [HttpPost("CreateError")]
        public async Task<IActionResult> CreateError([FromBody] Error error)
        {
            return Ok(await _errorService.createError(error));
        }

        [HttpPut("UpdateError")]
        public async Task<IActionResult> UpdateError(string id, [FromBody] Error error)
        {
            return Ok(await _errorService.updateError(id, error));
        }

        [HttpDelete("DeleteError")]
        public async Task<IActionResult> DeleteError(string id)
        {
            return Ok(await _errorService.deleteError(id));
        }
    }
}
