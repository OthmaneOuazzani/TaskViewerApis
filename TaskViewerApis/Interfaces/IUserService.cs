using TaskViewer.Models;


namespace TaskViewerApis.Interfaces
{
    public interface IUserService
    {

        Task<IEnumerable<User>> getUsers();
        Task<User> getUser(string id);
        Task<IEnumerable<User>> getUsersByProject(string projetctId);
        Task<IEnumerable<User>> getColleagues(string userId);
        Task<User> updateUser(User user , string id);

    }
}
