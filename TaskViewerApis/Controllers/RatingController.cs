using Microsoft.AspNetCore.Mvc;
using TaskViewerApis.Interfaces;
using TaskViewerApis.Models;
using TaskViewerApis.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskViewerApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;
        private readonly ILogger<TaskController> _logger;


        public RatingController(ILogger<TaskController> logger, IRatingService ratingService)
        {
            _logger = logger;
            _ratingService = ratingService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateRating([FromBody] Rating rating)
        {
            return Ok(await _ratingService.saveRating(rating));
        }

    }

      

    }

