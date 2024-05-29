using TaskViewerApis.Interfaces;
using TaskViewerApis.Models;

namespace TaskViewerApis.Services
{
    public class MessageService : IMessageService
    {
        public Task<IEnumerable<Message>> GetAllMessages()
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetMessageById(string plmId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Message>> GetMessagesByObjectPlmid(string objectPlmid)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Message>> GetMessagesByProjectName(string projectName)
        {
            throw new NotImplementedException();
        }
    }
}
