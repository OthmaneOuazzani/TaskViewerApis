using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Threading.Tasks;
using TaskViewer.Models;
using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace TaskViewerApis.Services
{
    public class TaskDetailService : ITaskDetailService
    {
        private readonly IEnumerable<TaskDetail> tasksDetail;
        private const int PageSize = 10;

        public TaskDetailService(IEnumerable<TaskDetail> tasksDetail)
        {
            this.tasksDetail = tasksDetail;
        }

        public async Task<IEnumerable<TaskDetail>> getTasksDetail()
        {
            return await Task.FromResult(tasksDetail);
        }

        public async Task<IEnumerable<TaskDetail>> getTasksDetailPage(int page = 1)
        {
            int startIndex = (page - 1) * PageSize;
            int endIndex = Math.Min(startIndex + PageSize, tasksDetail.Count());
            List<TaskDetail> tasksDetails = tasksDetail.Skip(startIndex).Take(endIndex - startIndex).ToList();

            return await Task.FromResult(tasksDetails);
        }

        async public Task<IEnumerable<TaskDetail>> getTasksDetailByProject(string projectName)
        {
            return await Task.FromResult(tasksDetail.Where(t => t.ProjectName == projectName));
        }

  

    async public Task<IEnumerable<TaskDetail>> getTasksDetailByFatherTask(string fatherTaskName)
        {
            return await Task.FromResult(tasksDetail.Where(t => t.FatherTaskName == fatherTaskName));
        }

        async public Task<TaskDetail> getTasksDetailById(string detailId)
        {
            return await Task.FromResult(tasksDetail.FirstOrDefault(t => t.PlmId == detailId));
        }

        async public Task<IEnumerable<TaskDetail>> getTasksDetailByRequestedBy(string userId)
        {
            return await Task.Run(() =>
            {
                var tasksDetailByRequestedBy = tasksDetail.Where(t => t.RequestedBy == userId);
                return (IEnumerable<TaskDetail>)tasksDetailByRequestedBy;
            });
        }
    }

    public class TaskDetailServiceFactory
    {
        public async Task<TaskDetailService> CreateAsync()
        {
            var tasksDetail = await LoadTasksAsync();
            return new TaskDetailService(tasksDetail);
        }

        private async Task<IEnumerable<TaskDetail>> LoadTasksAsync()
        {
            string filePath = @"C:\Users\Othmane\source\repos\TaskViewerApis\TaskViewerApis\Data\W_PWT_TASKDETAIL_DATA_TABLE.json";
            string jsonData = await File.ReadAllTextAsync(filePath);
            return JsonConvert.DeserializeObject<IEnumerable<TaskDetail>>(jsonData, new BoolConverter(), new DateConverter()) ?? Enumerable.Empty<TaskDetail>();
        }
    }
}