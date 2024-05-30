using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskViewerApis.Data;
using TaskViewerApis.Models;

public class NotificationService : INotificationService
{
    private readonly Context _context;

    public NotificationService(Context context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Notification>> getNotificationsByUserId(string userId)
    {
        return await _context.Notifications
                             .Where(n => n.UserId == userId)
                             .ToListAsync();
    }

    public async Task markAsSeen(int id)
    {
        var notification = await _context.Notifications.FindAsync(id);
        if (notification != null)
        {
            notification.IsSeen = true;
            _context.Notifications.Update(notification);
            await _context.SaveChangesAsync();
        }
    }

    public async Task deleteNotification(int id)
    {
        var notification = await _context.Notifications.FindAsync(id);
        if (notification != null)
        {
            _context.Notifications.Remove(notification);
            await _context.SaveChangesAsync();
        }
    }
}
