using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskViewerApis.Interfaces;

namespace TaskViewerApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly ILogger<TaskController> _logger;

        public ProjectController(ILogger<TaskController> logger, IProjectService projectService)
        {
            _logger = logger;
            _projectService = projectService;
        }

        [HttpGet("ProjectById")]
        public async Task<IActionResult> GetProjectById(string id)
        {
            return Ok(await _projectService.getProject(id));
        }

        [HttpGet("Projects")]
        public async Task<IActionResult> GetProjects()
        {
            return Ok(await _projectService.getProjects());
        }

        [HttpGet("ProjectByProjectName")]
        public async Task<IActionResult> GetProjectByProjectName(string projectName)
        {
            return Ok(await _projectService.getProjectByProjectName(projectName));
        }

        [HttpGet("ProjectsByUser")]
        public async Task<IActionResult> GetProjectsByUser(string userId)
        {
            return Ok(await _projectService.getProjectsByUser(userId));
        }

    }
}
