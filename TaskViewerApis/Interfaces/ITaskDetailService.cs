using TaskViewer.Models;

namespace TaskViewerApis.Interfaces
{
    public interface ITaskDetailService
    {
        Task<IEnumerable<TaskDetail>> getTasksDetail();
        Task<IEnumerable<TaskDetail>> getTasksDetailPage(int page);

    }
}
