using TaskViewer.Models;
using TaskViewerApis.Helpers;
using TaskViewerApis.Models;

namespace TaskViewerApis.Interfaces
{
    public interface ILaService
    {
        Task<IEnumerable<La>> GetAllLas();
        Task<La> GetLa(string plmId);
        Task<PaginatedResponse<La>> GetLaPage(int page, int pageSize);

    }
}
