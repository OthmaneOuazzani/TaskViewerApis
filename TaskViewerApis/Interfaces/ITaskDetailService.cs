using TaskViewer.Models;

namespace TaskViewerApis.Interfaces
{
    public interface ITaskDetailService
    {
        Task<IEnumerable<TaskDetail>> getTasksDetail();
        Task<IEnumerable<TaskDetail>> getTasksDetailPage(int page);
        Task<IEnumerable<TaskDetail>> getTasksDetailByProject(string projectName);
        Task<TaskDetail> getTasksDetailById(string detailId);
        Task<IEnumerable<TaskDetail>> getTasksDetailByFatherTask(string fatherTaskName);
        Task<IEnumerable<TaskDetail>> getTasksDetailByRequestedBy(string userId);  


    }
}
