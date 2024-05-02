using TaskViewer.Models;

namespace TaskViewerApis.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> getProjects();
        Task<Project> getProject(string id);
        Task<IEnumerable<Project>> getProjectByProjectName(string projectName);
        Task<IEnumerable<Project>> getProjectsByUser(string userId);
    }
}
