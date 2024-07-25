using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using Taskk = TaskViewer.Models.Task;
using Task = System.Threading.Tasks.Task;
using Microsoft.EntityFrameworkCore;
using TaskViewerApis.Models;

namespace TaskViewerApis.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskViewerApis.Data.Context _context;
        private  IEnumerable<Taskk> tasks;

        public TaskService(TaskViewerApis.Data.Context context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            tasks = await _context.Tasks.ToListAsync();
        }

        public async Task<Taskk> getTask(string id)
        {
            return await _context.Tasks.FirstOrDefaultAsync(t => t.PlmId == id);
        }

        public async Task<IEnumerable<Taskk>> getTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<IEnumerable<Taskk>> getTasksByProjectIdAndCreatedBy(string projectId, string userId)
        {
            return await _context.Tasks.Where(t => t.ProjectName == projectId && t.CreatedBy == userId).ToListAsync();
        }


        public async Task<IEnumerable<Taskk>> getTasksByCreatedBy(string userId)
        {
            return await _context.Tasks.Where(t => t.CreatedBy == userId).ToListAsync();
        }

        public async Task<IEnumerable<Taskk>> getTasksByProject(string projectName)
        {
            return await _context.Tasks.Where(t => t.ProjectName == projectName).ToListAsync();
        }

        public async Task<IEnumerable<Taskk>> getTasksByUser(string userId)
        {
            return await _context.Tasks.Where(t => t.UserPlmId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Taskk>> getTasksByAffectedTo(string userId)
        {
            return await _context.Tasks.Where(t => t.AffectedTo == userId).ToListAsync();
        }

        public async Task updateValidationStatus(string taskId, string newStatus, string manager)
        {
            var task = await getTask(taskId);
            if (task == null) throw new Exception("Task not found");

            task.ValidationStatus = newStatus;
            switch (newStatus)
            {
                case "Validated":
                    task.ValidatedBy = manager;
                    task.ValidatedAt = DateTime.Now;
                    break;
                case "Rejected":
                    task.RejectedBy = manager;
                    task.RejectedAt = DateTime.Now;
                    break;

                case "Completed":
                    task.CompletedBy = manager;
                    task.CompletedAt = DateTime.Now;
                    break;
                case 
                    "Archived":
                    task.IsArchived = true;
                    break;

            }


            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();

            var notification = new Notification
            {
                UserId = task.CreatedBy,
                TaskId = task.PlmId,
                Description = $"Validation status changed to {newStatus}",
                Time = DateTime.Now,
                IsSeen = false,
                Status = newStatus,
                ChangedBy = manager
            };

            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();
        }
    }
}
