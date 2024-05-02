using TaskViewer.Models;
using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace TaskViewerApis.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IEnumerable<Project> projects;
        private readonly IUserService userService;

        public ProjectService(IUserService userService)
        {
            projects = LoadProjectsAsync().GetAwaiter().GetResult();
            this.userService = userService;
        }

        private async Task<IEnumerable<Project>> LoadProjectsAsync()
        {
            string filePath = @"C:\Users\Othmane\source\repos\TaskViewerApis\TaskViewerApis\Data\W_PWT_PROJECTLIB_DATA_TABLE.json";
            string jsonData = await File.ReadAllTextAsync(filePath);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Project>>(jsonData, new BoolConverter(), new DateConverter()) ?? Enumerable.Empty<Project>();
        }

        public async Task<Project> getProject(string id)
        {
            return await Task.Run(() =>
            {
                return projects.FirstOrDefault(p => p.PlmId == id);
            });
        }

        public async Task<IEnumerable<Project>> getProjects()
        {
            return await Task.FromResult(projects);
        }

        public async Task<IEnumerable<Project>> getProjectByProjectName(string projectName)
        {
            return await Task.Run(() =>
            {
                var projectsByProjectName = projects.Where(p => p.ProjectName == projectName);
                return (IEnumerable<Project>)projectsByProjectName;
            });
        }


        public async Task<IEnumerable<Project>> getProjectsByUser(string userId)
        {
            var users = await this.userService.getUsers();
            var user = users.FirstOrDefault(u => u.PlmId == userId);
            if (user == null)
            {
                return Enumerable.Empty<Project>();
            }

            var userProjects = projects.Where(p =>
                p.PlmId == user.Proj1 ||
                p.PlmId == user.Proj2 ||
                p.PlmId == user.Proj3 ||
                p.PlmId == user.Proj4 ||
                p.PlmId == user.Proj5 ||
                p.PlmId == user.Proj6 ||
                p.PlmId == user.Proj7 ||
                p.PlmId == user.Proj8 ||
                p.PlmId == user.Proj9 ||
                p.PlmId == user.Proj10);

            return userProjects;
        }
    }
}