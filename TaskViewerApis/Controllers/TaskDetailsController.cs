using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TaskViewer.Models;
using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using TaskViewerApis.Services;


namespace TaskViewerApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskDetailsController : ControllerBase
    {
        private readonly ITaskDetailService _taskDetailService;
        private readonly ILogger<TaskController> _logger;

        public TaskDetailsController(ILogger<TaskController> logger, ITaskDetailService taskDetailService)
        {
            _logger = logger;
            _taskDetailService = taskDetailService;
        }
        [HttpGet("details")]
        public async Task<IActionResult> getTaskDetails()
        {
            return Ok(await _taskDetailService.getTasksDetail());
        }

        [HttpGet("detailsPage")]
        public async Task<IActionResult> getTaskDetailsPage(int page)
        {
            return Ok(await _taskDetailService.getTasksDetailPage(page));
        }

        [HttpGet("detailsByProject")]
        public async Task<IActionResult> getTaskDetailsByProject(string projectName)
        {
            return Ok(await _taskDetailService.getTasksDetailByProject(projectName));
        }

        [HttpGet("detailsById")]
        public async Task<IActionResult> getTaskDetailsById(string detailId)
        {
            return Ok(await _taskDetailService.getTasksDetailById(detailId));
        }

        [HttpGet("detailsByFatherTask")]
        public async Task<IActionResult> getTaskDetailsByFatherTask(string fatherTaskName)
        {
            return Ok(await _taskDetailService.getTasksDetailByFatherTask(fatherTaskName));
        }

        [HttpGet("detailsByRequestedBy")]
        public async Task<IActionResult> getTaskDetailsByRequestedBy(string userId)
        {
            return Ok(await _taskDetailService.getTasksDetailByRequestedBy(userId));
        }
        






    }
    }
