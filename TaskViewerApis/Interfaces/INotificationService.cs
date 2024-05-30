
using TaskViewerApis.Models;

public interface INotificationService
{
    Task<IEnumerable<Notification>> getNotificationsByUserId(string userId);
    Task markAsSeen(int id);
    Task deleteNotification(int id);
}
