using TaskViewerApis.Models;

namespace TaskViewerApis.Interfaces
{
    public interface IMessageService
    {
        Task<Message> GetMessageById(string plmId);
        Task<IEnumerable<Message>> GetAllMessages();
        Task<IEnumerable<Message>> GetMessagesByObjectPlmid(string objectPlmid);
        Task<IEnumerable<Message>> GetMessagesByProjectName(string projectName);
    }
}
