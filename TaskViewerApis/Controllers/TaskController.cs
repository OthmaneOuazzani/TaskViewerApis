using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using TaskViewer.Models;
using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using Task = TaskViewer.Models.Task;
namespace TaskViewerApis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger , ITaskService taskService)
        {
            _logger = logger;
            _taskService = taskService;
        }

        [HttpGet("TaskById")]
        public async Task<IActionResult> GetTaskById(string id)
        {
            return Ok(await _taskService.getTask(id));
        }

        [HttpGet("Tasks")]
        public async Task<IActionResult> GetTasks()
        {
            return Ok(await _taskService.getTasks());
        }

        [HttpGet("TasksByProject")]
        public async Task<IActionResult> GetTasksByProject(string projectId)
        {
            return Ok(await _taskService.getTasksByProject(projectId));
        }

        [HttpGet("TasksByCreatedBy")]
        public async Task<IActionResult> GetTasksByCreatedBy(string userId)
        {
            return Ok(await _taskService.getTasksByCreatedBy(userId));
        }

        [HttpGet("TasksByUser")]
        public async Task<IActionResult> GetTasksByUser(string userId)
        {
            return Ok(await _taskService.getTasksByUser(userId));
        }

        [HttpGet("TasksByAffectedTo")]
        public async Task<IActionResult> GetTasksByAffectedTo(string userId)
        {
            return Ok(await _taskService.getTasksByAffectedTo(userId));
        }

        [HttpGet("TasksByProjectIdAndCreatedBy")]
        public async Task<IActionResult> GetTasksByProjectIdAndCreatedBy(string projectId, string userId)
        {
            return Ok(await _taskService.getTasksByProjectIdAndCreatedBy(projectId, userId));
        }



    }
}