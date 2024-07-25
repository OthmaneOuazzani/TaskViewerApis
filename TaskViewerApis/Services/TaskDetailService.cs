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

