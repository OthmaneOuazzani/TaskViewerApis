using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using Taskk = TaskViewer.Models.Task;
using Task = System.Threading.Tasks.Task;
using Microsoft.EntityFrameworkCore;

namespace TaskViewerApis.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskViewerApis.Data.Context _context;
        private  IEnumerable<Taskk> tasks;

        public TaskService(TaskViewerApis.Data.Context context)
        {
            _context = context;
            //tasks = _context.Tasks.ToList();
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

        //public async Task<IEnumerable<Taskk>> getTasks()
        //{
        //    return await System.Threading.Tasks.Task.FromResult(tasks);
        //}

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
    }
}
//using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
//using TaskViewer.Models;
//using TaskViewerApis.Helpers;
//using TaskViewerApis.Interfaces;
//using Taskk = TaskViewer.Models.Task;

//namespace TaskViewerApis.Services
//{
//    public class TaskService : ITaskService
//    {
//        private readonly IEnumerable<Taskk> tasks;
//        private readonly TaskViewerApis.Data.Context _context;

//        public TaskService(TaskViewerApis.Data.Context context)
//        {
//            //this.tasks = tasks;
//            _context = context;
//            tasks = _context.Tasks.ToListAsync().GetAwaiter().GetResult();

//        }

//        //private async Task<IEnumerable<Taskk>> LoadTasksAsync()
//        //{
//        //    string filePath = @"C:\Users\Othmane\source\repos\TaskViewerApis\TaskViewerApis\Data\W_PWT_TASKK_DATA_TABLE.json";
//        //    string jsonData = await File.ReadAllTextAsync(filePath);
//        //    var tasks = JsonConvert.DeserializeObject<IEnumerable<Taskk>>(jsonData, new BoolConverter(), new DateConverter()) ?? Enumerable.Empty<Taskk>();

//        //    foreach (var task in tasks)
//        //    {
//        //        // Check if the task already exists in the context
//        //        if (!_context.Tasks.Any(t => t.PlmId == task.PlmId))
//        //        {
//        //            // Clear the context's change tracker
//        //            _context.ChangeTracker.Clear();

//        //            _context.Tasks.Add(task);
//        //            await _context.SaveChangesAsync();
//        //        }
//        //    }

//        //    return tasks;
//        //}

//        public async Task<Taskk> getTask(string id)
//        {
//            return await System.Threading.Tasks.Task.Run(() =>
//            {
//                return tasks.FirstOrDefault(t => t.PlmId == id);
//            });
//        }

//        public async Task<IEnumerable<Taskk>> getTasks()
//        {
//            return await System.Threading.Tasks.Task.FromResult(tasks);
//        }

//        public Task<IEnumerable<Taskk>> getTasksByCreatedBY(string userId)
//        {
//            return System.Threading.Tasks.Task.Run(() =>
//            {
//                var tasksByCreatedBy = tasks.Where(t => t.CreatedBy == userId);
//                return (IEnumerable<Taskk>)tasksByCreatedBy;
//            });
//        }

//        public Task<IEnumerable<Taskk>> getTasksByProject(string projectName)
//        {
//            return System.Threading.Tasks.Task.Run(() =>
//            {
//                var tasksByProject = tasks.Where(t => t.ProjectName == projectName);
//                return (IEnumerable<Taskk>)tasksByProject;
//            });
//        }

//        public Task<IEnumerable<Taskk>> getTasksByUser(string userId)
//        {
//            return System.Threading.Tasks.Task.Run(() =>
//            {
//                var tasksByUser = tasks.Where(t => t.UserPlmId == userId);
//                return (IEnumerable<Taskk>)tasksByUser;
//            });

//        }

//        public Task<IEnumerable<Taskk>> getTasksByAffectedTo(string userId)
//        {
//            return System.Threading.Tasks.Task.Run(() =>
//            {
//                var tasksByAffectedTo = tasks.Where(t => t.AffectedTo == userId);
//                return (IEnumerable<Taskk>)tasksByAffectedTo;
//            });
//        }
//    }

//public class TaskServiceFactory
//{
//    public async Task<TaskService> CreateAsync()
//    {
//        var tasks = await LoadTasksAsync();
//        return new TaskService(tasks);
//    }

//    private async Task<IEnumerable<Taskk>> LoadTasksAsync()
//    {
//        string filePath = @"C:\Users\Othmane\source\repos\TaskViewerApis\TaskViewerApis\Data\W_PWT_TASKK_DATA_TABLE.json";
//        string jsonData = await File.ReadAllTextAsync(filePath);
//        return JsonConvert.DeserializeObject<IEnumerable<Taskk>>(jsonData, new BoolConverter(), new DateConverter()) ?? Enumerable.Empty<Taskk>();
//    }
//}
//}
