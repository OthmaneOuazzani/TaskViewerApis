namespace TaskViewerApis.Interfaces;
using Taskk = TaskViewer.Models.Task;


public interface ITaskService
{
    Task<IEnumerable<Taskk>> getTasks();
    Task<IEnumerable<Taskk>> getTasksByProject(string projectId);
    Task<IEnumerable<Taskk>> getTasksByCreatedBy(string userId);
    Task<Taskk> getTask(string id);
    Task<IEnumerable<Taskk>> getTasksByUser(string userId);
    Task<IEnumerable<Taskk>> getTasksByAffectedTo(string userId);



}
