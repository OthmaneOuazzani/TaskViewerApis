using Microsoft.AspNetCore.Mvc;
using TaskViewerApis.Interfaces;

namespace TaskViewerApis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet("UserById")]
        public async Task<IActionResult> GetUserById(string id)
        {
            return Ok(await _userService.getUser(id));
        }

        [HttpGet("Users")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userService.getUsers());
        }

        [HttpGet("UsersByProject")]
        public async Task<IActionResult> GetUsersByProject(string projectId)
        {
            return Ok(await _userService.getUsersByProject(projectId));
        }

        [HttpGet("Colleagues")]
        public async Task<IActionResult> GetColleagues(string userId)
        {
            return Ok(await _userService.getColleagues(userId));
        }
    }
    }
