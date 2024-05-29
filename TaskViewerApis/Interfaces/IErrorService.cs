using TaskViewerApis.Dtos;
using TaskViewerApis.Models;

namespace TaskViewerApis.Interfaces
{
    public interface IErrorService
    {
        Task<Error> getError(string id);
        Task<IEnumerable<Error>> getErrors();
        Task<Error> createError(Error error);
        Task<Error> updateError(string id, Error error);
        string GenerateNewErrorPlmId();
        Task<bool> deleteError(string id);



    }
}
