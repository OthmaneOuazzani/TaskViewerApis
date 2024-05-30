using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace TaskViewerApis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        private readonly ILogger<NotificationController> _logger;

        public NotificationController(INotificationService notificationService, ILogger<NotificationController> logger)
        {
            _notificationService = notificationService;
            _logger = logger;
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetNotificationsByUserId(string userId)
        {
            var notifications = await _notificationService.getNotificationsByUserId(userId);
            return Ok(notifications);
        }

        [HttpPut("markAsSeen/{id}")]
        public async Task<IActionResult> MarkAsSeen(int id)
        {
            await _notificationService.markAsSeen(id);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            await _notificationService.deleteNotification(id);
            return Ok();
        }
    }
}
