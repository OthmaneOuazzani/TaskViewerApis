using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Threading.Tasks;
using TaskViewer.Models;
using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using Task = System.Threading.Tasks.Task;
using System.Linq;
using System.Collections.Generic;

namespace TaskViewerApis.Services
{
    public class TaskDetailService : ITaskDetailService
    {
        private readonly TaskViewerApis.Data.Context _context;
        private readonly IEnumerable<TaskDetail> tasksDetail;
        private const int PageSize = 50;

        public TaskDetailService(TaskViewerApis.Data.Context context)
        {
            _context = context;
            tasksDetail = _context.TaskDetails.ToList();
        }

        //public async Task<IEnumerable<TaskDetail>> getTasksDetail()
        //{
        //    return await _context.TaskDetails.ToListAsync();
        //}

                public async Task<IEnumerable<TaskDetail>> getTasksDetail()
                {
                    return await Task.FromResult(tasksDetail);
                }

        public async Task<IEnumerable<TaskDetail>> getTasksDetailPage(int page = 1)
        {
            int startIndex = (page - 1) * PageSize;
            int endIndex = Math.Min(startIndex + PageSize, await _context.TaskDetails.CountAsync());
            List<TaskDetail> tasksDetails = await _context.TaskDetails.Skip(startIndex).Take(endIndex - startIndex).ToListAsync();

            return tasksDetails;
        }

        public async Task<IEnumerable<TaskDetail>> getTasksDetailByProject(string projectName)
        {
            return await _context.TaskDetails.Where(t => t.ProjectName == projectName).ToListAsync();
        }

        public async Task<IEnumerable<TaskDetail>> getTasksDetailByFatherTask(string fatherTaskName)
        {
            return await _context.TaskDetails.Where(t => t.FatherTaskName == fatherTaskName).ToListAsync();
        }

        public async Task<TaskDetail> getTasksDetailById(string detailId)
        {
            return await _context.TaskDetails.FirstOrDefaultAsync(t => t.PlmId == detailId);
        }

        public async Task<IEnumerable<TaskDetail>> getTasksDetailByRequestedBy(string userId)
        {
            return await _context.TaskDetails.Where(t => t.RequestedBy == userId).ToListAsync();
        }
    }
}



//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
//using System.Threading.Tasks;
//using TaskViewer.Models;
//using TaskViewerApis.Helpers;
//using TaskViewerApis.Interfaces;
//using Task = System.Threading.Tasks.Task;

//namespace TaskViewerApis.Services
//{
//    public class TaskDetailService : ITaskDetailService
//    {
//        private readonly IEnumerable<TaskDetail> tasksDetail;
//        private const int PageSize = 10;
//        private readonly TaskViewerApis.Data.Context _context;

//        public TaskDetailService(TaskViewerApis.Data.Context context)
//        {
//            _context = context;
//            tasksDetail = _context.TaskDetails.ToListAsync().GetAwaiter().GetResult();
//        }

//        //private async Task<IEnumerable<TaskDetail>> LoadTasksAsync()
//        //{
//        //    string filePath = @"C:\Users\Othmane\source\repos\TaskViewerApis\TaskViewerApis\Data\W_PWT_TASKDETAIL_DATA_TABLE.json";
//        //    string jsonData = await File.ReadAllTextAsync(filePath);
//        //    var taskDetails = JsonConvert.DeserializeObject<IEnumerable<TaskDetail>>(jsonData, new BoolConverter(), new DateConverter()) ?? Enumerable.Empty<TaskDetail>();

//        //    foreach (var taskDetail in taskDetails)
//        //    {
//        //        // Check if the task detail already exists in the context
//        //        if (!_context.TaskDetails.Any(td => td.PlmId == taskDetail.PlmId))
//        //        {
//        //            // Clear the context's change tracker
//        //            _context.ChangeTracker.Clear();

//        //            _context.TaskDetails.Add(taskDetail);
//        //            await _context.SaveChangesAsync();
//        //        }
//        //    }

//        //    return taskDetails;
//        //}

//        public async Task<IEnumerable<TaskDetail>> getTasksDetail()
//        {
//            return await Task.FromResult(tasksDetail);
//        }

//        public async Task<IEnumerable<TaskDetail>> getTasksDetailPage(int page = 1)
//        {
//            int startIndex = (page - 1) * PageSize;
//            int endIndex = Math.Min(startIndex + PageSize, tasksDetail.Count());
//            List<TaskDetail> tasksDetails = tasksDetail.Skip(startIndex).Take(endIndex - startIndex).ToList();

//            return await Task.FromResult(tasksDetails);
//        }

//        async public Task<IEnumerable<TaskDetail>> getTasksDetailByProject(string projectName)
//        {
//            return await Task.FromResult(tasksDetail.Where(t => t.ProjectName == projectName));
//        }

  

//    async public Task<IEnumerable<TaskDetail>> getTasksDetailByFatherTask(string fatherTaskName)
//        {
//            return await Task.FromResult(tasksDetail.Where(t => t.FatherTaskName == fatherTaskName));
//        }

//        async public Task<TaskDetail> getTasksDetailById(string detailId)
//        {
//            return await Task.FromResult(tasksDetail.FirstOrDefault(t => t.PlmId == detailId));
//        }

//        async public Task<IEnumerable<TaskDetail>> getTasksDetailByRequestedBy(string userId)
//        {
//            return await Task.Run(() =>
//            {
//                var tasksDetailByRequestedBy = tasksDetail.Where(t => t.RequestedBy == userId);
//                return (IEnumerable<TaskDetail>)tasksDetailByRequestedBy;
//            });
//        }
//    }

//    //public class TaskDetailServiceFactory
//    //{
//    //    public async Task<TaskDetailService> CreateAsync()
//    //    {
//    //        var tasksDetail = await LoadTasksAsync();
//    //        return new TaskDetailService(tasksDetail);
//    //    }

//    //    private async Task<IEnumerable<TaskDetail>> LoadTasksAsync()
//    //    {
//    //        string filePath = @"C:\Users\Othmane\source\repos\TaskViewerApis\TaskViewerApis\Data\W_PWT_TASKDETAIL_DATA_TABLE.json";
//    //        string jsonData = await File.ReadAllTextAsync(filePath);
//    //        return JsonConvert.DeserializeObject<IEnumerable<TaskDetail>>(jsonData, new BoolConverter(), new DateConverter()) ?? Enumerable.Empty<TaskDetail>();
//    //    }
//    //}
