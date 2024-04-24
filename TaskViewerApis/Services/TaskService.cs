using Newtonsoft.Json;
using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using Taskk = TaskViewer.Models.Task;

namespace TaskViewerApis.Services
{
    public class TaskService : ITaskService
    {
private readonly IEnumerable<Taskk> tasks;

        public TaskService(IEnumerable<Taskk> tasks)
        {
            this.tasks = tasks;
        }

        public async Task<Taskk> getTask(string id)
        {
            return await Task.Run(() =>
            {
                return tasks.FirstOrDefault(t => t.PlmId == id);
            });
        }

        public async Task<IEnumerable<Taskk>> getTasks()
        {
            return await Task.FromResult(tasks);
        }

        public Task<IEnumerable<Taskk>> getTasksByCreatedBY(string userId)
        {
            return Task.Run(() =>
            {
                var tasksByCreatedBy = tasks.Where(t => t.CreatedBy == userId);
                return (IEnumerable<Taskk>)tasksByCreatedBy;
            });
        }

        public Task<IEnumerable<Taskk>> getTasksByProject(string projectName)
        {
            return Task.Run(() =>
            {
                var tasksByProject = tasks.Where(t => t.ProjectName == projectName);
                return (IEnumerable<Taskk>)tasksByProject;
            });
        }

        public Task<IEnumerable<Taskk>> getTasksByUser(string userId)
        {
            return Task.Run(() =>
            {
                var tasksByUser = tasks.Where(t => t.UserPlmId == userId);
                return (IEnumerable<Taskk>)tasksByUser;
            });
           
        }

        public Task<IEnumerable<Taskk>> getTasksByAffectedTo(string userId)
        {
            return Task.Run(() =>
            {
                var tasksByAffectedTo = tasks.Where(t => t.AffectedTo == userId);
                return (IEnumerable<Taskk>)tasksByAffectedTo;
            });
        }
    }

    public class TaskServiceFactory
    {
        public async Task<TaskService> CreateAsync()
        {
            var tasks = await LoadTasksAsync();
            return new TaskService(tasks);
        }

        private async Task<IEnumerable<Taskk>> LoadTasksAsync()
        {
            string filePath = @"C:\Users\Othmane\source\repos\TaskViewerApis\TaskViewerApis\Data\W_PWT_TASKK_DATA_TABLE.json";
            string jsonData = await File.ReadAllTextAsync(filePath);
            return JsonConvert.DeserializeObject<IEnumerable<Taskk>>(jsonData, new BoolConverter(), new DateConverter()) ?? Enumerable.Empty<Taskk>();
        }
    }
}
